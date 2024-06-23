using UnityEngine;

// あ
public class MoveUI : MonoBehaviour
{
    [SerializeField] float _speed = 1f;
    [SerializeField] float _radius = 1f;
    Vector2 _initialPosition;
    RectTransform rect;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        _initialPosition = rect.position;
    }

    void Update()
    {
        float x = _radius * Mathf.Cos(_speed * Time.time);
        Vector2 position = new Vector2(x, rect.position.y);
        rect.position = position + Vector2.right * position.x;
    }
}
