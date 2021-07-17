using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{

    BlackPanel panel;
    public GameObject obj;


    private void Start()
    {
        panel = obj.GetComponent<BlackPanel>();
        Play();
    }

    public void Play()
    {
        panel.LoadSceneOpen();
    }

}
