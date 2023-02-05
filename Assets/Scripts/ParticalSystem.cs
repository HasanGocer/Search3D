using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalSystem : MonoSingleton<ParticalSystem>
{
    [SerializeField] int _OPFinishParticalCount, _OPObjectBlastCount, _OPFinishConfettiCount, _OPBossCoinCount;
    [SerializeField] float _finishParticalTime, _objectBlastParticalTime, _bossCoinTime;

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
    }
    public void CallFinishConfettiPartical(GameObject pos)
    {
        GameObject obj = ObjectPool.Instance.GetPooledObject(_OPFinishConfettiCount);
        obj.transform.position = pos.transform.position;
    }
    public IEnumerator CallBossCoinPartical(GameObject pos)
    {
        GameObject obj = ObjectPool.Instance.GetPooledObject(_OPBossCoinCount);
        obj.transform.position = pos.transform.position;
        yield return new WaitForSeconds(_bossCoinTime);
        ObjectPool.Instance.AddObject(_OPBossCoinCount, obj);
    }
}
