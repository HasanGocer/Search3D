using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoSingleton<LevelManager>
{
    [SerializeField] private int typeCountMod, countMod;

    public void CheckLevel()
    {
        if (GameManager.Instance.level % typeCountMod == 0) ItemData.Instance.SetObjectTypeCount();
        if (GameManager.Instance.level % countMod == 0) ItemData.Instance.SetObjectCount();
    }
}
