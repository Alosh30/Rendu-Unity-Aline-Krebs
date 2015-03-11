using UnityEngine;
using System.Collections;

public class RespawnWater : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
						other.transform.position = new Vector3 (50, 16, 60);
				}
	}
}
