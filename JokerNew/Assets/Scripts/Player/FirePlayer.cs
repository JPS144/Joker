using UnityEngine;
using System.Collections;

public class FirePlayer : MonoBehaviour {
    // Bullet Prefab
    public GameObject bullet;
	public Animation BulletUp;
	public Animation BulletDown;


	
    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			// Spawn the Bullet
			bullet.transform.rotation = gameObject.transform.rotation;
			GameObject g = (GameObject)Instantiate (bullet, transform.position, Quaternion.identity);
			// Ignore Bullet<->Player collisions
			Physics2D.IgnoreCollision (g.GetComponent<Collider2D> (), transform.parent.GetComponent<Collider2D> ());
		}
	}
}
