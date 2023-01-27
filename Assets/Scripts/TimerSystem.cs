using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoSingleton<TimerSystem>
{
    public GameObject TimerPanel;
    public float timerCount = 30, tempTimerCount;
    [SerializeField] Image bar;

    public IEnumerator TimerStart()
    {
        for (int i = 0; i < timerCount * 2 && !GameManager.Instance.isFinish; i++)
        {
            tempTimerCount += 0.5f;
            bar.fillAmount = tempTimerCount / timerCount;
            yield return new WaitForSeconds(0.5f);
        }
        if (!GameManager.Instance.isFinish)
        {
            //fail
        }
    }
}
