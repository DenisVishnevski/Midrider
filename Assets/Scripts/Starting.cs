using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{
     public GameObject myscript;
    
    public void Play()
    {
        Destroy(myscript);
    }


    void Update()
    {
        Invoke("Play", 1.0f);

    }
}
