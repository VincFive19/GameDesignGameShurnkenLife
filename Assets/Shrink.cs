using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        void OnTriggerStay(Collider other)
    {
       
        if(other.gameObject.tag == "Player" & other.transform.localScale.y > 0.25f){
           other.transform.localScale += new Vector3(-0.01f, -0.01f, -0.01f);
        };
        
    }
}
