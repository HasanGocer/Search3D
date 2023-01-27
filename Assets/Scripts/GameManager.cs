using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoSingleton<GameManager>
{
    //managerde bulunacak

    public bool isStart;

    public int addedMoney;
    public int level;
    public int money;
    public int vibration;
    public int sound;

    public void Awake()
    {
        PlayerPrefsPlacement();
        ItemData.Instance.AwakeID();
    }

    private void PlayerPrefsPlacement()
    {
        if (PlayerPrefs.HasKey("money"))
            money = PlayerPrefs.GetInt("money");
        else
            PlayerPrefs.SetInt("money", 100);
        MoneySystem.Instance.MoneyTextRevork(0);

        if (PlayerPrefs.HasKey("level"))
            level = PlayerPrefs.GetInt("level");
        else
            PlayerPrefs.SetInt("level", level);

        if (PlayerPrefs.HasKey("vibration"))
            vibration = PlayerPrefs.GetInt("vibration");
        else
            PlayerPrefs.SetInt("vibration", vibration);

        if (PlayerPrefs.HasKey("sound"))
            sound = PlayerPrefs.GetInt("sound");
        else
            PlayerPrefs.SetInt("sound", sound);

        if (PlayerPrefs.HasKey("first"))
            ItemData.Instance.factor = FactorPlacementRead();
        else
        {
            PlayerPrefs.SetInt("first", 1);
            FactorPlacementWrite(ItemData.Instance.factor);
        }
    }

    public void FactorPlacementWrite(ItemData.Field factor)
    {
        string jsonData = JsonUtility.ToJson(factor);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/FactorData.json", jsonData);
    }

    public void ContractPlacementWrite(ContractSystem.Contract contract)
    {
        string jsonData = JsonUtility.ToJson(contract);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/contractData.json", jsonData);
    }

    public ItemData.Field FactorPlacementRead()
    {
        string jsonRead = System.IO.File.ReadAllText(Application.persistentDataPath + "/FactorData.json");
        ItemData.Field factor = new ItemData.Field();
        factor = JsonUtility.FromJson<ItemData.Field>(jsonRead);
        return factor;
    }

    public ContractSystem.Contract ContractPlacementRead()
    {
        string jsonRead = System.IO.File.ReadAllText(Application.persistentDataPath + "/contractData.json");
        ContractSystem.Contract contract = new ContractSystem.Contract();
        contract = JsonUtility.FromJson<ContractSystem.Contract>(jsonRead);
        return contract;
    }

    public void SetMoney()
    {
        PlayerPrefs.SetInt("money", money);
    }

    public void SetSound()
    {
        PlayerPrefs.SetInt("sound", sound);
    }
    public void SetLevel()
    {
        level++;
        PlayerPrefs.SetInt("level", level);
    }

    public void SetVibration()
    {
        PlayerPrefs.SetInt("vibration", vibration);
    }
}
