using UnityEngine;
using System.Collections;

public class FlashLightControl : MonoBehaviour {

	public Light flashLightObj;

	// Use this for initialization
	void Start () {
		flashLightObj.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			if(flashLightObj.enabled == false){
				flashLightObj.enabled = true;
			}
			else{
				flashLightObj.enabled = false;
			}

		}
	}
}
