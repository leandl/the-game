using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour
{
    private BrickModel __brickModel;

    private LevelModel __levelModel;
    // Start is called before the first frame update
    void Start()
    {
        __brickModel = GetComponent<BrickModel>();
        GameObject[] levelInfoGameObjects = GameObject.FindGameObjectsWithTag("level");
        __levelModel = levelInfoGameObjects[0].GetComponent<LevelModel>();
    }

    public void TakeDamage(float damage)
    {
        __brickModel.Life -= damage;
        if (__brickModel.Life <= 0)
        {
            Destroy(gameObject);
            __levelModel.BrickAmount -= 1;
            Data.score += 1;
        }
    }
}
