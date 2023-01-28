using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using TMPro;

public class TimerSystem : MonoSingleton<TimerSystem>
{
    public GameObject TimerPanel;
    [SerializeField] Image bar;
    [SerializeField] RectTransform rectTransform;
    [SerializeField] TMP_Text nowLevel, nextLevel;

    public void StartTimer()
    {
        nowLevel.text = GameManager.Instance.level.ToString();
        nextLevel.text = (GameManager.Instance.level + 1).ToString();
    }

    public void BarUpdate(int max, int count, int down)
    {
        TimerPanel.transform.DOShakeScale(0.7f, 0.01f);

        float nowBar = (float)count / (float)max;
        float afterBar = ((float)count + (float)down) / (float)max;
        if (afterBar > 1)
            afterBar = 1;
        StartCoroutine(ObjectBar(nowBar, afterBar));
    }


    private IEnumerator ObjectBar(float start, float finish)
    {
        ContractSystem.Contract contract = ContractSystem.Instance.FocusContract;
        float lerpCount = 0;

        while (true)
        {
            yield return null;
            lerpCount += Time.deltaTime;
            bar.fillAmount = Mathf.Lerp(start, finish, lerpCount);
            rectTransform.anchoredPosition = new Vector2((rectTransform.sizeDelta.x * bar.fillAmount * 4.5f) - 250, rectTransform.anchoredPosition.y);
            yield return new WaitForEndOfFrame();
            if (bar.fillAmount == finish) break;
        }
    }

    /*public IEnumerator TimerStart()
    {
        for (int i = 0; i < timerCount * 2 && !GameManager.Instance.isFinish; i++)
        {
            tempTimerCount += 0.5f;
            bar.fillAmount = tempTimerCount / timerCount;
            yield return new WaitForSeconds(0.5f);
        }
        if (!GameManager.Instance.isFinish)
        {
            Buttons.Instance.failPanel.SetActive(true);
            GameManager.Instance.isFinish = true;
            GameManager.Instance.isStart = false;
        }
    }*/
}
