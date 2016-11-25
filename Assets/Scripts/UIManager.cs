using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

    GameObject[] pauseObjects;
    public string language;


    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        
    }

    // Use this for initialization
    void Start()
    {
        language = "";
    }  
    
  /*  void OnLevelWasLoaded()
    {
        language = "";
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
    }*/

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(Time.timeScale==1)
                InputTrigger
        }

            //uses the p button to pause and unpause the game
            if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
                DialogueManager.Pause();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                hidePaused();
                DialogueManager.Unpause();
            }
        }*/
        if(SceneManager.GetActiveScene().buildIndex==1)
            if (language.Equals("jp"))
            {
                DialogueManager.SetLanguage("jp");
            }

    }


    //Reloads the Level
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }
    public void LoadLevelJp(int levelIndex)
    {
        language = "jp";
        SceneManager.LoadScene(levelIndex);
    }
    public void LoadLevelEn(int levelIndex)
    {
        language = "";
        SceneManager.LoadScene(levelIndex);
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
    


   /* //loads inputted level
    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
    }*/
}
