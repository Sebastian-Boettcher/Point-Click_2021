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

    //TEST VERLINKUNG ZU DIALOGSYSTEM
    public TestScript DialogWirtin;
    public TestScript DialogAnton;
    public TestScript DialogGilli;
    public TestScript DialogElb;
    public TestScript DialogDieb;
    public TestScript DialogDiebbossAnfang;
    public TestScript DialogTuersteher;
    public TestScript DialogSchlaeger;
    public TestScript DialogKoch;
    public TestScript DialogSchlaegerDanach;
    public TestScript DialogHeiler;
    public TestScript DialogWache;
    public TestScript DialogBarde;
    public TestScript DialogTür;
    public TestScript DialogSixNine;
    public TestScript DialogSchmied;
    public TestScript DialogNichtWeiterL;
    public TestScript DialogNichtWeiterR;
    public TestScript DialogNichtVorbei;
    public TestScript DialogOfen;
    public TestScript DialogTopf;
    public TestScript DialogTruhe;
    public TestScript DialogPilze;


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

    void PauseGame()
    {
        Time.timeScale = 0.1f;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
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
            if (hit.collider != null)
            {
                //print("Objekt mit Collider getroffen!");
                //Name des getroffenen objekts ausgeben
                print("Name:" + hit.collider.gameObject.tag);

                //Abfrage ob es der Boden ist
                if (hit.collider.gameObject.tag == "ground")
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

                else if (hit.collider.gameObject.tag == "Gabel")
                {
                    // Grafik deaktivieren
                    hit.collider.gameObject.SetActive(false);

                    Items = Items + 1;
                }
                else if (hit.collider.gameObject.tag == "faden")
                {
                    Debug.Log("Das ist der Faden");
                    hit.collider.gameObject.SetActive(false);
                    Items = Items + 1;
                    inventory.AddItem(new Item { itemType = Item.ItemType.Faden, amount = 1 });
                }
                else if (hit.collider.gameObject.tag == "Wirtin")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogWirtin.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Anton")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogAnton.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Gilli")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogGilli.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Elb")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogElb.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Dieb")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogDieb.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "DiebbossAnfang")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogDiebbossAnfang.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Tuersteher")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogTuersteher.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Schlaeger")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogSchlaeger.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Koch")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogKoch.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "SchlaegerDanach")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogSchlaegerDanach.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Heiler")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogHeiler.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Wache")
                {

                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogWache.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Tür")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogTür.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Barde")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogBarde.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Sixnine")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogSixNine.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Schmied")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogSchmied.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "NichtWeiterL")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogNichtWeiterL.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "NichtWeiterR")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogNichtWeiterR.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "NichtVorbei")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogNichtVorbei.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Ofen")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogOfen.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Topf")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogTopf.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Truhe")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogTruhe.TriggerDialogue();
                    }
                }
                else if (hit.collider.gameObject.tag == "Pilze")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        DialogPilze.TriggerDialogue();
                    }
                }


                else
                {
                    print("Kein Collider erkannt");
                }
            }
        }

    }



    private void FixedUpdate()
    {
        if (isMoving)
        {
            // Spieler an Zielort bewegen ohne Teleport
            player.transform.position = Vector3.MoveTowards(player.transform.position, targetPos, speed);

            if (player.transform.position.z <= 0)
            {
                player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, 2);
            }
            //print("Spieler wird bewegt");

            // ist spieler am zielort
            if (player.transform.position.x == targetPos.x && player.transform.position.y == targetPos.y)
            {
                isMoving = false;
                print("Spieler am Ziel");
            }
        }

    }

    void CheckSpriteFlip()
    {
        if (player.transform.position.x > targetPos.x)
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


