using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlItem : MonoBehaviour {

    public GameObject mycamera;
   
    // Use this for initialization
    void Start () {
        mycamera = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.z<mycamera.transform.position.z)
        {
            Destroy(this.gameObject);
        }

    }
}
