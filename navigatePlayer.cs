using UnityEngine;
using System.Collections;

public class NavigateCube : MonoBehaviour {
	public GameObject hand;
	private Vector3 trans;
	private Vector3 pos;
	// Use this for initialization
	void Start () {

		//trans = this.transform.position;
		trans = this.transform.position;
		pos = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		pos = this.gameObject.transform.position;
		//print ("player position" + pos);
		//print (trans);
		try{
			hand = GameObject.Find ("RigidRoundHand(Clone)").transform.FindChild ("palm").gameObject;
			trans = hand.transform.position;	
			gameObject.transform.position = new Vector3(trans.x,pos.y,pos.z);
			//print(cphi);
		}
		catch (System.Exception ex){
			//print(ex);
		}

	}
}
	
