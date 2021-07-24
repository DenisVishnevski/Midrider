using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    public MenuMovement menuMovement;

    private void OnMouseDown()
    {
        switch (direction)
        {
            case DirectionOfMovement.Left:
                menuMovement.MenuMovementLeft();
                break;
            case DirectionOfMovement.Right:
                menuMovement.MenuMovementRight();
                break;
        }
    }

    public DirectionOfMovement direction;

    public enum DirectionOfMovement
    {
        Left,
        Right
    }
}
