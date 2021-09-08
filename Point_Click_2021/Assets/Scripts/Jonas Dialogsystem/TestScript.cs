using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    
    public DialogueBase dialogue;


    public void TriggerDialogue()
    {
        DialogueManager.instance.EnqueueDialogue(dialogue);
     
    }

    
    
    /*public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            TriggerDialogue();
        }
    }*/

}
