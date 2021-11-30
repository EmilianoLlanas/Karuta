
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;
    private bool isOverDropZone;
    private GameObject dropZone;
    public GameObject[] cardOrderTray;
    private Vector2 startPosition;
    public GameObject EndTurnObject;
    public GameObject gameControllerObject;

    // Start is called before the first frame update
    void Start()
    {
        EndTurnObject = GameObject.Find("EndTurn-Button");
        EndTurn turnScript = EndTurnObject.GetComponent<EndTurn>();
        //cardOrderTray = GameObject.FindGameObjectsWithTag("CardOrderTray");
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void startDrag()
    {
        startPosition = transform.position;
        isDragging = true;
    }

    public void endDrag()
    {

        isDragging = false;
        if(isOverDropZone)
        {
            // transform.SetParent(cardOrderTray.transform, false);
            //Debug.Log(gameObject.tag);
            Destroy(this.gameObject);

            EndTurnObject = GameObject.Find("EndTurn-Button");
            EndTurn turnScript = EndTurnObject.GetComponent<EndTurn>();

            gameControllerObject = GameObject.Find("Prota-Battle");
            GameController gameControlScript = gameControllerObject.GetComponent<GameController>();

            turnScript.cardsInHand--;
            gameControlScript.playCard(gameObject.tag);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
