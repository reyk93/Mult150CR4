using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour
{

    public float max = 50;


    // Start is called before the first frame update
    void Start() => GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(0, max), 0, Random.Range(0, max));  // this a updated version of the previous rigid.velocity method 

    // Update is called once per frame
    void Update()
    {
        
    }


}
