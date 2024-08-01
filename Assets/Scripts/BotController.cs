using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject ball;
    void Start(){

    }
    void Update(){
        if(transform.position.x > ball.transform.position.x){
            transform.position += Vector3.left*speed;
        }
        else if(transform.position.x < ball.transform.position.x){
            transform.position += Vector3.right*speed;
        }
        boundPlayer();
        transform.position = new Vector2(transform.position.x, 4.2f);
        transform.rotation = Quaternion.Euler(0,0,0);
    }

    private void boundPlayer(){
        if(Math.Abs(transform.position.x) > 1.58){
            if(transform.position.x > 0) transform.position = new Vector3(1.58f, -4.2f, 0);
            else transform.position = new Vector3(-1.58f, -4.2f, 0);
        }
    }
}
