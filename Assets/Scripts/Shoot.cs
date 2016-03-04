using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour 
{
	public GameObject bullet;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if (Input.GetButtonDown ("Fire1")) 
		if (Input.touchCount>0) 
		{
			GameObject cloned; 
			cloned = Instantiate (bullet, transform.position, transform.rotation) as GameObject;
			cloned.AddComponent<Projectile_cannon> ();

		}
	}
}
