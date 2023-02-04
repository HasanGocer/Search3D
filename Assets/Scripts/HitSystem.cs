using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSystem : MonoSingleton<HitSystem>
{
    [Header("Ball_Field")]

    [Space(10)]

    [SerializeField] int _OPHitBallCount;
    [SerializeField] int ballSpeedFactor;
    [SerializeField] float ballMinDistance;
    [SerializeField] GameObject ballStartPos;

    public void BallJump(GameObject pos)
    {
        StartCoroutine(JumpToObject(pos));
    }

    private IEnumerator JumpToObject(GameObject pos)
    {
        GameManager gameManager = GameManager.Instance;
        GameObject ball = GetObject();
        BallPlacement(ref ball);
        float lerpCount = 0;

        while (gameManager.gameStat == GameManager.GameStat.start)
        {
            lerpCount += Time.deltaTime * ballSpeedFactor;
            ball.transform.position = Vector3.Slerp(ball.transform.position, pos.transform.position, lerpCount);
            yield return new WaitForSeconds(Time.deltaTime);
            if (ballMinDistance > Vector3.Distance(ball.transform.position, pos.transform.position))
            {
                break;
            }
        }
    }
    private GameObject GetObject()
    {
        return ObjectPool.Instance.GetPooledObject(_OPHitBallCount);
    }
    private void BallPlacement(ref GameObject ball)
    {
        ball.transform.position = ballStartPos.transform.position;
    }
    public void BackObject(GameObject ball)
    {
        ObjectPool.Instance.AddObject(_OPHitBallCount, ball);
    }

}
