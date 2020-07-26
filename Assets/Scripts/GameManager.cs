using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject[] objects;
	public float speed;
	private float lastCreated;

	void Start () {
		lastCreated = 0;
		lastCreated = Time.time;
		Invoke("CreateObjects", 0.5f);
	}

	void CreateObjects(){
		float distanceFromCamera = Camera.main.nearClipPlane ; // Change this value if you want
		Vector3 topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0.1f, 1, distanceFromCamera));
		Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(0.9f, 1, distanceFromCamera));
		Vector3 spawnPoint = Vector3.Lerp( topLeft, topRight, Random.value);
		Instantiate(objects[Random.Range(0,objects.Length)], spawnPoint, Quaternion.identity, GameObject.FindWithTag("GUI").transform);
		Invoke("CreateObjects", Random.Range(1f,3f));
	}
}
