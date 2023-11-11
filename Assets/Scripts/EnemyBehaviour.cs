using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject EnemyBall;
    [SerializeField] private float speedX = 2f;
    [SerializeField] private float speedZ = 2f;
    [SerializeField] private int EnemyType;
    [SerializeField] private float speedXEnemy02 = 4f;
    private float randomTime = 0;
    void Start()
    {
        switch(EnemyType)
        {
            case 1:
            {
            InvokeRepeating("ShootBall",0f,1f);
            break;
            }
            case 2:
            {
                Invoke("ShootBall", randomTime);
                break;
            }
        }     
    }

    void Update()
    {
        moveEnemy();
        
        
    }
    public void ShootBall()
    {
        Instantiate (EnemyBall,transform.position,transform.rotation);
        if (EnemyType == 2)
        {
            randomTime = Random.Range(1,3);
            Invoke("ShootBall", randomTime);
        }
    }
    public void moveEnemy()
    {
            switch (EnemyType)
            {
            case 1:
            {
            transform.Translate(speedX*Time.deltaTime,0,speedZ*Time.deltaTime);
            break;
            }

            case 2:
            {
                if( transform.position.x < -4.44f || transform.position.x > 4.4f )
                {
                    speedXEnemy02 *=-1; 
                }
                transform.Translate(speedXEnemy02*Time.deltaTime,0,0);
                break;              
            }
            }
            if (transform.position.x < -5.5)
            {
                Destroy(gameObject);
            }
    }
    
    
          
}
