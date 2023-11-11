using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 2f;
    [SerializeField] private GameObject PlayerBall;
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*speed*Time.deltaTime,0,0);
        if (Input.GetButtonDown("Jump"))
        {
            ShootBall();
        }

        
    }
    public void ShootBall()
    {
        Instantiate (PlayerBall,transform.position,transform.rotation);
    }
   
}
