using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoSingleton<TimerSystem>
{
    public GameObject TimerPanel;
    [SerializeField] Image bar;

    public void BarUpdate(int max, int count, int down)
    {
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
