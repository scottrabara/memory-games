using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    public Button continueButton;

    private Queue<string> sentences;
    private string[] answers;
    private string correctAnswer;

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

        if (sentences == null)
            sentences = new Queue<string>();
        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            var modifiedSentence = sentence.Replace("[Name]", PlayerPrefs.GetString("name_WelcomeNeighbor"));
            sentences.Enqueue(modifiedSentence);
        }

        answers = dialogue.answers;

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        var sentence = sentences.Dequeue();
        dialogueText.text = sentence;

        if (sentence.EndsWith("?"))
        {
            DisableContinue();
            SetAnswers();
        }            

        Debug.Log(sentence);
    }

    public void SkipNextSentence()
    {
        sentences.Dequeue();
    }

    public void SetAnswers()
    {
        answerText1.text = answers[0];
        answerText2.text = answers[1];
        answerText3.text = answers[2];
        answerText4.text = answers[3];
        correctAnswer = answers[4];
        answerBox.alpha = 1;
    }

    public void HideAnswers()
    {
        answerBox.alpha = 0;
    }

    public void CheckAnswer(Text text)
    {
        if (text.text == correctAnswer)
        {
            SkipNextSentence();
        }
        HideAnswers();
        EnableContinue();
        DisplayNextSentence();
        sentences.Clear();
        continueButton.GetComponentInChildren<Text>(true).text = "RESTART";
    }

    public void DisableContinue()
    {
        continueButton.enabled = false;
    }

    public void EnableContinue()
    {
        continueButton.enabled = true;
    }

    public void EndDialogue()
    {
        Debug.Log("End conversation");
        SceneManager.LoadScene("WelcomeNeighbor");
    }
}
