using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public string currentScene = "Nivel1";
    public string lastScene;
    private float delay = 4f;
    private float timeelapsed;


    void Update()
    {
        timeelapsed += Time.deltaTime;

        if(timeelapsed > delay)
        {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BattleVSFan"))
            {
                

                StartCoroutine(LoadLevel("SampleScene"));
            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BattleVSWone"))
            {


                StartCoroutine(LoadLevel("Nivel2"));
            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BattleVSSerp"))
            {


                StartCoroutine(LoadLevel("Nivel2"));
            }

            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("BattleVsVillan"))
            {


                StartCoroutine(LoadLevel("Nivel3"));
            }
        }
        
       
    }


    IEnumerator LoadLevel(string levelName)
    {
        //play animation
        transition.SetTrigger("Start");
        //wait
        yield return new WaitForSeconds(transitionTime);
        //load scene
        SceneManager.LoadScene(levelName);
    }
}
