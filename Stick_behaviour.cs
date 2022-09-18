using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Stick_behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 75;
    // Update is called once per frame
    void Update(){
    
        // Transform rotate:: x in range 
        if (Input.GetKey(KeyCode.J)){
            transform.Rotate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }else{
            if (Input.GetKey(KeyCode.L)){
            transform.Rotate(-Vector3.right * speed * Time.deltaTime);
            }else{
                    if(Math.Abs(transform.rotation.x) < 0.72){
                        transform.Rotate(-Vector3.right * speed * Time.deltaTime);
                    }
                    if(Math.Abs(transform.rotation.x) > 0.70){
                        transform.Rotate(Vector3.right * speed * Time.deltaTime, Space.Self);
                    }
                }
            }
                    
        // Transform left & Right::  x in range 0.27
        if (Input.GetKey(KeyCode.I)){
            if (transform.position.x < 0.26){
                transform.Translate(Vector3.right * (Time.deltaTime/4));
            }
            
        }
        
        if (Input.GetKey(KeyCode.K)){
            if (transform.position.x > 0.01){
                transform.Translate(-Vector3.right * (Time.deltaTime/4));
            }
            
        }

        //print(Math.Abs(transform.rotation.x));

    }

}
