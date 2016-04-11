using UnityEngine;
using System.Collections;

public class InputState : MonoBehaviour {

    public bool actionButton;
    public float absVelX = 0f;
    public float absVelY = 0f;
    public bool isStanding;
    public float StandingThreshold = 1;

    private Rigidbody2D body2d;

    public void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        actionButton = Input.anyKeyDown;
    }

    void FixedUpdate()
    {
        absVelX = System.Math.Abs(body2d.velocity.x);
        absVelY = System.Math.Abs(body2d.velocity.y);

        isStanding = absVelY <= StandingThreshold;
    }
    
}
