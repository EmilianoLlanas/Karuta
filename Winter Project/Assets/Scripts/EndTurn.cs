using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTurn : MonoBehaviour
{
    public GameObject Card1,Card2,Mini1,PlayerZone,EnemyZone;
    public int cardsInHand,enemyCardsInHand;

    List<GameObject> cards = new List<GameObject>();
    List<GameObject> mini = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

        cards.Add(Card1);
        cards.Add(Card2);
        mini.Add(Mini1);

        for (int i = 0; i < 4; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0,cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(PlayerZone.transform, false);
            
        }
        cardsInHand = 4;

        for (int i = 0; i < 4; i++)
        {
            GameObject EnemyCard = Instantiate(mini[Random.Range(0,mini.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            EnemyCard.transform.SetParent(EnemyZone.transform, false);
            
        }
        enemyCardsInHand = 4;
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

        if (enemyCardsInHand < 6)
        {
            GameObject EnemyCard = Instantiate(mini[Random.Range(0, mini.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            EnemyCard.transform.SetParent(EnemyZone.transform, false);
            enemyCardsInHand += 1;
        }


    }


}
