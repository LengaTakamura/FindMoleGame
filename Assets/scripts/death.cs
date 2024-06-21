
using UnityEngine;

public class Death : MonoBehaviour
{

    [SerializeField] float LifeTime;
    
    void Update()
    {
        Destroy(this.gameObject,LifeTime);
    }
}
