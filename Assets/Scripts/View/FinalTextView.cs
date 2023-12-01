using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTextView : MonoBehaviour
{
    private Text __finalText;

    // Start is called before the first frame update
    void Start()
    {
        __finalText = GetComponent<Text>();

        if (Data.isAlive){
          __finalText.text = "Parabéns " + Data.username + ", você ganhou!";
        } else{
          __finalText.text = "Decepção, " + Data.username + ", você perdeu!";
        }
    }
}
