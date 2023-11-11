using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaPlayer : MonoBehaviour
{
    [SerializeField]
    private float speedZ= 2f;
    
    void Update()
    {
        transform.Translate(0,0,speedZ*Time.deltaTime);
        DestroyBall();

    }
    public void DestroyBall()
    {
        if(transform.position.z<= -6 || transform.position.z>= 6 )
        {
            Destroy(gameObject);
        }
    }
}
