using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class animationStateConroller : MonoBehaviour
{
    private CharacterController characterController;
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isBackingHash;
    //int VelocityHash;
    public float Speed = 5f;
    public float rotateSpeed = 20f;
    //float animationVelocity = 0.0f;
    //public float acceleration = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();

        animator = GetComponent<Animator>();

        //VelocityHash = Animator.StringToHash("Velocity");

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isBackingHash = Animator.StringToHash("isBacking");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, Input.GetAxis("Vertical"));
        Vector3 rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * rotateSpeed * Time.deltaTime, 0);
        this.transform.Rotate(rotation);
        characterController.Move(move * Time.deltaTime * Speed);

        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isBacking = animator.GetBool(isBackingHash);

        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        bool backwardPressed = Input.GetKey("s");

        //if (forwardPressed)
        //{
        //animationVelocity += Time.deltaTime * acceleration;
        //}
        //animator.SetFloat(VelocityHash, animationVelocity);
        if (!isWalking && forwardPressed)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if (!isRunning && (runPressed && forwardPressed))
        {
            animator.SetBool(isRunningHash, true);
            Speed = Speed * 2;
        }

        if (isRunning && (!runPressed || !forwardPressed))
        {
            animator.SetBool(isRunningHash, false);
            Speed = 5f;
        }

        if ((!isBacking && backwardPressed) && !isWalking)
        {
            animator.SetBool(isBackingHash, true);
            Speed = 2.5f;
        }

        if (isBacking && !backwardPressed)
        {
            animator.SetBool(isBackingHash, false);
            Speed = 5f;
        }
    }
}
