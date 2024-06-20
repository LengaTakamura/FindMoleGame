using TMPro;
using UnityEngine;
public class CountDown : MonoBehaviour
{
    float time;

    [SerializeField] GameObject m_TextMeshPro;

    TextMeshProUGUI cdtext;

    [SerializeField] Stop stt;
 
    // Start is called before the first frame update
    void Start()
    { 
        cdtext = m_TextMeshPro.GetComponent<TextMeshProUGUI>();

        cdtext.text = "3";

    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 1) 
        {
            cdtext.text = "2";
        }

        if (time >= 2)
        {
            cdtext.text = "1";
        }

        if (time >= 3)
        {
            cdtext.text = "START!";

        }
        if(time >= 3.3f)
        {
            Destroy(cdtext);
        }
    }
}
