
using TMPro;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    [SerializeField]GameObject _cdtext;

    TextMeshProUGUI _textMeshPro;

    [SerializeField] Stop _stop;

    
    void Start()
    {
        _textMeshPro = _cdtext.GetComponent<TextMeshProUGUI>();

       
    }
    void Update()
    {
        if (_textMeshPro != null) 
        {
            _stop.AddOff();
        }
        if (_textMeshPro == null) 
        {
            _stop.AddOn();

            //_audioSource.Play();
        } 
    }
}
