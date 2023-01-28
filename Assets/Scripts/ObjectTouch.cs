using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectTouch : MonoBehaviour
{
    [SerializeField] int _IDCount;
    int tempID;
    public bool isTrigger;
    [SerializeField]

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sorter"))
        {
            transform.DOShakeScale(0.5f, 0.7f);

            ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;
            for (int i = 0; i < contract.objectTypeCount.Count; i++)
                if (contract.objectTypeCount[i] == _IDCount && GameManager.Instance.isStart) OnTheList();
            if (!isTrigger)
            {
                isTrigger = true;
                tempID = _IDCount;
                _IDCount = -1;
                StartCoroutine(WrongSystem.Instance.WrongCanvasMove(gameObject, tempID));
            }
        }
        if (other.CompareTag("Finish"))
        {
            ObjectPool.Instance.AddObject(SpawnSystem.Instance.OPObjectCount + _IDCount, gameObject);
        }
    }

    private void OnTheList()
    {
        ContractUISystem.Instance.TaskDown(_IDCount);
        tempID = _IDCount;
        _IDCount = -1;
        isTrigger = true;
        StartCoroutine(MoveToFinishBox());
        TimerSystem.Instance.BarUpdate(ContractSystem.Instance.FocusContract.maxItem, ContractSystem.Instance.FocusContract.noewItem, 1);
    }
    private IEnumerator MoveToFinishBox()
    {
        float lerpCount = 0;

        while (true)
        {
            lerpCount += Time.deltaTime / 3;
            transform.position = Vector3.Lerp(transform.position, SpawnSystem.Instance.finishBoxPos.transform.position, lerpCount);
            yield return new WaitForSeconds(Time.deltaTime);
            if (1 > Vector3.Distance(transform.position, SpawnSystem.Instance.finishBoxPos.transform.position))
            {
                ObjectPool.Instance.AddObject(SpawnSystem.Instance.OPObjectCount + tempID, gameObject);
                break;
            }
        }
    }
    public IEnumerator Move(GameObject target)
    {
        yield return null;
        while (!isTrigger && GameManager.Instance.isStart)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * 18);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}
