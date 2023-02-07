using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ObjectTouch : MonoBehaviour
{
    [SerializeField] int _IDCount;
    int tempID;
    public bool isTrigger;
    bool isBall;

    private void OnMouseDown()
    {
        if (isBall == false)
        {
            isBall = true;
            HitSystem.Instance.BallJump(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sorter") && !isTrigger)
        {
            transform.DOShakeScale(0.5f, 0.7f);
            Vibration.Vibrate(30);
            SoundSystem.Instance.CallObjectTouch();
            HitSystem.Instance.BackObject(other.gameObject);
            ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;
            for (int i = 0; i < contract.objectTypeCount.Count; i++)
                if (contract.objectTypeCount[i] == _IDCount && GameManager.Instance.gameStat == GameManager.GameStat.start && !isTrigger)
                {
                    int monetCount = Random.Range(5, 10);
                    MoneySystem.Instance.MoneyTextRevork(monetCount);
                    PointText.Instance.CallMoneyText(gameObject, monetCount, true);
                    ContractUISystem.Instance.TaskDown(_IDCount);
                    tempID = _IDCount;
                    _IDCount = -1;
                    isTrigger = true;
                    StartCoroutine(FinishPositionMove(tempID));
                    TimerSystem.Instance.BarUpdate(ContractSystem.Instance.FocusContract.maxItem, ContractSystem.Instance.FocusContract.noewItem, 1);
                }

            if (!isTrigger && GameManager.Instance.gameStat == GameManager.GameStat.start)
            {
                int monetCount = Random.Range(5, 10);
                MoneySystem.Instance.MoneyTextRevork(-1 * monetCount);
                PointText.Instance.CallMoneyText(gameObject, monetCount, false);
                isTrigger = true;
                tempID = _IDCount;
                _IDCount = -1;
                WrongSystem.Instance.WrongCanvas(gameObject, tempID);
            }
        }
        if (other.CompareTag("Finish"))
        {
            isTrigger = true;
            ObjectPool.Instance.AddObject(SpawnSystem.Instance.OPObjectCount + _IDCount, gameObject);
        }
    }

    private IEnumerator FinishPositionMove(int ID)
    {
        transform.DOJump(SpawnSystem.Instance.finishPos.transform.position, 2, 2, 2f);
        yield return new WaitForSeconds(2);
        BackObject(ID);
    }
    private void BackObject(int ID)
    {
        ObjectPool.Instance.AddObject(SpawnSystem.Instance.OPObjectCount + ID, gameObject);
    }
    public IEnumerator Move(GameObject target)
    {
        yield return null;
        while (!isTrigger && GameManager.Instance.gameStat == GameManager.GameStat.start)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, Time.deltaTime * 12);
            yield return new WaitForSeconds(Time.deltaTime / 3);
        }
    }
}
