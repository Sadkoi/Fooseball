using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball_behaviour : MonoBehaviour
{
    public Rigidbody Ball;
    //score count
    float blue_score = 0;
    float red_score = 0;

    // start position of ball
    Vector3 startPos = new Vector3(0.132f,0.3404f,1.492f);

    public Text redScore;
    public Text blueScore;

    // Start is called before the first frame update
    void Start()
    {
        Ball = GetComponent<Rigidbody>();
        redScore.text = "RED: " + red_score.ToString();
        blueScore.text = "BLUE: " + blue_score.ToString();
    }

    // Update is called once per frame

    
    bool oneTime = false;
    void Update()
    {
        if(oneTime == false){
            if(keepScore() == true){
                oneTime = true;
            }
        }else{
            if(oneTime == true){
                transform.position = startPos;
                Ball.velocity = new Vector3(0,0,0);
                oneTime = false;
            }
        }
    }

    // returns true if ball state (ball position.x changes)
    bool keepScore(){
        if(transform.position.z < 0.5){
            red_score = red_score + 1;
            textScore();
            return true;
        }else{
            if(transform.position.z > 2.5){
            blue_score = blue_score + 1;
            textScore();
            return true;
            }else{
                return false;
            }
        }
       
    }

    void textScore(){
        redScore.text = "RED : " + red_score.ToString();
        blueScore.text = "BLUE : " + blue_score.ToString();
    }

}
// Moinak Das 10.19.19