using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MausklickErkennen : MonoBehaviour
{
    public Vector3 mausPos;
    public Camera mainCamera;
    public Vector3 mausPosWorld;
    RaycastHit2D hit;
    public Vector2 mausPosWorld2D;
    public GameObject Protagonist;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //mausklick erkannt?
       if(Input.GetMouseButtonDown(0))
        {
            print("klick erkannt");
            //Mausposition auslesen
            mausPos = Input.mousePosition;
            //Position auf konsole ausgeben
            print("Screenspace: " + mausPos);
            // Koordinaten von Screenspace nach Worldspache 
            mausPosWorld= mainCamera.ScreenToWorldPoint(mausPos);
            // worldspace koordinaten auf Unity ausgeben
            print("Worldspace : " + mausPosWorld);
            // Umwandlung von V3 in V2
            mausPosWorld2D = new Vector2(mausPosWorld.x, mausPosWorld.y);

            //Raycast2D ==> Hit abspeichern
            hit = Physics2D.Raycast(mausPosWorld2D, Vector2.zero);
            // Prüfung ob hit was gehittet hat
            if(hit.collider != null)
            {
                print("Objekt getroffen");
                print(hit.collider.gameObject.tag);
                // position des spielers verändern
                Protagonist.transform.position = hit.point;
            }
            else
            {
                print("kein collider erkannt");
            }

        }
    }
}
