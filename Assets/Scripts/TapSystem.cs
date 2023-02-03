using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSystem : MonoSingleton<TapSystem>
{
    /*
    [SerializeField] private GameObject TapGO;
    [SerializeField] private GameObject redPlane, greenPlane;
    Touch touch;
    bool isOpen;

    void Update()
    {
        if (Input.touchCount > 0 && GameManager.Instance.gameStat == GameManager.GameStat.start)
        {
            touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    ColliderOpen();
                    break;
                case TouchPhase.Ended:
                    isOpen = false;
                    TapGO.SetActive(false);
                    redPlane.SetActive(true);
                    greenPlane.SetActive(false);
                    break;
            }
        }
    }

    private void ColliderOpen()
    {
        isOpen = true;
        TapGO.SetActive(true);
        redPlane.SetActive(false);
        greenPlane.SetActive(true);

    }*/
}
