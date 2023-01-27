using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTouch : MonoBehaviour
{
    [SerializeField] int _IDCount;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sorter"))
        {
            ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;
            for (int i = 0; i < contract.objectTypeCount.Count; i++)
                if (contract.objectTypeCount[i] == _IDCount) OnTheList();
        }
    }

    private void OnTheList()
    {
        ContractUISystem.Instance.TaskDown(_IDCount);
    }
}
