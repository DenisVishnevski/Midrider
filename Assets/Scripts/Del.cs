using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Del : MonoBehaviour
{
    

    




    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Del") Destroy(gameObject);
        
    }
    






}
