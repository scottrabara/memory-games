using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickScript : MonoBehaviour
{
    // Start is called before the first frame update
    public SpriteRenderer sRender;
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
        sRender.color = Color.white;
    }
}
