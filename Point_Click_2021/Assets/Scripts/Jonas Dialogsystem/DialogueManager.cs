using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("fix this" + gameObject.name);
        }
        else
        {
            instance = this;
        }
    }

    public GameObject dialogueBox;


    public Text dialogueName;
    public Text dialogueText;
    public Image dialoguePortrait;
    public float delay = 0.01f;

    public Queue<DialogueBase.Info> dialogueInfo; // First In First Out


     // options stuff


    private bool isDialogueOption;
    public GameObject dialogueOptionUI;
    public bool inDialouge;
    public GameObject[] optionButtons;
    private int optionsAmount;
    public Text questionText;

    private bool isCurrentlyTyping;
    private string completeText;

    public void Start()
    {
        dialogueInfo = new Queue<DialogueBase.Info>();
    }

    public void EnqueueDialogue(DialogueBase db)
    {

        if (inDialouge) return;
        inDialouge = true;


        dialogueBox.SetActive(true);
        dialogueInfo.Clear();

        OptionsParser(db);


        


        // Test um zu sehen ob ich von einem Dialog auf einen anderen springen kann

        /*db.transform.GetChild(0).gameObject.GetComponent<Text>().text = .optionsInfo[i].buttonName;
        UnityEventHandler myEventHandler = db.GetComponent<UnityEventHandler>();
        myEventHandler.eventHandler = dialogueOptions.optionsInfo[i].myEvent;

        if (db.dialogueInfo.nextDialogue != null)
        {
            myEventHandler.myDialogue = db.dialogueInfo.nextDialogue;
        }
        else
        {
            myEventHandler.myDialogue = null;
        }
    }

}
        else
{
    isDialogueOption = false;
}*/



foreach (DialogueBase.Info info in db.dialogueInfo)
        {
            dialogueInfo.Enqueue(info);
        }

        DequeueDialogue();

     }

    public void DequeueDialogue()
    {
        if (isCurrentlyTyping == true)
        {
            CompleteText();
            StopAllCoroutines();
            isCurrentlyTyping = false;
            return;
        }
        if (dialogueInfo.Count == 0 )
        {
            EndDialogue();
            return;
        }

    


        DialogueBase.Info info = dialogueInfo.Dequeue();
        completeText = info.myText;
        dialogueName.text = info.myName;
        dialogueText.text = info.myText;
        dialoguePortrait.sprite = info.portrait;

        dialogueText.text = "";
        StartCoroutine(TypeText(info));

    }

    IEnumerator TypeText(DialogueBase.Info info)
    {
        isCurrentlyTyping = true;
        foreach(char c in info.myText.ToCharArray())
        {
            yield return new WaitForSeconds(delay);
            dialogueText.text += c;
        }
        isCurrentlyTyping = false;
    }


    private void CompleteText()
    {
        dialogueText.text = completeText;
    }


    public void EndDialogue()
    {
        dialogueBox.SetActive(false);
        OptionsLogic();
    }
    private void OptionsLogic()
    {
        if (isDialogueOption == true)
        {
            dialogueOptionUI.SetActive(true);
            
        }
        else
        {
            inDialouge = false;
        }
    }

    public void CloseOptions()
    {
        dialogueOptionUI.SetActive(false);
    }


    private void OptionsParser(DialogueBase db)
    {
        if (db is DialogueOptions) // Test if Dialogue is a Option Dialogue
        {

            isDialogueOption = true;
            DialogueOptions dialogueOptions = db as DialogueOptions;
            optionsAmount = dialogueOptions.optionsInfo.Length;
            questionText.text = dialogueOptions.questionText;

            for (int i = 0; i < optionButtons.Length; i++)
            {
                optionButtons[i].SetActive(false);
            }

            for (int i = 0; i < optionsAmount; i++)
            {
                optionButtons[i].SetActive(true);
                optionButtons[i].transform.GetChild(0).gameObject.GetComponent<Text>().text = dialogueOptions.optionsInfo[i].buttonName;
                UnityEventHandler myEventHandler = optionButtons[i].GetComponent<UnityEventHandler>();
                myEventHandler.eventHandler = dialogueOptions.optionsInfo[i].myEvent;

                if (dialogueOptions.optionsInfo[i].nextDialogue != null)
                {
                    myEventHandler.myDialogue = dialogueOptions.optionsInfo[i].nextDialogue;
                }
                else
                {
                    myEventHandler.myDialogue = null;
                }
            }

        }
        else
        {
            isDialogueOption = false;
        }
    }
}
