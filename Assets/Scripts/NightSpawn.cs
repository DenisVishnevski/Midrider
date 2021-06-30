using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightSpawn : MonoBehaviour
{
    public GameObject trash;
    public GameObject p;
    public GameObject s;
    public GameObject b;
    public GameObject springboard;
    public GameObject car;
    public GameObject bus;
    public GameObject board;
    public Transform generation;
    public GameObject springboardPlus;
    public GameObject CarPlus;
    public GameObject BusPlus1;
    public GameObject BusPlus2;
    Object obj;

    Vector3 springboardVector = new Vector3(-8, 0, 0);
    Vector3 CarVector = new Vector3(0, 0, 3);
    Vector3 springboardVectorX = new Vector3(0, 0, 0);
    Vector3 boardVec = new Vector3(0, 0, 0);






    void Update()
    {

        int randIn = Random.Range(1, 4);
        float raddOut = 0;
        float randX = Random.Range(40f, 50f);
        int randSpringboard = Random.Range(1, 10);
        int randCar = Random.Range(1, 4);
        int randCarPlus = Random.Range(1, 2);
        bool spawnCar = false;
        float carRotate = Random.Range(-35, 36);
        int randobj = Random.Range(1, 5);
        int randSpawnObj = Random.Range(1, 3);
        string pos = "mid";
        int moneyRotate = 0;
        switch (randIn)
        {
            case 1:
                raddOut = 4;
                spawnCar = true;
                CarVector = new Vector3(0, 0, -9);
                springboardVectorX = new Vector3(0, 0, -4);
                boardVec = new Vector3(0, 0, -3.75f);
                moneyRotate = 180;
                pos = "right";
                break;
            case 2:
                raddOut = -4;
                spawnCar = true;
                CarVector = new Vector3(0, 0, 3);
                springboardVectorX = new Vector3(0, 0, 4);
                boardVec = new Vector3(0, 0, 4.25f);
                pos = "left";
                break;
            case 3:
                raddOut = 0;
                break;

        }
        switch (randobj)
        {
            case 1:
                obj = p;
                break;
            case 2:
                obj = s;
                break;
            case 3:
                obj = b;
                break;
            case 4:
                obj = trash;
                break;

        }


        if (transform.position.x < generation.position.x)
        {



            transform.position = new Vector3(generation.position.x + randX, transform.position.y, transform.position.z + raddOut);







            switch (randCar)
            {
                case 1:
                    if (spawnCar)
                    {
                        Instantiate(car, transform.position + CarVector, Quaternion.Euler(0, carRotate, 0));


                        if (randCarPlus == 1) Instantiate(CarPlus, transform.position - new Vector3(0, 0, raddOut), Quaternion.Euler(0, moneyRotate, 0));
                    }
                    else
                    {
                        Instantiate(obj, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);
                        Instantiate(BusPlus2, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), Quaternion.Euler(0, moneyRotate, 0));
                        // fix
                    }
                    break;
                case 2:
                    if (spawnCar)
                    {
                        Instantiate(board, transform.position + boardVec, Quaternion.Euler(0, 90, 0));

                        if (randSpawnObj == 1) Instantiate(obj, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);
                    }
                    else
                    {
                        if (randX > 49)
                        {
                            Instantiate(bus, transform.position - new Vector3(0, 0, raddOut), Quaternion.Euler(0, 90, 0));
                            Instantiate(springboard, transform.position + springboardVector + springboardVector, transform.rotation);
                        }
                        else if (randX > 30 && randX < 50)
                        {
                            if (pos == "right" || pos == "mid")
                            {
                                Instantiate(car, transform.position + new Vector3(0, 0, -5), Quaternion.Euler(0, carRotate, 0));

                                Instantiate(car, transform.position + new Vector3(20, 0, -1), Quaternion.Euler(0, carRotate, 0));
                                if (randCarPlus == 1) Instantiate(CarPlus, transform.position + new Vector3(20, 0, 0) - new Vector3(0, 0, raddOut), Quaternion.Euler(0, moneyRotate, 0));

                            }
                            else
                            {
                                Instantiate(car, transform.position + new Vector3(0, 0, -1), Quaternion.Euler(0, carRotate, 0));

                                Instantiate(car, transform.position + new Vector3(20, 0, -5), Quaternion.Euler(0, carRotate, 0));
                                if (randCarPlus == 1) Instantiate(CarPlus, transform.position + new Vector3(20, 0, 0) - new Vector3(0, 0, raddOut), Quaternion.Euler(0, moneyRotate, 0));
                            }

                        }
                        else
                        {
                            Instantiate(obj, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);
                            Instantiate(BusPlus2, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), Quaternion.Euler(0, moneyRotate, 0));
                            // fix
                        }
                    }
                    break;
                case 3:
                    if (pos == "mid")
                    {
                        if (randX > 42)
                        {
                            Instantiate(bus, transform.position, transform.rotation);
                            if (randSpringboard == 1)
                            {
                                Instantiate(springboardPlus, transform.position + new Vector3(-37, 0, 0), transform.rotation);
                            }
                            else
                            {
                                Instantiate(bus, transform.position, transform.rotation);
                                // Instantiate(springboard, transform.position + new Vector3(-25, 0, 0), transform.rotation);

                                Instantiate(board, transform.position + new Vector3(20, 0, 0), Quaternion.Euler(0, 90, 0));

                            }


                        }
                        else
                        {
                            Instantiate(obj, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);
                            Instantiate(BusPlus2, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), Quaternion.Euler(0, moneyRotate, 0));
                            // fix
                        }
                    }
                    else if (randX > 42)
                    {
                        Instantiate(bus, transform.position, transform.rotation);
                        if (randSpringboard == 1)
                        {
                            Instantiate(springboardPlus, transform.position + new Vector3(-37, 0, 0), transform.rotation);
                        }
                        else
                        {

                            Instantiate(bus, transform.position, transform.rotation);


                            Instantiate(obj, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);
                            if (pos == "left")
                            {
                                Instantiate(BusPlus1, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);

                            }
                            else
                            {
                                Instantiate(BusPlus2, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);
                            }
                        }
                    }
                    else
                    {
                        Instantiate(obj, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), transform.rotation);
                        Instantiate(BusPlus2, transform.position + springboardVector + springboardVector - new Vector3(0, 0, raddOut), Quaternion.Euler(0, moneyRotate, 0));
                        // fix
                    }





                    break;



            }
            transform.position = new Vector3(transform.position.x, transform.position.y, 5);


        }
    }
}
