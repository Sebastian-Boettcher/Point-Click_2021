using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MausklickErkennen : MonoBehaviour
{
    public Vector2 mousePos;
    public Camera mainCamera;
    public Vector2 mousePosWorld;
    RaycastHit2D hit;
    public Vector2 mousePosWorld2D;
    public GameObject player;
    public Vector2 targetPos;
    public float speed;
    public bool isMoving;
    Vector2 currentPos;

    public int Items = 0;
    [SerializeField] private UI_Inventory uiInventory;  
    private Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

  private void Awake() {
      inventory = new Inventory();   
      uiInventory.SetInventory(inventory);
  }

    // Update is called once per frame
    void Update()
    {
        // Wurde Maustaste ger�ckt?
        if (Input.GetMouseButtonDown(0))
        {
            //Mausklick wurde erkannt
            print("Mausklick erkannt");

            //Position der Maus auslesen
            mousePos = Input.mousePosition;
            // Mauspositin ausgeben
           // print("screenspace" + mousePos);

            //von Screenspace auf Worldspace
            mousePosWorld = mainCamera.ScreenToWorldPoint(mousePos);
            // Worldspace Koordinaten ausgeben
           // print("worldspace" + mousePosWorld);

            //Umwandlung von Vektor3 in Vektor2
            mousePosWorld2D = new Vector2(mousePosWorld.x, mousePosWorld.y);

            //Raycast abspichern
            hit = Physics2D.Raycast(mousePosWorld2D, Vector2.zero);

            //�berpr�fing ob hit einen Collider getroffen hat
            if(hit.collider != null)
            {
                //print("Objekt mit Collider getroffen!");
                //Name des getroffenen objekts ausgeben
                print("Name:" +hit.collider.gameObject.tag);

                //Abfrage ob es der Boden ist
                if(hit.collider.gameObject.tag == "ground")
                {
                    //Position des Spielers ver�ndern
                    // player.transform.position = hit.point;
                    targetPos = hit.point;
                    currentPos = targetPos;
                    // isMoving auf true setzen
                    isMoving = true;
                    // �berpr�fe on Spriteflip notwendig
                    CheckSpriteFlip();
                }

                else if(hit.collider.gameObject.tag == "Gabel")
                {
                    // Grafik deaktivieren
                    hit.collider.gameObject.SetActive(false);
                   
                    Items = Items + 1;
                }
                else if(hit.collider.gameObject.tag == "Wirtin")
                {
                }
                else if(hit.collider.gameObject.tag == "faden"){
                    Debug.Log("Das ist der Faden");
                    hit.collider.gameObject.SetActive(false);
                    Items = Items + 1;
                    inventory.AddItem(new Item{itemType = Item.ItemType.Faden, amount = 1});
                }
            }

            else
            {
                print("Kein Collider erkannt");
            }
        }
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            // Spieler an Zielort bewegen ohne Teleport
            player.transform.position = Vector3.MoveTowards(player.transform.position, targetPos, speed);
            
            if(player.transform.position.z <= 0){
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 2);
            }
            //print("Spieler wird bewegt");

            // ist spieler am zielort
            if(player.transform.position.x == targetPos.x && player.transform.position.y == targetPos.y)
            {
                isMoving = false;
                print("Spieler am Ziel");
            }
        }
        
    }

    void CheckSpriteFlip()
    {
        if(player.transform.position.x > targetPos.x)
        {
            //Nach links blicken
            player.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            //Nach rechts blicken
            player.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}


