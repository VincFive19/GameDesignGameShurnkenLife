using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
    //     // public gameObject: GameObject
        
        
    // }

    
        public float moveSpeed = 2f;
        public float jump = 10f;

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * jump;

        transform.Translate(h,v,0);
        
        

        // if (Input.GetKeyDown("left"))
        // {
            
        // }
        // if (Input.GetKeyDown("up"))
        // {
            
        // }
        // if (Input.GetKeyDown("down"))
        // {
            
        // }
    }
}
