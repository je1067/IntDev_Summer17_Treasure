
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsObjectClose : MonoBehaviour {

    public GameObject player;
    public GameObject landmark;
    public GameObject landmarkColl;
    public GameObject hintText;

	
	void Start () {
        hintText.SetActive(false);
	}
	
	
	void Update () {
      
    }
    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("Landmark detected");
            hintText.SetActive(true);
            
        }
    }
     void OnTriggerExit(Collider other)
    {
        Debug.Log("Landmark abandoned");
        hintText.SetActive(false);
    }
}
