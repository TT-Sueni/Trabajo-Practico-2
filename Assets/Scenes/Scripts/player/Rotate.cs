using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [Header("Rotation")]

    [SerializeField] private float rotation = 10.0f;
    [SerializeField] private KeyCode keyrotright = KeyCode.E;
    [SerializeField] private KeyCode keyrotleft = KeyCode.Q;

    private Rigidbody2D rb2D;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Rotation();
    }

    private void Rotation()
    {
        if (Input.GetKeyDown(keyrotright))
        {
            rb2D.AddTorque(rotation * Time.deltaTime,ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(keyrotleft))
        {
            rb2D.AddTorque(-rotation * Time.deltaTime, ForceMode2D.Impulse);
        }
    }
}