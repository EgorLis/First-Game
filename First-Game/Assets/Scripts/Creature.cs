using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Creature : MonoBehaviour
{
    public GameObject person;
    public int m_health = 100;
    private Inventory m_inventory;
    private WeaponTypes m_activeWeapon;
    public float MoveCoffi = 0.02f;

    // Update is called once per frame
    void Update()
    {
        if (m_health <= 0)
            Destroy(person);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        m_health -= 20;
        print("i am dying");
    }
}
