using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeSystem : MonoSingleton<SeeSystem>
{
    [SerializeField] private GameObject bigObject, seeObject, backPos;
    public bool isBack;

    public IEnumerator SeeObject()
    {
        yield return new WaitForSeconds(0.1f);
        AllClose();
        seeObject.transform.GetChild(SpawnSystem.Instance.ObjectsID[0]).gameObject.SetActive(true);
    }
    public IEnumerator GoObject(GameObject pos)
    {
        yield return null;
        while (true)
        {
            bigObject.transform.position = Vector3.MoveTowards(bigObject.transform.position, pos.transform.position, Time.deltaTime * 25);
            yield return new WaitForSeconds(Time.deltaTime);
            if (0.2f > Vector3.Distance(bigObject.transform.position, pos.transform.position))
            {
                isBack = true;
                StartCoroutine(BackPos());
                break;
            }
        }
    }
    public IEnumerator BackPos()
    {
        yield return null;
        while (isBack)
        {
            bigObject.transform.position = Vector3.MoveTowards(bigObject.transform.position, backPos.transform.position, Time.deltaTime * 25);
            yield return new WaitForSeconds(Time.deltaTime);
            if (0.2f > Vector3.Distance(bigObject.transform.position, backPos.transform.position))
            {
                isBack = false;
                break;
            }
        }
    }
    private void AllClose()
    {

        for (int i = 0; i < seeObject.transform.childCount; i++)
        {
            seeObject.transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
