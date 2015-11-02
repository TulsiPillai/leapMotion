using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadHands : MonoBehaviour {
	private GameObject handObject;
	// Use this for initialization
	void Start () {
		handObject = GameObject.Find ("HandController").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider Other)
	{
		print ("collided the hand trigger");
		handObject.GetComponent<HandController>().enabled = true;
	}
}
