using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public CanvasGroup dialogueCanvas;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void StartDialogue()
    {
        dialogueCanvas.alpha = 1;
    }
}
