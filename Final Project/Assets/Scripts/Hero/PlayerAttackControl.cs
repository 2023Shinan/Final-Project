using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackControl : MonoBehaviour
{
    public GameObject Player;
    public GameObject Enemy;

    string playerTag = "Player";
    string enemyTag = "Enemy";
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag(playerTag);
        Enemy = GameObject.FindGameObjectWithTag(enemyTag);
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 distanceBetweenObjects = Player.transform.InverseTransformDirection(Enemy.transform.position);
        Debug.Log(distanceBetweenObjects.sqrMagnitude);

        //if(distanceBetweenObjects.sqrMagnitude < 2 && Input.GetKeyDown(KeyCode.Mouse0))
        //{
            //if (Enemy != null)
            //{
                //Destroy(Enemy);
            //}
                
            
        
    }
}
