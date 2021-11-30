using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public int PlayerHealth=8000;
    public int EnemyHealth=16000;


    public Text PlayerHealthText;
    public Text EnemyHealthText;

    public GameObject EndTurnObject;
    
    // Start is called before the first frame update
    void Start()
    {
        EndTurnObject = GameObject.Find("EndTurn-Button");
        EndTurn turnScript = EndTurnObject.GetComponent<EndTurn>();
       PlayerHealthText.text = PlayerHealth.ToString();
       EnemyHealthText.text = EnemyHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerHealthText.text = PlayerHealth.ToString();
        EnemyHealthText.text = EnemyHealth.ToString();
    }

    public void playCard(string cardTag)
    {
        switch (cardTag)
        {

            case "Card1":
                EnemyHealth -= 1000;
                break;

            case "Card2":
                PlayerHealth -= 500;
                EnemyHealth -= 2000;
                break;

            case "Card3":
                EnemyHealth -= 1500;
                break;

            default:
                Debug.Log("Not a Valid Card");
                break;
        }
    }



}
