using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPanel : MonoBehaviour
{
    private bool loadMenu = false;
    private bool loadMenuOpen = false;
    public GameObject blackPanelUp;
    public GameObject blackPanelDown;
    public float timing;

    public float blackPanelSpeed;
    
    public void LoadScene()
    {
        
        loadMenu = true;
        Invoke("MenuMoveEnd", timing);
       
    }
    

    public void LoadSceneOpen()
    {
        
        loadMenuOpen = true;
        Invoke("MenuMoveEndOpen", timing);
    }
    public void MenuMoveEnd()
    {
        
        loadMenu = false;
    }
    public void MenuMoveEndOpen()
    {
        
        loadMenuOpen = false;
    }
    
    void Update()
    {
        
        if (loadMenu && blackPanelUp.transform.position.y >= 1000)
        {
            
            blackPanelUp.transform.position = new Vector3(blackPanelUp.transform.position.x, blackPanelUp.transform.position.y - blackPanelSpeed, blackPanelUp.transform.position.z);
            blackPanelDown.transform.position = new Vector3(blackPanelDown.transform.position.x, blackPanelDown.transform.position.y + blackPanelSpeed, blackPanelDown.transform.position.z);

        }

        if (loadMenuOpen && blackPanelUp.transform.position.y <= 1700)
        {
            blackPanelUp.transform.position = new Vector3(blackPanelUp.transform.position.x, blackPanelUp.transform.position.y + blackPanelSpeed, blackPanelUp.transform.position.z);
            blackPanelDown.transform.position = new Vector3(blackPanelDown.transform.position.x, blackPanelDown.transform.position.y - blackPanelSpeed, blackPanelDown.transform.position.z);

        }

    }
    

}
