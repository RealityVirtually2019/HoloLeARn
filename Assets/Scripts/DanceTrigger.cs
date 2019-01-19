using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceTrigger : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Dance");
        }
    }
}
