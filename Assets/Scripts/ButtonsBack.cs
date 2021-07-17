using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsBack : MonoBehaviour
{
    ButtonsMenu menu;
    public GameObject obj;

    private void Start()
    {
        menu = obj.GetComponent<ButtonsMenu>();

    }



    public void OnMouseDown()
    {
        menu.CloseBackMenu();

    }
}
