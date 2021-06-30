using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
     public float spinSpeed;
    public Animation spinAnim;
    void OnTriggerExit(Collider col)
    {

        if (col.tag == "Player1") Destroy(gameObject);


    }

    private void FixedUpdate()
    {
        // transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
        

    }
}