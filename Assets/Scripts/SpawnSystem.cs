using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SpawnSystem : MonoSingleton<SpawnSystem>
{
    public int OPObjectCount;
    [SerializeField] private float _spawnTime;
    [SerializeField] List<GameObject> _startPos = new List<GameObject>();
    [SerializeField] List<GameObject> _finishPos = new List<GameObject>();
    [SerializeField] List<GameObject> _planes = new List<GameObject>();
    [SerializeField] List<GameObject> _planesStartPos = new List<GameObject>();
    [SerializeField] List<GameObject> _planesFinishPos = new List<GameObject>();
    public GameObject bossGO;
    public GameObject finishPos;
    public int finishMoveFactor;
    public List<GameObject> ObjectsGO = new List<GameObject>();

    public void PlaneOpen()
    {
        if (GameManager.Instance.level % 5 != 0)
        {
            StartCoroutine(PlaneOnPlacement(0));

            for (int i = 1; i < _planes.Count; i++)
                if (Random.Range(0, 2) == 1)
                    StartCoroutine(PlaneOnPlacement(i));
        }
        else
        {
            StartCoroutine(PlaneOnPlacement(1));
        }

    }
    public void PlaneOff()
    {
        for (int i = 0; i < _planes.Count; i++)
            if (_planes[i].activeInHierarchy)
                StartCoroutine(PlaneOffPlacement(i));
    }
    public void ObjectSetActiveFalse()
    {
        for (int i = 0; i < ObjectsGO.Count; i++)
            ObjectsGO[i].SetActive(false);
    }

    private IEnumerator PlaneOffPlacement(int i)
    {
        _planes[i].transform.DOMove(_planesFinishPos[i].transform.position, 1).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(1);
    }
    private IEnumerator PlaneOnPlacement(int i)
    {
        _planes[i].SetActive(true);
        _planes[i].transform.DOMove(_planesStartPos[i].transform.position, 1).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(1);
        if (GameManager.Instance.level % 5 != 0)
            StartCoroutine(SpawnStart(i));
        else
            StartCoroutine(BossMove(_finishPos[1].transform.position + new Vector3(0, 3, 0)));
    }
    private IEnumerator BossMove(Vector3 target)
    {
        GameObject tempBossGO = Instantiate(bossGO);
        tempBossGO.transform.position = _planesStartPos[1].transform.position + new Vector3(0, 3, 0);
        yield return null;
        while (true)
        {
            tempBossGO.transform.position = Vector3.MoveTowards(tempBossGO.transform.position, target, Time.deltaTime * 6);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
    private IEnumerator SpawnStart(int i)
    {
        while (true)
        {
            yield return null;

            if (GameManager.Instance.gameStat == GameManager.GameStat.start)
            {
                int count = Random.Range(0, ItemData.Instance.field.objectTypeCount);
                GameObject obj = ObjectPool.Instance.GetPooledObject(OPObjectCount + count);
                obj.transform.position = _startPos[i].transform.position;
                StartCoroutine(obj.transform.GetComponent<ObjectTouch>().Move(_finishPos[i]));
                ObjectsGO.Add(obj);

                yield return new WaitForSeconds(_spawnTime);
            }
        }
    }
}
