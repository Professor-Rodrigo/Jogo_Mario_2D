using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float speed;

    [SerializeField] private float jump_force;

    private SpriteRenderer player_sprite;

    public ground_check jump_detector;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player_sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            if (!player_sprite.flipX)
            {
                player_sprite.flipX = true;
            }

            rb.velocity = new Vector2(-speed,transform.position.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (player_sprite.flipX)
            {
                player_sprite.flipX = false;
            }
            rb.velocity = new Vector2(speed,transform.position.y);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }


    }

    void Jump()
    {
        if(jump_detector.Jump_State())
        {
            rb.velocity = new Vector2(transform.position.x,jump_force);
        }
    }
}
