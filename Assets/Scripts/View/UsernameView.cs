using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UsernameView : MonoBehaviour
{
    private Text __username;

    // Start is called before the first frame update
    void Start()
    {
        __username = GetComponent<Text>();
        __username.text = Data.username;
    }

}
