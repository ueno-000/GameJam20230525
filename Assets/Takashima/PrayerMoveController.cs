using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrayerMoveController : MonoBehaviour
{
    [SerializeField] private float _jumpPower;
    

    private Rigidbody2D _rb;

    private bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        

            if (Input.GetButtonDown("Jump") && isGround)
            {
                
                _rb.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
                
            }
        
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = false;
        }
    }
}
