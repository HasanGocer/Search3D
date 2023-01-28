using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSystem : MonoSingleton<SpawnSystem>
{
    public int OPObjectCount;
    [SerializeField] private float _spawnTime;
    [SerializeField] private GameObject _startPos, _finishPos;
    public GameObject finishBoxPos;

    public IEnumerator SpawnStart()
    {
        while (true)
        {
            yield return null;

            if (GameManager.Instance.isStart)
            {
                int count = Random.Range(0, ItemData.Instance.field.objectTypeCount);
                GameObject obj = ObjectPool.Instance.GetPooledObject(OPObjectCount + count);
                obj.transform.position = _startPos.transform.position;
                StartCoroutine(obj.transform.GetComponent<ObjectTouch>().Move(_finishPos));

                yield return new WaitForSeconds(_spawnTime);
            }
        }
    }
}
