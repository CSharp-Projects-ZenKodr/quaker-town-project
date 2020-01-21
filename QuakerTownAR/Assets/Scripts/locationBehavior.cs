using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class locationBehavior : MonoBehaviour {

	public ScriptLoc thisLocation;

	public GameObject popInObj;

	private GameObject informationMenu;

	private Text nameText;
	private Text dateText;
	private Text descrText;
	private Text locName;

	private bool popIn = false;

	void Awake () {
		informationMenu = GameObject.FindGameObjectWithTag ("info");
		nameText = informationMenu.transform.GetChild (0).GetComponent <Text> ();
		dateText = informationMenu.transform.GetChild (1).GetComponent <Text> ();
		descrText = informationMenu.transform.GetChild (2).GetComponent <Text> ();
		locName = GameObject.FindGameObjectWithTag("locName").GetComponent <Text>();
	}
	

	void Update () {
		PopItIn ();
	}

	void PopItIn () {
		if (popIn) {
			popInObj.SetActive (true);
		} else {
			popInObj.SetActive (false);
		}
	}

	void OnTriggerStay (Collider other) {
		if (other.tag == "Player") {
			nameText.text = "Name: " + thisLocation.locName;
			dateText.text = "Date Founded: \n" + thisLocation.dateFounded;
			descrText.text = "About: " + thisLocation.description;
			locName.text = thisLocation.locName;
			popIn = true;
		}
	}

	void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			nameText.text = "Name:";
			dateText.text = "Date Founded:";
			descrText.text = "About:";
			locName.text = "";
			popIn = false;
		}
	}
}
