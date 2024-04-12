using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automate : MonoBehaviour
{
    public GameObject bullet;
    public Transform shotPoint;

    private float timeBtwShots;
    public float StartTimeBtwShots;
    public float StartTimeOcheredShots;
    private float Ochered;
    public int pul;
    private int oboima;
    public bool strike;

    public bool puli=true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (timeBtwShots <= 0 && strike==true )
        {
            Instantiate(bullet, shotPoint.position, transform.rotation);
            timeBtwShots = StartTimeBtwShots;
            oboima--;
            if (oboima <= 0) strike = false;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }

        
        if(strike==false && Ochered>=0)
        {
            Ochered -= Time.deltaTime;
        }
        else if(strike==false && Ochered<=0)
        {
            Ochered = StartTimeOcheredShots;
            strike = true;
            oboima = pul;
        }
        
    }

    void Burst()
    {

    }
}
