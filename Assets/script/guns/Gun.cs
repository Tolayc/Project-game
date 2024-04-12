using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : WeaponController
{
    public GameObject bullet;
    public Transform shotPoint;

    private float timeBtwShots;
    public float StartTimeBtwShots;


    protected override void Start()
    {
        
    }

    
   protected override void Attack()
    {
        if (timeBtwShots <= 0 )
        {
            Instantiate(bullet, shotPoint.position, transform.rotation);
            timeBtwShots = StartTimeBtwShots;
            

        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
