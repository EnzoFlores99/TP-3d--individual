using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatorEnemy : MonoBehaviour
{
    [SerializeField] private GameObject Enemy01;
    [SerializeField] private float initTime;
    [SerializeField] private float repeatTime;
    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
    }


    public void GenerateEnemy()
    {
        Instantiate(Enemy01,transform.position, transform.rotation);
    }
    /*void OnBecameInvisible()
    {
        
        Destroy(Enemy01);
       
    }*/
    
}
