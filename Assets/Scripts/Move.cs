using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
     public float speed;

    ScriptUI scriptUI;
    public GameObject obj;

    public GameObject bonkPanel;
    public Transform parent;

    public AudioClip moneyClip;
    public AudioClip bonkClip;
    public AudioSource moneyBing;
    public GameObject moneyBoom;
    float speedOld;

    public float jumpForce;
   


    private Rigidbody rb;

    int laneNumber = 1;
    int laneCount = 2;

    public float FirstLanePos,
                 LaneDistance,
                 SideSpeed;

    

    bool overG = true;


    
    bool is_Bonk = false;

   // public Text _text;

    
   // int countMoney = 0;
   // public int countMoneyEnd;
 
    void OnTriggerStay(Collider col)
    {              
        
        if (col.tag == "Bonk") is_Bonk = true;
       
        
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Jump") Jump();
        if (col.tag == "Bonk") is_Bonk = false;
        if (col.tag == "Money")
        {

            //  countMoney += 1;
            scriptUI.MoneyUI();
            moneyBing.clip = moneyClip;
            moneyBing.PlayOneShot(moneyClip);
            moneyBoom.SetActive(true);
            Invoke("MoneyBoom", 0.05f);

        }
    }

    void MoneyBoom()
    {
        moneyBoom.SetActive(false);
    }

    public void Jump()
    {

        rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
        
        speedOld = speed;
        speed = 30;
        Invoke("JunmEnd", 1.0f);

    }
    void JunmEnd()
    {
        speed = speedOld;
    }
    public void Left()
    {
        laneNumber += -1;
        laneNumber = Mathf.Clamp(laneNumber, 0, laneCount);
    }
    public void Right()
    {
        laneNumber += 1;
        laneNumber = Mathf.Clamp(laneNumber, 0, laneCount);
    }





    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        moneyBing = GetComponent<AudioSource>();
        scriptUI = obj.GetComponent<ScriptUI>();

    }

    


    private void FixedUpdate()
    {






        Vector3 newPos = transform.position;




        newPos.z = Mathf.Lerp(newPos.z, FirstLanePos + (laneNumber * LaneDistance), Time.deltaTime * SideSpeed);
        transform.position = newPos;



        rb.velocity = new Vector3(speed, rb.velocity.y);

        speed += 0.002f;

        

        if (is_Bonk && overG )
        {

            //countMoneyEnd = countMoney;

            moneyBing.PlayOneShot(bonkClip);

            Instantiate(bonkPanel, parent);

            speed = 0;
            overG = false;
            
        }

        
        
       

        
        



    }


    




}
