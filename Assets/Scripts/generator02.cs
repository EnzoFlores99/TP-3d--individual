using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator02 : MonoBehaviour
{
    [SerializeField] private GameObject Enemy02;
    [SerializeField] private float initTime;
    [SerializeField] private float repeatTime;
    [SerializeField] private float speedZGenerator02 = 4f;
    private int Counter = 0;
    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
        
    }
    void Update()
    {
        moveGenerator();
    }

    public void GenerateEnemy()
    {
        Instantiate(Enemy02,transform.position, transform.rotation);
        Counter ++;
        if (Counter >=5)
        {
            CancelInvoke("GenerateEnemy");
        }
        
    }
    public void moveGenerator()
    {
        if(transform.position.z < -4.51f || transform.position.z > 4.6f)
                {
                    speedZGenerator02 *=-1; 
                }
                transform.Translate(0,0,speedZGenerator02*Time.deltaTime);
        
    }
    
}
