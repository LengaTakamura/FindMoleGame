using Unity.VisualScripting;
using UnityEngine;

public class Kuromaru : MonoBehaviour
{
    private Vector2 position;

    [SerializeField]AudioSource audioSource;

    Timer m_timer;

    CenterScript m_center;

    //center Center;     //äiî[Ç∑ÇÈÇΩÇﬂÇÃïœêî

    //GameObject center2;Å@//äiî[Ç∑ÇÈÇΩÇﬂÇÃïœêî
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
    
        
    }

    public void Movement()
    {

        position = Input.mousePosition;

        position = Camera.main.ScreenToWorldPoint(position);

            Vector2 pin = position;

            transform.position = pin;

            audioSource.Play();
    }

    
}
