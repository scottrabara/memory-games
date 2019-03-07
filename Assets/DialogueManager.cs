using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    // UI Elements
    public Text nameText;
    public Text dialogueText;
    public CanvasGroup dialogueBox;
    public CanvasGroup answerBox;
    public Text answerText1;
    public Text answerText2;
    public Text answerText3;
    public Text answerText4;

    private Queue<string> sentences;

    // Start is called before the first frame update
    public void Start()
    {
        sentences = new Queue<string>();
        dialogueBox.alpha = 1;
        answerBox.alpha = 0;
    }


    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.personName);
        nameText.text = dialogue.personName;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            SetAnswers();
            return;
        }

        var sentence = sentences.Dequeue();
        dialogueText.text = sentence;
        Debug.Log(sentence);
    }

    public void SetAnswers()
    {
        answerText1.text = "answer1";
        answerText2.text = "answer2";
        answerText3.text = "answer3";
        answerText4.text = "answer4";
        answerBox.alpha = 1;
    }

    public void CheckAnswer(Text text)
    {
        if (text.text == "answer4")
            Debug.Log("Correct Answer!");
        else
            Debug.Log("Incorrect Answer!");
    }

    public void EndDialogue()
    {
        Debug.Log("End conversation");
    }
}
