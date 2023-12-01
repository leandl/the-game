using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallView : MonoBehaviour
{
    private BallController __controllerBall;

    // Start is called before the first frame update
    void Start()
    {
        __controllerBall = GetComponent<BallController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("brick"))
        {
            __controllerBall.PerfectAngleReflect(collision);
            BrickView __brickView = collision.gameObject.GetComponent<BrickView>();
            __brickView.PerformTakeDamage(1);
            __controllerBall.playAudio();
        }
        else if (collision.gameObject.CompareTag("wall"))
        {
            __controllerBall.PerfectAngleReflect(collision);
            __controllerBall.playAudio();
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 direction = __controllerBall.CalcBallAngleReflect(collision);
            __controllerBall.AngleChange(direction);
            __controllerBall.playAudio();
        }
        else if (collision.gameObject.CompareTag("dead"))
        {
            Data.isAlive = false;
        }
    }
}
