using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptUI : MonoBehaviour
{
    private static ScriptUI _instance;

    public static ScriptUI Instance { get { return _instance; } }


    public Text _text;


    int countMoney = 0;
    public int countMoneyEnd;
    public int sss;
    private void Awake()
    {




        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        // DontDestroyOnLoad(gameObject);

        
    }




    public void MoneyUI()
    {
        countMoney += 1;
        string TextA = countMoney.ToString();

        if (countMoney < 10)
        {
            _text.text = "000" + TextA;
        }
        else if (countMoney < 100)
        {
            _text.text = "00" + TextA;
        }
        else
        {
            _text.text = "0" + TextA;
        }
        countMoneyEnd = countMoney;
        
    }





   


   

}
