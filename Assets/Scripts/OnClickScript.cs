using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sRender;
    private bool active = true;
    
    void Start()
    {
        sRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        if(active)
        {
            if (sRender.color == Utilities.winColor.GetComponent<SpriteRenderer>().color
                && sRender.sprite == Utilities.winShape.GetComponent<SpriteRenderer>().sprite)
            {
                sRender.color = Color.white;
                Utilities.incrementCount(1);
            }
            
            else
            {
                sRender.color = Color.black;
                Utilities.incrementCount(-1);
            }
            active = false;
        }
        
    }
}
