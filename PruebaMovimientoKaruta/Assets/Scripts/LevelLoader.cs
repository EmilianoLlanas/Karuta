using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public Collision2D col;
    public string currentScene="Nivel1";
    public string lastScene;

    void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject.tag == "ColiderNivel2Pa")
        {
            StartCoroutine(LoadLevel("Nivel2"));
            GameVariables.lastLevel = 1;
            GameVariables.currentLevel = 2;
        }    

        if (col.gameObject.tag == "ColiderNivel1Pa")
        {
            StartCoroutine(LoadLevel("SampleScene"));
            GameVariables.lastLevel = 2;
            GameVariables.currentLevel = 1;
        }

        if(col.gameObject.tag == "ColiderNivel3Pa")
        {
            StartCoroutine(LoadLevel("Nivel3"));
            GameVariables.lastLevel = 2;
            GameVariables.currentLevel = 3;
        }

        if (col.gameObject.tag == "ColiderNivel3a2Pa")
        {
            StartCoroutine(LoadLevel("Nivel2"));
            GameVariables.lastLevel = 3;
            GameVariables.currentLevel = 2;
        }

        if (col.gameObject.tag == "Fantasma")
        {
            StartCoroutine(LoadLevel("BattleVSFan"));
            
        }

        if (col.gameObject.tag == "Wonejo")
        {
            StartCoroutine(LoadLevel("BattleVSWone"));
            

        }

        if (col.gameObject.tag == "Snake")
        {
            StartCoroutine(LoadLevel("BattleVSSerp"));

        }

        if (col.gameObject.tag == "Villian")
        {
            StartCoroutine(LoadLevel("BattleVsVillan"));

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
