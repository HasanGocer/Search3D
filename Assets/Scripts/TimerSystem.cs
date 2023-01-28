using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoSingleton<TimerSystem>
{
    public GameObject TimerPanel;
    [SerializeFieldS] Image bar;

    public IEnumerator ObjectBar()
    {
        while (true)
        {
            if ()
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
