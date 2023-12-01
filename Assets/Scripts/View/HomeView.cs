using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HomeView : MonoBehaviour
{
    public InputField __username;

    public void ButtonDemo()
    {
      if (__username.text != "")
      {
        Data.username = __username.text;
        SceneManager.LoadScene("level1", LoadSceneMode.Single);
      }
    }
}
