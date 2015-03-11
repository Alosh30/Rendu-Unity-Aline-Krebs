using UnityEngine;
using System.Collections;

public class tirer : MonoBehaviour {
	public Transform Sphereprefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 DirectionTir = Camera.main.transform.forward ;
						Transform Sphere = Instantiate (Sphereprefab,transform.position+DirectionTir,Quaternion.identity)as Transform;
			Sphere.rigidbody.AddForce(DirectionTir*5000);
				}
	}
}
