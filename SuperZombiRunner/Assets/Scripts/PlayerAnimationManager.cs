using UnityEngine;
using System.Collections;

public class PlayerAnimationManager : MonoBehaviour {

    private Animator animator;
    private InputState inputState;

    public void Awake()
    {
        animator = GetComponent<Animator>();
        inputState = GetComponent<InputState>();
    }


    public void Update()
    {
        var running = true;

        if (inputState.absVelX > 0 && inputState.absVelY < inputState.StandingThreshold)
            running = false;

        animator.SetBool("Running", running);

    }

}
