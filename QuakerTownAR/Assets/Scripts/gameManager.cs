using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {

	public bool debugMode;

	private bool infoWindowShow = false;
	private bool miniMapShow = false;

	private GameObject infoWin;
	private GameObject miniMap;

	// Use this for initialization
	void Awake () {
		infoWin = GameObject.FindGameObjectWithTag ("info");
		miniMap = GameObject.FindGameObjectWithTag ("miniMap");
	}
	
	// Update is called once per frame
	void Update () {
		infoToggler ();
		MiniMapToggler ();
	}

	void infoToggler () {
		if (infoWindowShow) {
			infoWin.SetActive (true);
		} else {
			infoWin.SetActive (false);
		}
		if (debugMode) {
			if (Input.GetKeyDown (KeyCode.I)) {
				infoWindowShow = !infoWindowShow;
			}
		}
	}

	void MiniMapToggler () {
		if (miniMapShow) {
			miniMap.SetActive (true);
		} else {
			miniMap.SetActive (false);
		}
		if (debugMode) {
			if (Input.GetKeyDown (KeyCode.L)) {
				miniMapShow = !miniMapShow;
			}
		}
	}

	public void ToggleInfoWindow () {
		infoWindowShow = !infoWindowShow;
	}

	public void ToggleMiniMap () {
		miniMapShow = !miniMapShow;
	}
}
