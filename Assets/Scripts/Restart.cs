using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    BlackPanel panel;
    public GameObject obj;
    public float timeLoad;

    private Move move;
    private GameObject Bike;

    private void Start()
    {
        panel = obj.GetComponent<BlackPanel>();
        Bike = GameObject.Find("defaultt");
        if (Bike != null)
        {
            move = Bike.GetComponent<Move>();
        }
    }


    public string scene;

    public void OnMouseDown()
    {
        panel.LoadScene();
        
        Invoke("ToStart", timeLoad);
    }
    public void ToRestart()
    {
        move.RestartMenuExit();
        Invoke("Restarting", timeLoad);
    }

    public void ToExit()
    {
        move.RestartMenuExit();
        Invoke("Exit", timeLoad);
    }

    private void ToStart()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }


    private void Restarting()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);

    }
    private void Exit()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

}
