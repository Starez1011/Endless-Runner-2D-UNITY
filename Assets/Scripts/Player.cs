using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirectionX, playerDirectionY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirectionY = new Vector2(0f, directionY).normalized;
        float directionX = Input.GetAxisRaw("Horizontal");
        playerDirectionX = new Vector2(directionX, 0).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(playerDirectionX.x * playerSpeed, playerDirectionY.y * playerSpeed);
    }
}
