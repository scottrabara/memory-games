using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialog()
    {
        var dialogueManager = FindObjectOfType<DialogueManager>();
        if (dialogueManager == null)
            Debug.Log("Dialogue Manager not initialized");
        else
            dialogueManager.StartDialogue(dialogue);
    }
}
