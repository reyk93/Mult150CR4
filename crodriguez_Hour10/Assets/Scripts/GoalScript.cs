using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{

    private bool solved = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == tag)
        {
            solved = true;
            other.GetComponent<Rigidbody>().isKinematic = true;


        }
    
    }


    public bool IsSolved() 
    {
        return solved;

    }

}
