using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;
            for (int i = 0; i < contract.objectTypeCount.Count; i++)
                if (contract.objectTypeCount[i] == _IDCount && GameManager.Instance.isStart) OnTheList();
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
    }
    private IEnumerator MoveToFinishBox()
    {
        float lerpCount = 0;

        print(0);
        while (true)
        {
            print(1);
            lerpCount += Time.deltaTime;
            print(2);
            transform.position = Vector3.Lerp(transform.position, SpawnSystem.Instance.finishBoxPos.transform.position, lerpCount);
            print(3);
            yield return new WaitForSeconds(Time.deltaTime);
            print(4);
            if (3 > Vector3.Distance(transform.position, SpawnSystem.Instance.finishBoxPos.transform.position))
            {
                print(5);
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
