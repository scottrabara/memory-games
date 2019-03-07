using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableHiddenButtons : MonoBehaviour
{
    public GameObject HiddenButtons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.H))
        {
            if (!HiddenButtons.activeSelf)
            {
                HiddenButtons.SetActive(true);
            }
        }
    }
}
