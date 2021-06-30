using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine;

public class Swipe : MonoBehaviour, IBeginDragHandler, IDragHandler
{




    public GameObject TargetObj;
    private Move actionTarget;

    public void Start()
    {
        actionTarget = TargetObj.GetComponent<Move>();
    }



    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta;

        if (Mathf.Abs(delta.x) > Mathf.Abs(delta.y))
        {
            if (delta.x > 0)
            {
                actionTarget.Left();
            }
            else if (delta.x < 0)
            {
                actionTarget.Right();
            }
        }
        else if (Mathf.Abs(delta.y) > Mathf.Abs(delta.x))
        {
            if (delta.y > 0)
            {

               // actionTarget.Jump();

            }
        }

        

    }

    public void OnDrag(PointerEventData eventData)
    {

    }

}