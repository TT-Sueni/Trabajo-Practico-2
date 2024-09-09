using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Ball ball;
    [SerializeField] private Vector2 initialForce = new Vector2(5, 0);
   




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            ball.rigidbody2d.velocity = Vector2.zero;
            ball.rigidbody2d.AddForce(initialForce);
        }
    }

}

