using UnityEngine;
using System;
using UIMainMenu;



namespace Movement
{

    public class Movement : MonoBehaviour
    {
    

   
     public float movementSpeed = 0.01f;
    [SerializeField] private float rotation = 0f;
    [SerializeField] private KeyCode keyup = KeyCode.W;
    [SerializeField] private KeyCode keydown = KeyCode.S;
    [SerializeField] private KeyCode keyleft = KeyCode.A;
    [SerializeField] private KeyCode keyright = KeyCode.D;
    [SerializeField] private KeyCode keyrotright = KeyCode.E;
    [SerializeField] private KeyCode keyrotleft = KeyCode.Q;
    [SerializeField] private KeyCode C_random = KeyCode.R;
    private SpriteRenderer _color;
    



    private void Awake()
    {
        _color = GetComponent<SpriteRenderer>();
    }


     private void Update()
    {


        Vector3 pos = transform.position;

        //Movimiento

        if (Input.GetKey(keyup))
        {
            //Debug.Log("W");

            pos.y += movementSpeed;
        }
        if (Input.GetKey(keyleft))
        {
            //Debug.Log("A");
            pos.x -= movementSpeed;
        }
        if (Input.GetKey(keydown))
        {
            //Debug.Log("S");
            pos.y -= movementSpeed;
        }
        if (Input.GetKey(keyright))
        {
            // Debug.Log("D");
            pos.x += movementSpeed;
        }

        transform.position = pos;



        //Rotacion

        if (Input.GetKeyDown(keyrotright))
        {
            rotation = -10f;
            transform.Rotate(0, 0, rotation);
        }
        if (Input.GetKeyDown(keyrotleft))
        {
            rotation = 10f;
            transform.Rotate(0, 0, rotation);
        }

        //Color random

        if (Input.GetKeyUp(C_random))
        {
         float blue = UnityEngine.Random.Range(0,1.0f);
         float red = UnityEngine.Random.Range(0,1.0f);
         float green = UnityEngine.Random.Range(0,1.0f);
         _color.color = new Color(blue, red, green);
                
        }

       

    }
    
    public void SetSpeed(float newSpeed)
    {
        if (newSpeed > 1)
            return;
        movementSpeed = newSpeed;
    }
    }
}
