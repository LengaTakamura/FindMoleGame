using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
     [SerializeField]GameObject center1;
     
   [SerializeField] GameObject kuromaru1;
    public void AddOff()
    {

        center1.SetActive(false);

        kuromaru1.SetActive(false);

    }



    public void AddOn()
    {
        center1.SetActive(true); 
        
        kuromaru1.SetActive(true);

    }
}
   
