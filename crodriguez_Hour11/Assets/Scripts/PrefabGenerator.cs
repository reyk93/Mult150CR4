using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    public GameObject prefab;
    
    int prefabCount = 1; // these int create the 10 street lamps in the scene //
    int sum = 0;

    /*public Vector3 spawnRange;*/

    public float spacingOfPrefab =3f;
    public Vector3 startPoint = Vector3.zero;  // this is the start position where the lamps will appear first//
    public Vector3 lineDirection = Vector3.right; // it will make the lamps spand in the x axis to the right//

    



    // Start is called before the first frame update
    void Start()
    {
        

        while (prefabCount <= 10)   // this is reading the int information and creating the 10 prefabs//
        {
            sum += prefabCount;
            prefabCount++;

            // Vector3 spawnPositionA = new Vector3(Random.Range(-spawnRange.x,spawnRange.x), 0f,-6f);    this works with the  public Vector3 spawnRange above//

            Vector3 spawnPositionA = startPoint + (lineDirection.normalized * spacingOfPrefab * prefabCount);  // normalized makes sure the vecotr has a magnitude of 1 so spacingOfPrefab work and trnaslate to distance//
            Instantiate(prefab,spawnPositionA , transform.rotation);

            


        }

       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)) 
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }




}
