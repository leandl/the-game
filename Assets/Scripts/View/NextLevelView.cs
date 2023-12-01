using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private LevelModel __levelModel;

    // Start is called before the first frame update
    void Start()
    {
        __levelModel = GetComponent<LevelModel>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Data.isAlive){
          SceneManager.LoadScene("dead", LoadSceneMode.Single);
          return;
        }
        if (__levelModel.BrickAmount <= 0) {
            if (__levelModel.NextLevel == 4){
              SceneManager.LoadScene("dead", LoadSceneMode.Single);
              return;
            }
            string nameScene =  "level" + __levelModel.NextLevel.ToString();
            SceneManager.LoadScene(nameScene, LoadSceneMode.Single);
        }
    }
}
