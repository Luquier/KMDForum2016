using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class PauseMenu : MonoBehaviour {


    GameObject[] pauseObjects;
    GameObject[] blockObjects;

    // Use this for initialization
    void Start () {

        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();

    }
	
	// Update is called once per frame
	void Update () {
	
	}


    //controls the pausing of the scene
    public void pauseControl()
    {
        if (blockObjects == null)
        {
            blockObjects = GameObject.FindGameObjectsWithTag("DisableOnPause");
        }
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
            DialogueManager.Pause();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
            DialogueManager.Unpause();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
        foreach (GameObject g in blockObjects)
        {
            g.SetActive(false);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
        foreach (GameObject g in blockObjects)
        {
            g.SetActive(true);
        }
    }



}
