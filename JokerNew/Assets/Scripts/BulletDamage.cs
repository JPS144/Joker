using UnityEngine;
using System.Collections;

public class BulletDamage : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll) {
        // Collided with a Ship? Then destroy it.
        if (coll.gameObject.tag == "Ship")
            Destroy(coll.gameObject);

        // Destroy Bullet in any case
        Destroy(gameObject);
    }
}
