using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMenu : MonoBehaviour
{
    public GameObject board;
    public GameObject mainMenuGround1;
    public GameObject mainMenuGround2;
    public GameObject mainMenuGround3;
    public GameObject mainMenuGround4;
    public GameObject mainMenuGround5;
    public GameObject mainMenuGround6;


    public float groundSpeed1;
    public float groundSpeed2;
    public float groundSpeed3;
    public float groundSpeed4;
    
    public float boardSpeed;
    bool menuMove = false;
    bool menuMoveBack = false;
   


    public void OnMouseDown()
    {
        menuMove = true;
        Invoke("MenuMoveEnd", 1.0f);
        
    }
    


    public void CloseBackMenu()
    {
        menuMoveBack = true;
        Invoke("MenuMoveEnd", 1.0f);

    }

    public void MenuMoveEnd()
    {
        menuMove = false;
        menuMoveBack = false;
    }




    private void FixedUpdate()
    {




     
        if (menuMove)
        {
            board.transform.position = new Vector3(board.transform.position.x - boardSpeed, board.transform.position.y, board.transform.position.z);

            mainMenuGround1.transform.position = new Vector3(mainMenuGround1.transform.position.x - groundSpeed1, mainMenuGround1.transform.position.y, mainMenuGround1.transform.position.z);
            mainMenuGround2.transform.position = new Vector3(mainMenuGround2.transform.position.x - groundSpeed2, mainMenuGround2.transform.position.y, mainMenuGround2.transform.position.z);
            mainMenuGround3.transform.position = new Vector3(mainMenuGround3.transform.position.x - groundSpeed3, mainMenuGround3.transform.position.y, mainMenuGround3.transform.position.z);
            mainMenuGround4.transform.position = new Vector3(mainMenuGround4.transform.position.x - groundSpeed4, mainMenuGround4.transform.position.y, mainMenuGround4.transform.position.z);

            
            
        }
        if (menuMoveBack)
        {

            board.transform.position = new Vector3(board.transform.position.x + boardSpeed, board.transform.position.y, board.transform.position.z);

            mainMenuGround1.transform.position = new Vector3(mainMenuGround1.transform.position.x + groundSpeed1, mainMenuGround1.transform.position.y, mainMenuGround1.transform.position.z);
            mainMenuGround2.transform.position = new Vector3(mainMenuGround2.transform.position.x + groundSpeed2, mainMenuGround2.transform.position.y, mainMenuGround2.transform.position.z);
            mainMenuGround3.transform.position = new Vector3(mainMenuGround3.transform.position.x + groundSpeed3, mainMenuGround3.transform.position.y, mainMenuGround3.transform.position.z);
            mainMenuGround4.transform.position = new Vector3(mainMenuGround4.transform.position.x + groundSpeed4, mainMenuGround4.transform.position.y, mainMenuGround4.transform.position.z);


        }


        
    }

   






}
