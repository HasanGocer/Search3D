using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class WrongSystem : MonoSingleton<WrongSystem>
{
    public GameObject FailPanel, freePos;
    public List<Image> WrongImage = new List<Image>();
    [SerializeField] GameObject imageTempPos;
    public int nowWrongCount = 0, maxWrongCount = 2;
    [SerializeField] Image tempImage;
    [SerializeField] Sprite wrongMark;
    [SerializeField] Material redMat, Mat2D;

    public void WrongCanvas(GameObject obj, int IDCount)
    {
        StartCoroutine(WrongCanvasMove(obj, IDCount));
    }

    public IEnumerator WrongCanvasMove(GameObject obj, int IDCount)
    {
        ObjectTouch objectTouch = obj.GetComponent<ObjectTouch>();

        if (nowWrongCount >= maxWrongCount)
        {
            ContractUISystem.Instance.TaskPanel.SetActive(false);
            WrongSystem.Instance.FailPanel.SetActive(false);
            GameManager.Instance.gameStat = GameManager.GameStat.finish;
            Buttons.Instance.failPanel.SetActive(true);
            //CabinetSystem.Instance.AllObjectClose();
        }
        tempImage.transform.localScale = new Vector3(7, 7, 7);
        tempImage.gameObject.SetActive(true);
        tempImage.transform.position = imageTempPos.transform.position;
        tempImage = CallWrong(tempImage, wrongMark, redMat);
        obj.transform.position = freePos.transform.position;
        tempImage.transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        tempImage.transform.DOMove(WrongImage[nowWrongCount].gameObject.transform.position, 0.5f).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(1f);
        nowWrongCount++;
        tempImage.gameObject.SetActive(false);
        WrongImage[nowWrongCount - 1] = CallWrong(WrongImage[nowWrongCount - 1], wrongMark, redMat);
        yield return new WaitForSeconds(1.7f);
        objectTouch.IDBackPlacement();
        ObjectPool.Instance.AddObject(SpawnSystem.Instance.OPObjectCount + IDCount, obj);
    }

    private Image CallWrong(Image freeImage, Sprite freeSprite, Material RedMat)
    {
        Image tempImage = freeImage;
        tempImage.sprite = freeSprite;
        Material mat = new Material(Mat2D.shader);
        tempImage.material = mat;
        tempImage.color = RedMat.color;
        return tempImage;
    }
}
