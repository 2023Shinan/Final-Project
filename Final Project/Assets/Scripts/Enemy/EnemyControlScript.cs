using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlScript : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] Transform groundcheck;
    [SerializeField] LayerMask Ground;

    private void Update()
    {
        bool isGrounded()
        {
            return Physics.CheckSphere(groundcheck.position, .1f, Ground);
        }
    }

    

}
