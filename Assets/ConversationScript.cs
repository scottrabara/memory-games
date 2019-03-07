using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConversationScript : MonoBehaviour
{
    public Canvas dialogCanvas;

    public void StartConversation()
    {
        gameObject.SetActive(false);
        dialogCanvas.GetComponent<DialogScript>().Start();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
