using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackControl : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;

    string EnemyTage = "Enemy";
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag(EnemyTage);
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 distanceBetweenObjects = Player.transform.InverseTransformDirection(Enemy.transform.position);
        Debug.Log(distanceBetweenObjects.sqrMagnitude);
    }
}
