using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    private Text __score;

    // Start is called before the first frame update
    void Start()
    {
        __score = GetComponent<Text>();
        __score.text = Data.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (__score.text != Data.score.ToString())
        {
          __score.text = Data.score.ToString();
        }
    }
}
