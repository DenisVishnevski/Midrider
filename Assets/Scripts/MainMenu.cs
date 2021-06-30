using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
     public GameObject mainMenu;
    public Text _text;
    ScriptUI scriptUI;
    int allMoney = 0;
    GameObject obj;
    

    private void Start()

    {
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


    public void CloseMenu()
    {
        mainMenu.SetActive(false);
    }

  
}
