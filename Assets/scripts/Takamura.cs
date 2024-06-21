using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// あ
public class Takamura : MonoBehaviour
{
    [SerializeField] Text _console;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;
        _console.text = mousePosition.ToString();
    }
}
