using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCar : MonoBehaviour
{

    public float speed = 150f;
    void Update(){
        transform.Translate (new Vector3(0, 1, 0) * speed * Time.deltaTime);
    }
}
