using UnityEngine;
public class Move : MonoBehaviour
{
    [SerializeField] float _speed2 = 1f;
    [SerializeField] float _radius2 = 1f;
    Vector2 _initialPosition2;
    RectTransform _rect;

    void Start()
    {
        _rect = GetComponent<RectTransform>();
        _initialPosition2 = _rect.position;
    }

    void Update()
    {
        float x = _radius2 * Mathf.Sin(_speed2 * Time.time);
        Vector2 position = new Vector2(x, _rect.position.y);
        _rect.position = position + Vector2.right * _initialPosition2;
    }
}
