using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CosMove : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    [SerializeField] float _radius = 1f;
    Vector2 _initialPosition;

    void Start()
    {
        _initialPosition = transform.position;
    }

    void Update()
    {
        float x = _radius * Mathf.Cos(_speed * Time.time);
        Vector2 position = new Vector2(x, transform.position.y);
        transform.position = position + Vector2.right * position.x;
    }
}
