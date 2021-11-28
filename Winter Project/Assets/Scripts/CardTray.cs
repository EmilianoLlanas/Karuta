using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardTray : MonoBehaviour
{
    public GameObject mini1, mini2,cardTray;
    List<GameObject> cardsmini = new List<GameObject>();
       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addMini(int mini)
    {
        cardsmini.Add(mini1);
        cardsmini.Add(mini2);
        GameObject cardmini = Instantiate(cardsmini[mini], new Vector3(0, 0, 0), Quaternion.identity);
        cardmini.transform.SetParent(cardTray.transform, false);
    }
}
