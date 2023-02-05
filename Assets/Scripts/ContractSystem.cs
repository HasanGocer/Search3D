using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContractSystem : MonoSingleton<ContractSystem>
{

    [System.Serializable]
    public class Contract
    {
        public List<int> objectTypeCount = new List<int>();
        public List<int> objectCount = new List<int>();
        public int maxItem, noewItem;
    }

    public Contract FocusContract = new Contract();

    public GameObject taskAnim, bossAnim;

    public void FirstStart()
    {
        FocusContract = NewContract(GameManager.Instance.level, 2, ItemData.Instance.field.objectCount, ItemData.Instance.field.objectTypeCount);
    }
    public void ObjectCountUpdate(int objectTypeCount)
    {
        FocusContract.objectCount[objectTypeCount]--;
        FocusContract.noewItem++;
        if (FocusContract.objectCount[objectTypeCount] <= 0) FocusContract.objectTypeCount[objectTypeCount] = -2;

        StartCoroutine(QueryContract());
    }

    private Contract NewContract(int level, int levelMod, int maxItemCount, int maxitemTypeCount)
    {
        Contract contract = new Contract();

        for (int i = 0; i < (level / levelMod) + 1; i++)
        {
            bool isFree;
            int itemTypeCount;
            do
            {
                isFree = false;
                itemTypeCount = Random.Range(0, maxitemTypeCount);

                for (int j = 0; j < contract.objectTypeCount.Count; j++)
                    if (contract.objectTypeCount[j] == itemTypeCount) isFree = true;
            }
            while (isFree);
            int itemCount = Random.Range(maxItemCount * 1, maxItemCount * 3);

            contract.maxItem += itemCount;
            contract.objectTypeCount.Add(itemTypeCount);
            contract.objectCount.Add(itemCount);
        }

        return contract;
    }
    private IEnumerator QueryContract()
    {
        yield return null;
        bool isFinish = true;

        for (int i = 0; i < FocusContract.objectCount.Count; i++)
            if (FocusContract.objectCount[i] > 0) isFinish = false;

        if (isFinish && WrongSystem.Instance.nowWrongCount <= WrongSystem.Instance.maxWrongCount)
        {
            ContractUISystem.Instance.TaskPanel.SetActive(false);
            WrongSystem.Instance.FailPanel.SetActive(false);
            PointText.Instance.pointTextParent.SetActive(false);
            SpawnSystem.Instance.ObjectSetActiveFalse();
            GameManager.Instance.gameStat = GameManager.GameStat.finish;
            yield return new WaitForSeconds(1);
            StartCoroutine(FinishSystem.Instance.FinishMove());
        }
    }
    public void ContractFinish()
    {
        ItemData.Field field = ItemData.Instance.field;
        Buttons.Instance.winPanel.SetActive(true);

        Vibration.Vibrate(30);
        SoundSystem.Instance.CallBar();
        LevelManager.Instance.CheckLevel();
        if (GameManager.Instance.level % 5 == 0)
            StartCoroutine(BarSystem.Instance.BarImageFillAmountIenum());
    }
    public IEnumerator TaskAnim()
    {
        if (GameManager.Instance.level % 5 != 0)
            taskAnim.SetActive(true);
        else
            bossAnim.SetActive(true);
        yield return new WaitForSeconds(2);
        SpawnSystem.Instance.PlaneOpen();
        taskAnim.SetActive(false);
        bossAnim.SetActive(false);
    }
}
