using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;


//движение врага на игрока
public class EnemyContr : MonoBehaviour
{
    NavMeshAgent agent;
    public GameObject player;
    Transform playerTR;
    int hp=10000;
    [SerializeField] TextMeshProUGUI hpp;
    
    float distance;
    void Start()
    {
       agent=GetComponent<NavMeshAgent>();
       playerTR=player.GetComponent<Transform>();
       

    }
    
    void Update()
    {   
        
        distance=Vector3.Distance(player.transform.position,agent.transform.position);
        agent.SetDestination(playerTR.position);
        if (distance<=1){
           hp=hp-1;
           hpp.text="HP: "+hp;
       }
    }

}
