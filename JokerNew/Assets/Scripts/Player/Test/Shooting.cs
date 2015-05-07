using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public GameObject ThePrefab;
	private float fireRate = .15f;
	private float nextFire = 0;
	private float bulletSpeed = 500f;
	
	void Update () {
		GameObject instance;
		
		//shoot up
		if (Input.GetKeyDown(KeyCode.W) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Debug.Log ("nf" + nextFire);
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.GetComponent<Rigidbody2D>().AddForce(transform.up * bulletSpeed);
		}
		
		//shoot left
		if (Input.GetKeyDown(KeyCode.A) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.transform.rotation = Quaternion.AngleAxis(0, -Vector2.right);
			instance.GetComponent<Rigidbody2D>().AddForce(-transform.right * -bulletSpeed);
		}
		
		//shoot down
		if (Input.GetKeyDown(KeyCode.S) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.transform.rotation = Quaternion.AngleAxis(0, -Vector2.up);
			instance.GetComponent<Rigidbody2D>().AddForce(-transform.up * -bulletSpeed);
		}
		
		//shoot right
		if (Input.GetKeyDown(KeyCode.D) && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			instance = Instantiate(ThePrefab, transform.position, transform.rotation) as GameObject;
			instance.transform.rotation = Quaternion.AngleAxis(0, Vector2.right);
			instance.GetComponent<Rigidbody2D>().AddForce(transform.right * bulletSpeed);
		}
	}
}
