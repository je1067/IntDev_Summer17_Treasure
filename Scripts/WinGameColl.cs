using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGameColl : MonoBehaviour {

    public GameObject player;
    public GameObject winText;
    public GameObject hintText;
    public bool CanWin;
    public bool DidWin;
	
	void Start () {
        winText.SetActive(false);
        hintText.SetActive(false);
        CanWin = false;
	}
	
	
	void Update () {
        if ((CanWin == true) && (Input.GetKey(KeyCode.Space)))
            {
            winText.SetActive(true);
            hintText.SetActive(false);
            DidWin = true;
        }
        if (DidWin == true)
        {
            hintText.SetActive(false);
        }

	}
    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Landmark detected");
            hintText.SetActive(true);
            CanWin = true;

        }
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Landmark abandoned");
        hintText.SetActive(false);
        CanWin = false;
    }
}
