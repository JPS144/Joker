using UnityEngine;
using System.Collections;

public class ElementZero : MonoBehaviour {
	
	public int pointToAdd;
	public int eezoToAdd;

    void OnTriggerEnter2D(Collider2D co) {
		if (co.name == "Joker")
		
		PlayerScore.AddPoints (pointToAdd);
		EezoScore.AddPoints (eezoToAdd);
            
		Destroy(gameObject);

    }	
}

