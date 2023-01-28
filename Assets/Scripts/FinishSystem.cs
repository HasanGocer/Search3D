using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FinishSystem : MonoSingleton<FinishSystem>
{
    [SerializeField] private GameObject box, boxPos;
    [SerializeField] Animator boxRight, boxLeft;
    bool isRotation;

    public IEnumerator FinishMove()
    {
        yield return null;
        boxRight.enabled = true;
        boxLeft.enabled = true;
        isRotation = true;
        StartCoroutine(BoxRotation());
        box.transform.DOMove(boxPos.transform.position, 2);
        yield return new WaitForSeconds(2.5f);
        isRotation = false;
        box.SetActive(false);
        StartCoroutine(ParticalSystem.Instance.CallFinishPartical(box));
        GameManager.Instance.isStart = false;
        GameManager.Instance.isFinish = true;
        ContractSystem.Instance.ContractFinish();
    }

    private IEnumerator BoxRotation()
    {
        while (isRotation)
        {
            box.transform.Rotate(Vector3.up * Time.deltaTime * 150);
            yield return new WaitForEndOfFrame();
        }
    }
}
