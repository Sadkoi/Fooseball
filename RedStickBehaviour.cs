using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RedStickBehaviour : MonoBehaviour{
    
    public float objY;
    // Start is called before the first frame update
    void Start()
    {
        objY = transform.position.y;
    }

    public float startPosX;
    public float startPosY;
    public float currentY;
    public float currentX;
    public float scale = 0.1f; //determine how fast the object moves
    public float deltaX;
    public float deltaY;
    // Update is called once per frame
    void Update(){
        changePosTouch();
    } // End of Update

    void changePosTouch(){
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.position.x < (Screen.width / 2)){
                if(touch.phase == TouchPhase.Began){
                        startPosX = touch.position.x;
                        startPosY = touch.position.y;
                }else{
                    if(touch.phase == TouchPhase.Moved){

                        currentX = touch.position.x;
                        currentY = touch.position.y; // used for side to side movement of sticks
                        deltaX = ((currentY - startPosY)*scale);
                        deltaY = currentX - startPosX;

                        //Lateral movement function
                        if(transform.position.x > -6 && transform.position.x < 120){
                            transform.position = new Vector3(deltaX,transform.position.y,transform.position.z);
                        }else{
                            if(deltaX < 120 && deltaX > -6){
                                transform.position = new Vector3(deltaX,transform.position.y, transform.position.z);
                            }
                        }

                        //Rotational movement function
                        print(deltaY*0.01f);
                        print("x angle " + transform.eulerAngles.x);

                        transform.Rotate(deltaY*0.1f,0f,0f, Space.Self);

                    }
                } // end of if statement

            }
            

            //debug ***************************************************************************************************************
            //print("transform.position.y = " + transform.position.y);
            //print(" objY = " + objY);
            //print("touch pos " + touch.position + ", screen " + (Screen.width / 2));
            //print(touch.position.y);
            //print("transform " + transform.position.x + " deltaX " + deltaX);
        }
    } // End of changePosTouch
    // -9 , 126


} // end of class
