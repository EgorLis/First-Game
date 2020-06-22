using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public float MoveCoffi = 0.2f;
    public float MeleeAttackDistance = 10;
    public int MeleeAttack = 25;
    private Transform target;
    private Creature hero;

    private float nextActionTime = 0.0f;
    public float period = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, MoveCoffi * Time.deltaTime);
            hero = GameObject.FindGameObjectWithTag("Player").GetComponent<Creature>();
            if(Vector2.Distance(transform.position,target.position)<= MeleeAttackDistance
                && Time.time > nextActionTime)
            {
                hero.m_health -= MeleeAttack;
                nextActionTime += period;
            }
        }
    }
}
