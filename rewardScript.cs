using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class rewardScript : MonoBehaviour {
	
	private float maxY;
	private float minY;
	private int direction = 1;
	private int score = 0;
	public bool inPlay = true;
	private bool releaseCrate = false;
	private Text scoreCard;
	private GameObject reward;
	private Vector3 rewardPos;


	// Use this for initialization
	void Start () {

		maxY = this.transform.position.y + .5f;
		minY = maxY - 1.0f;
		scoreCard = GameObject.Find ("Score").GetComponent<Text> ();
		rewardPos = this.transform.position;
		try{
				Instantiate(this.gameObject, new Vector3(Random.Range(-6.0f,6.0f), rewardPos.y, rewardPos.z + 10), Quaternion.identity);
				print("created reward");		
		}
		catch(System.Exception ex){
			print(ex);
			}
	}
	
	// Update is called once per frame
	void Update () {
		
		this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y +(direction * 0.05f), this.transform.position.z);
		if (this.transform.position.y > maxY)
			direction = -1;
		if (this.transform.position.y < minY)
			direction = 1;		
		if (!inPlay && !releaseCrate)
			respawn ();
		score = int.Parse(scoreCard.text);
	}
	
	void OnTriggerEnter(Collider coll){
		
		if (coll.gameObject.tag == "Player") {		
			print("points!");
			inPlay = false;
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 30.0f + this.transform.position.z);
			score += 10;		
			scoreCard.text = score.ToString();
			//GameObject.Find("Main Camera").GetComponent<playSound>().PlaySound("power");			
		}		
		
	}
	
	void respawn(){
		
		releaseCrate = true;
		placeReward ();	
	}
	
	void placeReward(){
		
		inPlay = true;
		releaseCrate = false;		
		GameObject tmpTile = GameObject.Find("Player").gameObject;
		this.transform.position = new Vector3 (tmpTile.transform.position.x, this.transform.position.y, tmpTile.transform.position.z + 2.0f ); 
		maxY = this.transform.position.y + .5f;
		minY = maxY - 1.0f;
	}
	
	
	
	
	
	
	
	
	
	
	
}
