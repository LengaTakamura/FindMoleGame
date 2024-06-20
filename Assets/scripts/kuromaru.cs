
using UnityEngine;

public class Kuromaru : MonoBehaviour
{
    private Vector2 position;

    [SerializeField]AudioSource audioSource;
    
    Timer m_timer;

    CenterScript m_center;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        m_timer = GameObject.FindObjectOfType<Timer>();

        m_center = GameObject.FindObjectOfType<CenterScript>();

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
