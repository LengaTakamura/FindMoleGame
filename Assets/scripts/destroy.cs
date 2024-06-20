using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField]float lifetime = 1.0f;

    [SerializeField]AudioSource AudioSource;

    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;

        AudioSource = GetComponent<AudioSource>(); 
       
        AudioSource.Play();

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > lifetime)
        {
            Destroy(gameObject);
        }

    }
}
