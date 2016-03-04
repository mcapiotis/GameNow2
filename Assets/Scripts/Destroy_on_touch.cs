using UnityEngine;
using System.Collections;

public class Destroy_on_touch : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	public GameObject bullet;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetButtonDown ("Fire1")) 
		if (Input.touchCount>0 && Input.GetTouch (0).phase == TouchPhase.Began) 
		{
			ray = Camera.main.ScreenPointToRay (Input.GetTouch (0).position);
			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {
				Debug.Log (hit.collider.tag);
				if (hit.collider.tag == "Enemy") {
					Debug.Log (hit.collider);
					Destroy (hit.transform.gameObject);
					GameObject cloned; 
					cloned = Instantiate (bullet, hit.transform.position, hit.transform.rotation) as GameObject;
					cloned.AddComponent<Projectile_cannon> ();
				}
			}

		}
	}
}
