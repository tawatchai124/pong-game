using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour
{

    [SerializeField] private GameObject targetBall;

    [SerializeField] private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(transform.position.x <0)
        {
            if (transform.position.y > targetBall.transform.position.y)
            {
                transform.Translate(-Vector3.up * Time.deltaTime * speed);
            }

            if (transform.position.y < targetBall.transform.position.y)
            {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
        }



    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            print("AI Paddle hit ball");
        }
    }
}
