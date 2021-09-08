using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// Speichert Daten nicht im Gameobject
[CreateAssetMenu(fileName = "New Dialogue", menuName = "Dialogues")]
public class DialogueBase : ScriptableObject {


    [System.Serializable]

    public class Info
    {
        public string myName;
        [TextArea(4, 8)]
        public string myText;
        public Sprite portrait;
        


    }

    [Header("Füge die Dialog Infos unten ein")]
    public Info[] dialogueInfo;
    

}




    






