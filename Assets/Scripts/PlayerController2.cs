using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    public float jumpForce;

    public int coin;
    public bool isGrounded;
    public GameObject Finish;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal2");
        float moveVertical = Input.GetAxis("Vertical2");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded == true)
            {
                Debug.Log("space");
                rb.AddForce(Vector3.up * jumpForce * Time.deltaTime, ForceMode.Impulse);
            }

        }
    }
    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Item"))
        {
            coin++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

            isGrounded = false;
        }
    }

}
