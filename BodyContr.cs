using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//движение через character controller, время, hp.
public class BodyContr : MonoBehaviour
{

    public CharacterController contr;
    public Transform playerBody;
    public float speed=12f;
    int time=20;
    public GameObject lose;
    public GameObject tim;
    public GameObject hppp;
    public GameObject killll;
    public GameObject pric;
    [SerializeField] TextMeshProUGUI sec;
    void timeMinus(){
        time=time-1;
        sec.text="TIME:  "+time ;
        if (time==0){
            CancelInvoke();
            lose.SetActive(true);
            tim.SetActive(false);
            hppp.SetActive(false);
            killll.SetActive(false);
            pric.SetActive(false);
        }
        

    }
    void Start()
    {
      InvokeRepeating("timeMinus",1f,1f);
        
    }
   
    void Update()
    {
      
      float vertical=Input.GetAxis("Vertical");
      float horizantal=Input.GetAxis("Horizontal");
      contr.Move(playerBody.forward*speed*vertical*Time.deltaTime);
      contr.Move(playerBody.right*speed*horizantal*Time.deltaTime);
        
    }


   
}
