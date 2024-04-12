using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBehavior : ProjectileWeaponBehavior
{
    WeaponController pistol;




   protected override void Start()
    {
        base.Start();
        pistol = FindObjectOfType<WeaponController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * pistol.speed * Time.deltaTime;
    }
}
