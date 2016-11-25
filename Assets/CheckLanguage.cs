using UnityEngine;
using System.Collections;

public class CheckLanguage : MonoBehaviour
{

    public string language;

	// Use this for initialization
	void Start () {


        GameObject uiManager = GameObject.FindGameObjectWithTag("UIManager");
        if(!language.Equals(uiManager.GetComponent<UIManager>().language))
            this.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
