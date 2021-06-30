using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightBack : MonoBehaviour
{


    public Transform generation;
    public GameObject house;
    public GameObject zZ;




    bool is_Back = false;




    void Update()
    {
        int randIn = Random.Range(1, 3);
        float raddOut = 0;
        float randX = Random.Range(30f, 100f);
        float posZ = 0;
        int obj = Random.Range(1, 3);

        int rotate = 0;

        switch (randIn)
        {
            case 1:
                raddOut = -5;
                if (obj == 2)
                {
                    posZ = 68;
                }


                break;
            case 2:
                raddOut = 5;
                rotate = 180;

                if (obj == 2)
                {
                    posZ = -68;
                }
                break;


        }

        if (transform.position.x < generation.position.x)
        {



            transform.position = new Vector3(generation.position.x + randX, transform.position.y, transform.position.z + raddOut + posZ);





            switch (obj)
            {
                case 1:
                    Instantiate(house, transform.position, Quaternion.Euler(0, rotate, 0));
                    break;
                case 2:
                    Instantiate(zZ, transform.position, Quaternion.Euler(0, rotate, 0));
                    break;
            }




            transform.position = new Vector3(transform.position.x, transform.position.y, 5);
        }
    }
}