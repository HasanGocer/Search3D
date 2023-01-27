using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ContractUISystem : MonoSingleton<ContractUISystem>
{
    public GameObject TaskPanel;
    [SerializeField] List<Sprite> _TempImage = new List<Sprite>();
    [SerializeField] Sprite _AcceptImage;
    [SerializeField] List<Image> _TaskImage = new List<Image>();
    [SerializeField] List<GameObject> _TaskImagePos = new List<GameObject>();
    [SerializeField] List<TMP_Text> _TaskTextPos = new List<TMP_Text>();

    public void UIPlacement()
    {
        ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;

        for (int i = 0; i < contract.objectTypeCount.Count; i++)
        {
            _TaskImagePos[i].gameObject.SetActive(true);
            _TaskImage[i].sprite = _TempImage[contract.objectTypeCount[i]];
            _TaskTextPos[i].text = contract.objectCount[i].ToString();
        }
    }

    public void TaskDown(int typeCount)
    {
        ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;

        int tempTypeCount = contract.objectTypeCount.IndexOf(typeCount);
        ContractSystem.Instance.ObjectCountUpdate(tempTypeCount);
        _TaskTextPos[tempTypeCount].text = contract.objectCount[tempTypeCount].ToString();
        if (contract.objectCount[tempTypeCount] <= 0)
        {
            _TaskTextPos[tempTypeCount].gameObject.transform.parent.gameObject.SetActive(false);
            _TaskImage[tempTypeCount].sprite = _AcceptImage;
        }
    }
}
