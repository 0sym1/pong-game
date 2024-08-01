using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4.2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)){
            OnMouseDrag();
        }
        boundPlayer();
    }

    private void OnMouseDrag(){
        Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        position.y = -4.2f;
        transform.rotation = Quaternion.Euler(0,0,0);
        transform.position = position;
    }

    private void boundPlayer(){
        if(Math.Abs(transform.position.x) > 1.58){
            if(transform.position.x > 0) transform.position = new Vector3(1.58f, -4.2f, 0);
            else transform.position = new Vector3(-1.58f, -4.2f, 0);
        }
    }
}
