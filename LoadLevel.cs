using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {
	private Vector3 gameAssetPos;
	// Use this for initialization
	void Start () {
		gameAssetPos = this.gameObject.transform.position;
		Instantiate(this.gameObject, new Vector3(gameAssetPos.x, gameAssetPos.y, gameAssetPos.z + 50), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onTriggerEnter(Collider Other){
		Application.LoadLevel (0);

	}
}
