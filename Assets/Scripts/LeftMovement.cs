using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    BoxCollider2D _box;
    float _groundWith;
    void Start()
    {
        _box = GetComponent<BoxCollider2D>();
        _groundWith = _box.size.x;
    }
    
    void Update()
    {
        transform.position = new Vector2(transform.position.x - _speed * Time.deltaTime, transform.position.y);

        if (transform.position.x <= -_groundWith)
        {
            transform.position = new Vector2(transform.position.x + 2 * _groundWith, transform.position.y);
        }
    }
}
