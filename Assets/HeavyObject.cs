using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyObject : MonoBehaviour
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
       
        if(other.gameObject.tag == "Player" & other.transform.localScale.y > 2f & Input.GetButton ("Fire1")){
            Debug.Log("F PRessed");
           transform.position = other.transform.position + new Vector3 (4f, 5f, 0);
        };
        
    }
}
