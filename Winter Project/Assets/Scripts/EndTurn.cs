using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public GameObject Card1,Card2,PlayerZone;
    public int cardsInHand;

    List<GameObject> cards = new List<GameObject>();
    List<GameObject> mini = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

        cards.Add(Card1);
        cards.Add(Card2);

        for (int i = 0; i < 4; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0,cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerZone.transform, false);
            
        }
        cardsInHand = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        if (cardsInHand < 6)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerZone.transform, false);
            cardsInHand += 1;
        }


    }


}
