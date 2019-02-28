using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {
	private int _health;

	// Use this for initialization
	void Start () {
		_health = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Hurt (int damage) {
		_health -= damage;
		Debug.Log ("Health: " + _health);
		if (_health <= 0) {
			StartCoroutine (Die ());
		}
	}

	private IEnumerator Die() {
		this.transform.Rotate (-75, 0, 0);

		yield return new WaitForSeconds (1.5f);

		Destroy (this.gameObject);
	}

}
