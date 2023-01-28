using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class WrongSystem : MonoSingleton<WrongSystem>
{
    public GameObject FailPanel;
    public List<Image> WrongImage = new List<Image>();
    [SerializeField] GameObject imageTempPos;
    public int nowWrongCount = 0, maxWrongCount = 2;
    [SerializeField] Image tempImage;
    [SerializeField] Sprite wrongMark;
    [SerializeField] Material redMat, Mat2D;

    public IEnumerator WrongCanvasMove(GameObject obj, int IDCount)
    {
        if (nowWrongCount >= maxWrongCount)
        {
            GameManager.Instance.isStart = false;
            Buttons.Instance.failPanel.SetActive(true);
            GameManager.Instance.isStart = false;
            //CabinetSystem.Instance.AllObjectClose();
        }
        tempImage.transform.localScale = new Vector3(7, 7, 7);
        tempImage.gameObject.SetActive(true);
        tempImage.transform.position = imageTempPos.transform.position;
        tempImage = CallWrong(tempImage, wrongMark, redMat);
        tempImage.transform.DOScale(new Vector3(1, 1, 1), 1.5f);
        tempImage.transform.DOMove(WrongImage[nowWrongCount].gameObject.transform.position, 1.5f).SetEase(Ease.InOutSine);
        yield return new WaitForSeconds(1.5f);
        nowWrongCount++;
        tempImage.gameObject.SetActive(false);
        WrongImage[nowWrongCount - 1] = CallWrong(WrongImage[nowWrongCount - 1], wrongMark, redMat);
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
