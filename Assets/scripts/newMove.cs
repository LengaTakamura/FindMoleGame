using UnityEngine;

public class Move : MonoBehaviour
{

    public int number2 = 1;

    Vector2 pos2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos2 = transform.position;

        transform.Translate(transform.right * Time.deltaTime * 100 * number2);

        if (pos2.x > 900)
        {
            number2 = -1;

        }
        if (pos2.x < 70)
        {
            number2 = 1;


        }
    }
}
