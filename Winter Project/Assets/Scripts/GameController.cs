using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public int PlayerHealth=8000;
    public int EnemyHealth=16000;
    public int EnemyDamage = 500;

    public Text PlayerHealthText;
    public Text EnemyHealthText;
    public TextMeshProUGUI Notifications;
    

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

    public void EnemyTurn()
    {
        Notifications.text = "Enemy Damage: "+EnemyDamage.ToString();
        PlayerHealth -= EnemyDamage;
        EnemyDamage += 500;
    }


    public void playCard(string cardTag)
    {
        EndTurnObject = GameObject.Find("EndTurn-Button");
        EndTurn turnScript = EndTurnObject.GetComponent<EndTurn>();

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
            case "Card4":
                EnemyHealth -= 3000;
                PlayerHealth -= 1500;
                break;

            case "Card5":
                PlayerHealth += 1000;
                break;

            case "Card6":
                PlayerHealth += 2000;
                break;

            case "Card7":
                
                turnScript.drawCard();
                turnScript.drawCard();
                break;

            case "Card8":
                turnScript.drawCard();
                turnScript.drawCard();
                turnScript.drawCard();
                break;

            case "Card9":
                EnemyHealth -= 1000;
                PlayerHealth += 1000;
                break;

            case "Card10":
                EnemyHealth -= 2000;
                PlayerHealth += 2000;
                break;

            default:
                Debug.Log("Not a Valid Card");
                break;
        }
    }



}
