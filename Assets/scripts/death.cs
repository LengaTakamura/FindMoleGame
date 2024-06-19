using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{

    [SerializeField] float LifeTime;
    
    void Update()
    {
        Destroy(this.gameObject,LifeTime);
    }
}
