using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    private PlayerController __playerController;

    // Start is called before the first frame update
    void Start()
    {
        __playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        __playerController.Move(h);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            __playerController.BlockedMove();
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            __playerController.AllowedMove();
        }
    }
}
