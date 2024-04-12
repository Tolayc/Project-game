using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Playerhealthbar : MonoBehaviour
{
    public Slider slider;
    public Vector3 offset;
    public float maxHealth;
    public Transform player;

    public void SetHealth(float health)
    {
        slider.gameObject.SetActive(health < maxHealth);
        slider.value = health;
        slider.maxValue = maxHealth;
    }



    void Start()
    {
        
    }

    public void Update()
    {
        slider.transform.position = player.transform.position + offset;

    }
}
