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

    
    // Start is called before the first frame update
    void Start()
    {
       PlayerHealthText.text = PlayerHealth.ToString();
       EnemyHealthText.text = EnemyHealth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
