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
    }

    public Contract FocusContract = new Contract();

    public void FirstStart()
    {
        FocusContract = NewContract(GameManager.Instance.level, 5, ItemData.Instance.field.objectCount, ItemData.Instance.field.objectTypeCount);
    }
    public void ObjectCountUpdate(int objectTypeCount)
    {
        FocusContract.objectTypeCount[objectTypeCount]--;

        QueryContract();
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

                for (int j = 0; j < FocusContract.objectTypeCount.Count; j++)
                    if (FocusContract.objectTypeCount[j] == itemTypeCount) isFree = true;
            }
            while (isFree);
            int itemCount = Random.Range(maxItemCount * 2, maxItemCount * 5);

            contract.objectTypeCount.Add(itemTypeCount);
            contract.objectCount.Add(itemCount);
        }

        return contract;
    }
    private void QueryContract()
    {
        bool isFinish = true;

        for (int i = 0; i < FocusContract.objectCount.Count; i++)
            if (FocusContract.objectCount[i] > 0) isFinish = false;

        if (isFinish)
            ContractFinish();
    }
    private void ContractFinish()
    {
        ItemData.Field field = ItemData.Instance.field;
        Buttons.Instance.winPanel.SetActive(true);

        int money = Random.Range(10 * field.objectTypeCount, 30 * field.objectTypeCount);
        StartCoroutine(BarSystem.Instance.BarImageFillAmountIenum());
        Buttons.Instance.finishGameMoneyText.text = MoneySystem.Instance.NumberTextRevork(money);
        GameManager.Instance.addedMoney = money;
        // StartCoroutine(Buttons.Instance.NoThanxOnActive());
    }
}
