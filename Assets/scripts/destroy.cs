using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]float lifetime = 1.0f;

    [SerializeField]AudioSource AudioSource;

    float time = 0f;
    void Start()
    {
        time = 0;

        AudioSource = GetComponent<AudioSource>(); 
       
        AudioSource.Play();

    }
    void Update()
    {
        time += Time.deltaTime;

        if (time > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
