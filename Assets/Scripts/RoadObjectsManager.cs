using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadObjectsManager : MonoBehaviour
{

    private Move move;
    private GameObject Bike;


    private void Start()
    {
        Bike = GameObject.Find("defaultt");
        move = Bike.GetComponent<Move>();
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Del") Destroy(gameObject);
        if (col.gameObject.name == "LeftCollider")
        {
            move.Right();
        }
        if (col.gameObject.name == "RightCollider")
        {
            move.Left();
        }
    }

}