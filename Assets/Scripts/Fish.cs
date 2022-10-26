using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] private float _speed;
    int angle;
    int minAngle = -60;
    int maxAngle = 20;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_rb.gravityScale = 0;        
    }
    void Update()
    {
        FishSwim(); // Fish input hareket
        FishRotation(); // Fish Rotasyonu
    }
    void FishSwim()
    {
        // Fish input hareket
        if (Input.GetMouseButtonDown(0))
        {
            _rb.velocity = Vector2.zero;
            _rb.velocity = new Vector2(_rb.velocity.x, _speed);
        }
    }
    void FishRotation()
    {
        // Fish Rotasyonu
        if (_rb.velocity.y > 0)
        {
            // Yukarý giderken açýyý arttýr
            if (angle <= maxAngle)
            {
                angle = angle + 4;
            }
        }
        else if (_rb.velocity.y < -1.2f)
        {
            // Aþaðý inerken açýyý azalt
            if (angle > minAngle)
            {
                angle = angle - 2;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
