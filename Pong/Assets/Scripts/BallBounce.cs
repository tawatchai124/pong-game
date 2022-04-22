using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounce : MonoBehaviour
{

    private Rigidbody2D rigidbody;

    [SerializeField] private float speed = 20.0f;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();


        rigidbody.AddForce(new Vector2(-1, 1) * speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
