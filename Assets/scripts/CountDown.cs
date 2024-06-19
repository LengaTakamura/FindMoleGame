using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time <3) 
        {
           //stt.AddOff();

        }
        else if (time >=3) 
        {
            //stt.AddOn();
        }

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
