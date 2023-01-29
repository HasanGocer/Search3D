using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSystem : MonoSingleton<TapSystem>
{
    [SerializeField] private GameObject TapGO;
    [SerializeField] private GameObject redPlane, greenPlane;
    Touch touch;
    bool isOpen;

    void Update()
    {
        if (Input.touchCount > 0 && GameManager.Instance.isStart)
        {
            touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    ColliderOpen();
                    break;
            }
        }
    }

    private void ColliderOpen()
    {
        if (!isOpen)
        {
            isOpen = true;
            TapGO.SetActive(true);
            redPlane.SetActive(false);
            greenPlane.SetActive(true);
        }
        else
        {
            isOpen = false;
            TapGO.SetActive(false);
            redPlane.SetActive(true);
            greenPlane.SetActive(false);
        }
    }
}
