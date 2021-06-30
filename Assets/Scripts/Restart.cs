using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{

    public string scene;

    public void ToStart()
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
    public void ToRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
    }

    public void ToExit()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

}
