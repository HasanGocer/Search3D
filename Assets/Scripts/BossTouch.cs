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
            StartCoroutine(Shake());
            Vibration.Vibrate(30);
            SoundSystem.Instance.CallObjectTouch();
            StartCoroutine(ParticalSystem.Instance.CallBossCoinPartical(gameObject));
            HitSystem.Instance.BackObject(other.gameObject);
            int monetCount = Random.Range(5, 10);
            PointText.Instance.CallMoneyText(gameObject, monetCount, true);
            GameManager.Instance.addedMoney += monetCount;
        }
        if (other.CompareTag("Finish"))
        {
            SpawnSystem.Instance.PlaneOff();
            PointText.Instance.pointTextParent.SetActive(false);
            gameObject.SetActive(false);
            ContractSystem.Instance.ContractFinish();
        }
    }
    private IEnumerator Shake()
    {
        transform.DOShakeScale(0.5f, 0.7f);
        yield return new WaitForSeconds(0.6f);
        transform.localScale = new Vector3(1, 1, 1);
    }

}
