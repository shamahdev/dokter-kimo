using UnityEngine;
using System.Collections;

public class ObjectMove : MonoBehaviour 
{
	private float speed;
	private void Start() {
		speed = Random.Range(1f,5f);
	}
	void FixedUpdate () {
		transform.position = new Vector3(transform.position.x , transform.position.y - speed, 0);
		if (transform.position.y <= -4.5f){
			if (gameObject.tag == "Food")
				GameObject.FindObjectOfType<GameCore>().PenaltyScore();
				Destroy(gameObject);
		}
	}
}
