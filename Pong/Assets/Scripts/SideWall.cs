using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class SideWall : MonoBehaviour
{

    [SerializeField] private UnityEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            print("p1 side wall");

            scoreTrigger.Invoke();
        }
    }

}
