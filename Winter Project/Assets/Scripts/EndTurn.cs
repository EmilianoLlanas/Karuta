using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public GameObject Card1,Card2,Card3,Card4,Card5,Card6,Card7,Card8,Card9,Card10,PlayerZone;
    public int cardsInHand;
    public GameObject gameControllerObject;

    List<GameObject> cards = new List<GameObject>();
   

    // Start is called before the first frame update
    void Start()
    {
         

        cards.Add(Card1);
        cards.Add(Card2);
        cards.Add(Card3);
        cards.Add(Card4);
        cards.Add(Card5);
        cards.Add(Card6);
        cards.Add(Card7);
        cards.Add(Card8);
        cards.Add(Card9);
        cards.Add(Card10);

        for (int i = 0; i < 3; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0,cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerZone.transform, false);
            
        }
        cardsInHand = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        gameControllerObject = GameObject.Find("Prota-Battle");
        GameController gameControlScript = gameControllerObject.GetComponent<GameController>();

        gameControlScript.EnemyTurn();

        drawCard();

    }
    public void drawCard()
    {

        if (cardsInHand < 6)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerZone.transform, false);
            cardsInHand += 1;
        }

    }


}
