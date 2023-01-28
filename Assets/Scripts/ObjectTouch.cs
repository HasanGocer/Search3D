using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTouch : MonoBehaviour
{
    [SerializeField] int _IDCount;
    public bool isTrigger;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sorter"))
        {
            ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;
            for (int i = 0; i < contract.objectTypeCount.Count; i++)
                if (contract.objectTypeCount[i] == _IDCount) OnTheList();
        }
        if (other.CompareTag("Finish"))
        {
            ObjectPool.Instance.AddObject(SpawnSystem.Instance.OPObjectCount + _IDCount, gameObject);
        }
    }

    private void OnTheList()
    {
        ContractUISystem.Instance.TaskDown(_IDCount);
        isTrigger = true;
    }
    public IEnumerator Move(GameObject target)
    {
        yield return null;
        while (!isTrigger)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * 10);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}
