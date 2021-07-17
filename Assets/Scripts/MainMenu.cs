using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuGround1;
    public GameObject mainMenuGround2;
    public GameObject mainMenuGround3;
    public GameObject mainMenuGround4;
    public GameObject mainMenuGround5;
    public GameObject mainMenuGround6;
    public GameObject mainMenuGround7;
    public GameObject buttonPlay;

    public float groundSpeed1;
    public float groundSpeed2;
    public float groundSpeed3;
    public float groundSpeed4;
    



    public Text _text;
    ScriptUI scriptUI;
    int allMoney = 0;
    GameObject obj;
    
    
    bool menuMove = false;
    bool menuMoveBack = false;

    private void Start()

    {
        QualitySettings.vSyncCount = 4;

        obj = GameObject.Find("UiManager");
        

        if (obj != null)
        {
            scriptUI = obj.GetComponent<ScriptUI>();
            allMoney = allMoney + scriptUI.countMoneyEnd;
            Debug.Log(scriptUI.countMoneyEnd);
        }
        
        string TextA = allMoney.ToString();

        if (allMoney < 10)
        {
            _text.text = "000" + TextA;
        }
        else if (allMoney < 100)
        {
            _text.text = "00" + TextA;
        }
        else
        {
            _text.text = "0" + TextA;
        }


        
    }

    public void OnMouseDown()
    {
        menuMove = true;
        Invoke("MenuMoveEnd", 1.0f);
        Debug.Log("aaaa");
    }


    public void CloseMenu()
    {
        menuMove = true;
        Invoke("MenuMoveEnd", 1.0f);

    }
    public void MenuMoveEnd()
    {
        menuMove = false;
    }

    public void CloseBackMenu()
    {
        menuMoveBack = true;
        Invoke("MenuMoveBackEnd", 1.0f);

    }
    public void MenuMoveBackEnd()
    {
        menuMoveBack = false;
    }


    private void FixedUpdate()
    {




        if (mainMenuGround5.transform.position.x > -190)
        {
            mainMenuGround5.transform.position = new Vector3(mainMenuGround5.transform.position.x - .1f, mainMenuGround5.transform.position.y, mainMenuGround4.transform.position.z);

        }
        else if (mainMenuGround5.transform.position.x < -190)
        {
            mainMenuGround5.transform.position = new Vector3(mainMenuGround5.transform.position.x + .1f, mainMenuGround5.transform.position.y, mainMenuGround4.transform.position.z);

        }

        if (menuMove)
        {
            mainMenuGround1.transform.position = new Vector3(mainMenuGround1.transform.position.x - groundSpeed1, mainMenuGround1.transform.position.y, mainMenuGround1.transform.position.z);
            mainMenuGround2.transform.position = new Vector3(mainMenuGround2.transform.position.x - groundSpeed2, mainMenuGround2.transform.position.y, mainMenuGround2.transform.position.z);
            mainMenuGround3.transform.position = new Vector3(mainMenuGround3.transform.position.x - groundSpeed3, mainMenuGround3.transform.position.y, mainMenuGround3.transform.position.z);
            mainMenuGround4.transform.position = new Vector3(mainMenuGround4.transform.position.x - groundSpeed4, mainMenuGround4.transform.position.y, mainMenuGround4.transform.position.z);
            
            mainMenuGround6.transform.position = new Vector2(mainMenuGround6.transform.position.x - 0, mainMenuGround6.transform.position.y);
            // buttonPlay.transform.position = new Vector2(buttonPlay.transform.position.x - 6, buttonPlay.transform.position.y);

            mainMenuGround7.transform.position = new Vector2(mainMenuGround7.transform.position.x + 50, mainMenuGround7.transform.position.y);

        }
        if (menuMoveBack)
        {
            mainMenuGround1.transform.position = new Vector2(mainMenuGround1.transform.position.x + groundSpeed1, mainMenuGround1.transform.position.y);
            mainMenuGround2.transform.position = new Vector2(mainMenuGround2.transform.position.x + groundSpeed2, mainMenuGround2.transform.position.y);
            mainMenuGround3.transform.position = new Vector2(mainMenuGround3.transform.position.x + groundSpeed3, mainMenuGround3.transform.position.y);
            mainMenuGround4.transform.position = new Vector2(mainMenuGround4.transform.position.x + groundSpeed4, mainMenuGround4.transform.position.y);


        }
    }

}
