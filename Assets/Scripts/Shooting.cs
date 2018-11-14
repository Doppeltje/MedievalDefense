
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject Ammo;
    [SerializeField] private GameObject tower;

    private Weapon weapon;
    private Lock_On lockOn;



    private void Start()
    {
        lockOn = FindObjectOfType<Lock_On>();
        weapon = FindObjectOfType<Weapon>();
    }

    void Update()
    {
        weapon.fireRate = weapon.fireRate + 1 * Time.deltaTime;


        if (weapon.fireRate > .4 && lockOn.gotTarget)
        {
            weapon.Shoot();
            weapon.fireRate = 0;
        }
    }
}