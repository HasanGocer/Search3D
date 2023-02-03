using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoSingleton<SpawnSystem>
{
    public int OPObjectCount;
    [SerializeField] private float _spawnTime;
    [SerializeField] private GameObject _startPos, _finishPos;
    public GameObject finishBoxPos, finishBoxInsidePos;
    public List<int> ObjectsID = new List<int>();
    public List<GameObject> ObjectsGO = new List<GameObject>();

    public IEnumerator SpawnStart()
    {
        while (true)
        {
            yield return null;

            if (GameManager.Instance.gameStat == GameManager.GameStat.start)
            {
                int count = Random.Range(0, ItemData.Instance.field.objectTypeCount);
                GameObject obj = ObjectPool.Instance.GetPooledObject(OPObjectCount + count);
                obj.transform.position = _startPos.transform.position;
                StartCoroutine(obj.transform.GetComponent<ObjectTouch>().Move(_finishPos));
                ObjectsID.Add(count);
                ObjectsGO.Add(obj);

                yield return new WaitForSeconds(_spawnTime);
            }
        }
    }
}
