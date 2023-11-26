using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel __playerModel;
    private Transform __transform;
    private bool __isAllowedMovingLeft = true;
    private bool __isAllowedMovingRight = true;

    private float __initialPossionX;

    // Start is called before the first frame update
    void Start()
    {
        __playerModel = GetComponent<PlayerModel>();
        __transform = GetComponent<Transform>();
        __initialPossionX = __transform.position.x;
    }

    public void Move(float h)
    {
        if ((__isAllowedMovingLeft && h < 0) || (__isAllowedMovingRight && h > 0))
        {
            __transform.Translate(Vector2.right * (h * __playerModel.Speed * Time.deltaTime));
        }
    }

    public void BlockedMove()
    {
        bool isPositionToTheLeft = __transform.position.x < __initialPossionX;
        bool isPositionToTheRight = __transform.position.x > __initialPossionX;

        __isAllowedMovingLeft = !isPositionToTheLeft;
        __isAllowedMovingRight = !isPositionToTheRight;
    }

    public void AllowedMove()
    {
        __isAllowedMovingLeft = true;
        __isAllowedMovingRight = true;
    }
}
