using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueName;
    public Text dialogueSentences;
    public GameObject saveButton;
    public GameObject inventoryButton;
    private Queue<string> names;
    private Queue<string> sentences;
    public Animator animator;
    public static bool playCutscene = false;
    // Start is called before the first frame update
    void Start()
    {
        names = new Queue<string>();
        sentences = new Queue<string>();
    }

  
    public void StartDialogue(Dialogue dialogue)
    {
        playCutscene = false;
        inventoryButton.SetActive(false);
        saveButton.SetActive(false);
        animator.SetBool("isOpen", true);
        names.Clear();
        sentences.Clear();
        
        for(int i = 0; i<dialogue.sentences.Length; i++)
        {
            names.Enqueue(dialogue.name[i]);
            sentences.Enqueue(dialogue.sentences[i]);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string playerName = names.Dequeue();
        dialogueName.text = playerName;
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        dialogueSentences.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueSentences.text += letter;
            yield return null;
        }
    }

    public void EndDialogue()
    {
        inventoryButton.SetActive(true);
        saveButton.SetActive(true);
        animator.SetBool("isOpen", false);
        PlayerMovement.isTalking = false;
        playCutscene = true;
    }
}
