using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSystem : MonoSingleton<ParticalSystem>
{
    [SerializeField] int _OPFinishParticalCount;
    [SerializeField] int _finishParticalTime;

    public IEnumerator CallFinishPartical(GameObject pos)
    {
        GameObject obj = ObjectPool.Instance.GetPooledObject(_OPFinishParticalCount);
        obj.transform.position = pos.transform.position;
        yield return new WaitForSeconds(_finishParticalTime);
        ObjectPool.Instance.AddObject(_OPFinishParticalCount, obj);
    }
}
