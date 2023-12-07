using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControlScript : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] Transform groundcheck;
    [SerializeField] LayerMask ground;
    /*
    bool isGrounded( )
    {
        Physics.CheckSphere(groundcheck.position, .1f, ground);
    }
    */

}
