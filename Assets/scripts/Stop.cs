using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
     [SerializeField]CenterScript center1;
     
   [SerializeField] Kuromaru kuromaru1;
    public void AddOff()
    {

        center1.enabled = false;

        kuromaru1.enabled = false;

    }



    public void AddOn()
    {
        center1.enabled = true;

        kuromaru1.enabled = true;

    }
}
   
