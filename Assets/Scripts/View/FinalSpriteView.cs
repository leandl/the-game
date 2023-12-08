using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalSpriteView : MonoBehaviour
{
    public Sprite WinSprite;
    public Sprite DeadSprite;

    // Start is called before the first frame update
    void Start()
    {
      if (Data.isAlive){
          this.gameObject.GetComponent<SpriteRenderer>().sprite = WinSprite;
        } else{
          this.gameObject.GetComponent<SpriteRenderer>().sprite = DeadSprite;
        }        
    }

}
