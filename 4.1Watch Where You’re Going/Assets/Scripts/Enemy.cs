using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    internal int Length;
    private Rigidbody EnemyRB;
    private GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        EnemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        EnemyRB.AddForce(lookDirection * speed);
        if (transform.position.y < -10) 
        {
            Destroy(gameObject);
        }

    }
    
     

}
