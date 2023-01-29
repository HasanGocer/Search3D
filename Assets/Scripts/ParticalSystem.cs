using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSystem : MonoSingleton<ParticalSystem>
{
    [SerializeField] int _OPFinishParticalCount, _OPObjectBlastCount;
    [SerializeField] float _finishParticalTime, _objectBlastParticalTime;

    public IEnumerator CallFinishPartical(GameObject pos)
    {
        GameObject obj = ObjectPool.Instance.GetPooledObject(_OPFinishParticalCount);
        obj.transform.position = pos.transform.position;
        yield return new WaitForSeconds(_finishParticalTime);
        ObjectPool.Instance.AddObject(_OPFinishParticalCount, obj);
    }
    public IEnumerator CallObjectBlastPartical(GameObject pos, int tempID)
    {
        GameObject obj = ObjectPool.Instance.GetPooledObject(_OPObjectBlastCount);
        obj.transform.position = pos.transform.position;
        yield return new WaitForSeconds(_objectBlastParticalTime);
        ObjectPool.Instance.AddObject(_OPObjectBlastCount, obj);
        ObjectPool.Instance.AddObject(SpawnSystem.Instance.OPObjectCount + tempID, pos);
    }
}
