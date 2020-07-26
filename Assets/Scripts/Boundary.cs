using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

    BoxCollider2D boundareCollider;

    private void Start(){
        boundareCollider = GetComponent<BoxCollider2D>();
        ResizeCollider();
    }
    void ResizeCollider() {        
        Vector2 viewportSize = Camera.main.ViewportToWorldPoint(new Vector2(1, 1)) * 2;
        viewportSize.x *= 1.5f;
        viewportSize.y *= 1.5f;
        boundareCollider.size = viewportSize;
    }
    private void OnTriggerExit2D(Collider2D collision) {        
        if (collision.tag == "Projectile"){
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Bonus"){
            Destroy(collision.gameObject);
        } 
    }

}
