using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    public GameObject[] menuLayers;
    public float[] menuLayersSpeed;

    public float MaxLeftPosition;
    public float MaxRightPosition;

    private bool menuMoveLeft = false;
    private bool menuMoveRight = false;

    private int Left = -1;
    private int Right = 1;


    private void FixedUpdate()
    {
        if (menuMoveLeft)
        {
            MenuMove(Left);

        }
        else if (menuMoveRight)
        {
            MenuMove(Right);
        }

    }

    private void MenuMove(int directionOfMovement)
    {
        for (int i = 0; i < 5; i++)
        {
            menuLayers[i].transform.position = new Vector3(menuLayers[i].transform.position.x + menuLayersSpeed[i] * directionOfMovement, menuLayers[i].transform.position.y, menuLayers[i].transform.position.z);
        }
    }

    public void MenuMovementLeft()
    {
        menuMoveLeft = true;
        Invoke("MenuMoveEnd", 1.0f);
    }

    public void MenuMovementRight()
    {
        menuMoveRight = true;
        Invoke("MenuMoveEnd", 1.0f);
    }

    public void MenuMoveEnd()
    {
        menuMoveLeft = false;
        menuMoveRight = false;
    }




}
