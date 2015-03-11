using UnityEngine;
using System.Collections;

public class Tuerpoulets : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter (Collision Other) {
				if (Other.gameObject.tag == "Poulet") {
						Destroy (Other.gameObject);
				}
		}
}
