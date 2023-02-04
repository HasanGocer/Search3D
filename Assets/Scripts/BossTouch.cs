using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BossTouch : MonoBehaviour
{
    private void OnMouseDown()
    {
        print(1);
        HitSystem.Instance.BallJump(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sorter"))
        {
            transform.DOShakeScale(0.5f, 0.7f);
            Vibration.Vibrate(30);
            SoundSystem.Instance.CallObjectTouch();
            HitSystem.Instance.BackObject(other.gameObject);
            int monetCount = Random.Range(5, 10);
            StartCoroutine(PointText.Instance.CallPointMoneyText(gameObject, monetCount, true));
            GameManager.Instance.addedMoney += monetCount;
        }
        if (other.CompareTag("Finish"))
        {
            gameObject.SetActive(false);
            ContractSystem.Instance.ContractFinish();
        }
    }

}
