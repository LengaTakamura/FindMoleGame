using TMPro;
using UnityEngine;
public class CountDown : MonoBehaviour
{
    float _time;

    [SerializeField] GameObject _TextMeshPro;

    TextMeshProUGUI _cdtext;

    [SerializeField] Stop _stt;
 
    // Start is called before the first frame update
    void Start()
    { 
        _cdtext = _TextMeshPro.GetComponent<TextMeshProUGUI>();

        _cdtext.text = "3";

    }
    void Update()
    {
        _time += Time.deltaTime;
        
        if (_time >= 3.3f)
        {
            Destroy(_cdtext);
        }
        else if (_time >= 3)
        {
            _cdtext.text = "START!";

        }
        else if ( _time >= 2 ) 
        {
            _cdtext.text = "1";
        }
        else if ( _time >= 1)
        {
            _cdtext.text = "2";
        }
    }
}
