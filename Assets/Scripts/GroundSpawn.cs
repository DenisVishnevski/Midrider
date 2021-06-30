using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public Transform generation;
    public GameObject plane;
    public GameObject del;
    

    void Update()
    {

       


        if (transform.position.x < generation.position.x)
        {



            transform.position = new Vector3(generation.position.x + 220f, transform.position.y + 0.0001f, transform.position.z);

            Instantiate(plane, transform.position, transform.rotation);

            if (plane.transform.position.x < del.transform.position.x)
            {
                
            }
        }
    }
}