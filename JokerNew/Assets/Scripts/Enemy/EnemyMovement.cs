using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "Joker")
			Destroy(co.gameObject);
	}
}
