using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbulanceController : MonoBehaviour
{

    public GameObject gameCore;
    public float speed;
    private Vector3 position;

    private void Start(){
        position = transform.position;
    }
    void Update(){
        if(Time.timeScale == 1){
            if (Input.GetMouseButton(0)){
                Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y,0);
                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
                
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if(hit.collider == null)
                {
                    curPosition.x = Mathf.Clamp(curPosition.x, -144 ,144);
                    Move(curPosition.x);
                }
            }
        }
    }

    void Move(float posX){
		if (transform.position.x > posX){
			transform.position = new Vector3(transform.position.x - 5f, transform.position.y, 0);
		}
		else if (transform.position.x < posX){
			transform.position = new Vector3(transform.position.x + 5f, transform.position.y, 0);
		}
	}

    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "car"){
            gameCore.GetComponent<GameCore>().PenaltyScore();            
        }
    }
}
