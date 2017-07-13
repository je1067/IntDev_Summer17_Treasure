using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour {

    CharacterController cc;
    public float MoveSpeed = 0.1f;

	void Start () {
        cc = GetComponent<CharacterController>();
	}
	
	
	void Update () {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        cc.Move(new Vector3(horizontal, 0f, vertical) * 0.5f * MoveSpeed);
    }
}
