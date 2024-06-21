using TMPro;
using UnityEngine;
public class CountDown : MonoBehaviour
{
    double _time;

    [SerializeField] GameObject _TextMeshPro;

    TextMeshProUGUI _cdtext;

    [SerializeField] Stop _stt;

    [SerializeField] AudioClip _audioClip;

    [SerializeField] AudioClip _audioClip2;

    AudioSource _audioSource;

    bool _isPlaying = true;

    bool _isPlaying2 = true;

    bool _isPlaying3 = true;

    // Start is called before the first frame update
    void Start()
    {
        _cdtext = _TextMeshPro.GetComponent<TextMeshProUGUI>();

        _cdtext.text = "3";

        _audioSource = GetComponent<AudioSource>();

        _audioSource.PlayOneShot(_audioClip);

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
        else if (_time >= 2.8 && _isPlaying3)
        {
            _isPlaying3 = false;

            _audioSource.PlayOneShot(_audioClip2);
        }
        else if (_time >= 2)
        {
            _cdtext.text = "1";
        }

        else if (_time >= 1.8f && _isPlaying2)
        {
            _isPlaying2 = false;

            _audioSource.PlayOneShot(_audioClip);
        }
        else if (_time >= 1)
        {
            _cdtext.text = "2";
        }
        else if (_time >= 0.8f && _isPlaying)
        {
            _isPlaying = false;

            _audioSource.PlayOneShot(_audioClip);
        }

    }

}
