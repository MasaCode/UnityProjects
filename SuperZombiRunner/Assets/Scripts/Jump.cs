using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

    public float jumpSpeed = 240f;
    public float forwardSpeed = 20;

    private Rigidbody2D body2d;
    private InputState inputState;

    public void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
        inputState = GetComponent<InputState>();
    }

    void Update()
    {
        if (inputState.isStanding)
        {
            if (inputState.actionButton)
            {
                if (transform.position.x <= 0)
                    body2d.velocity = new Vector2(forwardSpeed, jumpSpeed);
                else
                body2d.velocity = new Vector2(0, jumpSpeed);
            }
        }
    }
}
