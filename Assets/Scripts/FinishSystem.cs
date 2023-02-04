using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class FinishSystem : MonoSingleton<FinishSystem>
{
    [SerializeField] private GameObject box, upperBox, upperBoxPos, boxPos, finishSpawnPos;
    bool isRotation;


    public IEnumerator FinishMove()
    {
        box.SetActive(true);
        SpawnSystem.Instance.PlaneOff();
        yield return null;
        box.transform.DOMove(boxPos.transform.position, 1);
        yield return new WaitForSeconds(1f);
        StartCoroutine(BoxObjectSpawn());
        yield return new WaitForSeconds(1f);
        upperBox.transform.SetParent(box.transform);
        StartCoroutine(UpperBoxMove());
        isRotation = true;
        Vibration.Vibrate(30);
        SoundSystem.Instance.CallBox();
        StartCoroutine(BoxRotation());
        yield return new WaitForSeconds(1.8f);
        isRotation = false;
        box.SetActive(false);
        StartCoroutine(ParticalSystem.Instance.CallFinishPartical(box));
        yield return new WaitForSeconds(0.8f);
        ContractSystem.Instance.ContractFinish();
    }

    private IEnumerator UpperBoxMove()
    {
        float lerpCount = 0;

        while (true)
        {
            lerpCount += Time.deltaTime * 5;
            upperBox.transform.position = Vector3.Lerp(upperBox.transform.position, upperBoxPos.transform.position, lerpCount);
            yield return new WaitForSeconds(Time.deltaTime);
            if (0.3f > Vector3.Distance(upperBox.transform.position, upperBoxPos.transform.position)) break;
        }
    }
    public IEnumerator BoxObjectSpawn()
    {
        List<GameObject> objects = new List<GameObject>();

        for (int i = 0; i < 10; i++)
        {
            GameObject obj = ObjectPool.Instance.GetPooledObject(SpawnSystem.Instance.OPObjectCount + i);
            obj.transform.position = finishSpawnPos.transform.position;
            obj.transform.localScale *= 0.5f;
            obj.GetComponent<Rigidbody>().useGravity = true;
            objects.Add(obj);
            box.transform.DOShakeScale(0.08f, 0.2f);
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.5f);
        foreach (GameObject item in objects) item.SetActive(false);
        box.transform.DORotate(new Vector3(0, 0, 0), 0.2f);
    }

    private IEnumerator BoxRotation()
    {
        while (isRotation)
        {
            box.transform.DORotate(Vector3.up * Time.deltaTime * 450 + box.transform.eulerAngles, Time.deltaTime);
            yield return new WaitForSeconds(Time.deltaTime);
        }
    }
}
