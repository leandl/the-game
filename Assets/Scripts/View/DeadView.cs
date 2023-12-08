using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeadView : MonoBehaviour
{
    public void ButtonPlayAgainButton()
    {
      Data.score = 0;
      Data.isAlive = true;
      SceneManager.LoadScene("level1", LoadSceneMode.Single);
    }
}
