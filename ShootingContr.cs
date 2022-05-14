using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//стрельба и вывод количества убитых монстров
public class ShootingContr : MonoBehaviour
{
    public Camera cam;
    public ParticleSystem partic;
    int kille=0;
    [SerializeField] TextMeshProUGUI die;
    public GameObject win;
    public GameObject tim;
    public GameObject hppp;
    public GameObject killll;
    public GameObject pric;
    public BodyContr script;
    void Start()
    {
        
    }


    void Update()
    {   

        RaycastHit hit;
        if(Input.GetButtonDown("Fire1")){
            partic.Play();
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
                if(hit.transform.gameObject.tag == "target"){
                    kille=kille+1;
                    die.text=kille.ToString();
                    Destroy(hit.transform.gameObject);
                    if (kille==9){
                        script.CancelInvoke();
                        win.SetActive(true);
                        tim.SetActive(false);
                        hppp.SetActive(false);
                        killll.SetActive(false);
                        pric.SetActive(false);
                    }


                }
            }
            
        }
    }
}
