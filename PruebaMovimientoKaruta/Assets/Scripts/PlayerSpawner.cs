using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Aqui define tus vectores donde quieres que spawne
        Vector3 startPos = new Vector3(-5,-3,0); 
        Vector3 oneToTwoPos = new Vector3(-7,0,0);
        Vector3 twoToOnePos = new Vector3 (7,0,0);
        Vector3 threeToTwoPos = new Vector3(0,-3,0);
        Vector3 twoToThreePos = new Vector3(0,3,0);


        GameObject player = GameObject.FindGameObjectWithTag("Player");

        int last = GameVariables.lastLevel;
        int curr = GameVariables.currentLevel;

        if (curr == 1)
        {
            if (last == 0)
            {
                player.transform.position = startPos;
            }
            else
            {
                player.transform.position = twoToOnePos;
            }
        }
        else
        {
            if (curr == 2)
            {
                if (last == 1)
                {
                    player.transform.position = oneToTwoPos;
                }
                else
                {
                    player.transform.position = threeToTwoPos;
                }
            }
            else
            {
               
                player.transform.position = twoToThreePos;
                
                
                if(last == 3)
                {
                    player.transform.position = threeToTwoPos;
                }
            }
        }
    }
}
