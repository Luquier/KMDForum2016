using UnityEngine;
using System.Collections;
using HutongGames.PlayMaker.Actions;

public class DisableTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    this.gameObject.GetComponent<GUIButton>().Enabled = false;

	}
}
