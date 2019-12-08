using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlatformController : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField] private float speed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.velocity = Vector2.zero;
        
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.velocity = Vector2.left * speed;    
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.velocity = Vector2.right * speed;    

        }

        
    }
}
