using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelModel : MonoBehaviour
{
    [SerializeField]private int __currentLevel;
    [SerializeField]private int __nextLevel;
    [SerializeField]private int __brickAmount;

    public int CurrentLevel
    {
        get => __currentLevel;
        set => __currentLevel = value;
    }

    public int NextLevel
    {
        get => __nextLevel;
        set => __nextLevel = value;
    }

    public int BrickAmount
    {
        get => __brickAmount;
        set => __brickAmount = value;
    }
}
