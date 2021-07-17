using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
     public float speed;

    ScriptUI scriptUI;
    public GameObject obj;

    public GameObject FlankColliders;

    public GameObject bonkPanel;
    public GameObject bonkEffect;
    public Transform parent;

    public AudioClip moneyClip;
    public AudioClip bonkClip;
    public AudioSource moneyBing;
    public GameObject moneyBoom;
    float speedOld;

    public float jumpForce;

    BlackPanel panel;
    public GameObject blackPanel;



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
 

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Jump") Jump();
        if (col.tag == "Bonk") is_Bonk = true;
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
        panel = blackPanel.GetComponent<BlackPanel>();

    }

    


    private void FixedUpdate()
    {

        FlankCollidersMove();




        Vector3 newPos = transform.position;




        newPos.z = Mathf.Lerp(newPos.z, FirstLanePos + (laneNumber * LaneDistance), Time.deltaTime * SideSpeed);
        transform.position = newPos;



        rb.velocity = new Vector3(speed, rb.velocity.y);

        speed += 0.002f;

        

        if (is_Bonk && overG)
        {

            //countMoneyEnd = countMoney;

            moneyBing.PlayOneShot(bonkClip);
            
            bonkEffect.SetActive(true);
            
            panel.LoadScene();
            


            speed = 0;
            overG = false;
            Invoke("RestartMenu", .5f);
        }
       
    }
    void RestartMenu()
    {
        Instantiate(bonkPanel, parent);
        panel.LoadSceneOpen();

    }

    void FlankCollidersMove()
    {
        FlankColliders.transform.position = transform.position;
    }
    public void RestartMenuExit()
    {
        
        panel.LoadScene();
        
    }



}
