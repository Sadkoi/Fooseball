using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera_behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 7;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime,0);
    }
}
