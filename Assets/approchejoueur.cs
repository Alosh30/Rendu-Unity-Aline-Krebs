using UnityEngine;
using System.Collections;

public class approchejoueur : MonoBehaviour {


	NavMeshAgent nav;
	
	void Awake()
	{
		
		nav = GetComponent<NavMeshAgent> ();
		
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject Player = GameObject.FindGameObjectWithTag ("Player");
			nav.SetDestination(Player.transform.position);
	}
}
