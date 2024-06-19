using Unity.VisualScripting;
using UnityEngine;

public class Kuromaru : MonoBehaviour
{
    private Vector2 position;

    [SerializeField]AudioSource audioSource;

    Timer m_timer;

    CenterScript m_center;

    //center Center;     //格納するための変数

    //GameObject center2;　//格納するための変数
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        m_timer = GameObject.FindObjectOfType<Timer>();

        m_center = GameObject.FindObjectOfType<CenterScript>();

    }

    // Update is called once per frame
    void Update()
    {
        //if(m_timer.timeup == true || m_center.GameOver == true)
        //{
        //    this.enabled = false;
        //}

        position = Input.mousePosition;

        position = Camera.main.ScreenToWorldPoint(position);

        if (Input.GetButtonDown("Fire1"))
        {
           
            Vector2 pin = position;

            transform.position = pin;

            audioSource.Play();
             
        }

        
    }

    
}
