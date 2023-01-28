using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapSystem : MonoSingleton<TapSystem>
{
    [SerializeField] private GameObject TapGO;
    Touch touch;

    void Update()
    {
        if (Input.touchCount > 0 && GameManager.Instance.isStart)
        {
            touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    StartCoroutine(ColliderOpen());
                    break;
            }
        }
    }

    private IEnumerator ColliderOpen()
    {
        TapGO.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        TapGO.SetActive(false);
    }
}
