using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;

    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {
        // Initialize player rigidbody
        playerRb = GetComponent<Rigidbody>();
        // Modify gravity
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    // Called on collision with box collider
    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
