using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	public GameObject gameCore;
    private void Update(){
        if(Time.timeScale == 1){
            if (Input.GetMouseButton(0)){
                Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y,0);
                Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
                
                RaycastHit2D hit = Physics2D.Raycast (Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if(hit.collider == null){
                    Move(curPosition.x);
                }
            }
        }
    }

    void Move(float posX){
		transform.position = new Vector3(posX, transform.position.y, 0);
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.tag == "Food"){
			gameCore.GetComponent<GameCore>().increaseScore();
		}
		else if (col.tag == "Finish"){
			gameCore.GetComponent<GameCore>().PenaltyScore();
		}
		Destroy(col.gameObject);
	}
}
