using UnityEngine;
using System.Collections;

public class countCollider : MonoBehaviour {
	public static int COUNTER = 0;
	public static int destroyTime = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player") {
			COUNTER++;
			print (COUNTER);
		}
	}
	void OnCollisionExit(Collision col){//OnTriggerEnter OnTriggerStay OnTiggerExit
		if(col.gameObject.tag=="Player"){
			if (COUNTER == destroyTime) {
				Destroy (gameObject);
				print ("destroy");
			}
		}
	}
}
