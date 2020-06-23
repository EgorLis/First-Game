using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Scrollbar scrollbar;
    private Creature person;
    
    // Start is called before the first frame update
    void Start()
    {
        scrollbar.size = 1;
        person = GameObject.FindGameObjectWithTag("Player").GetComponent<Creature>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player"))
        {
            scrollbar.size =  (float)person.m_health / (float)person.max_health;
            if (scrollbar.size == 0)
                scrollbar.handleRect.gameObject.SetActive(false);
        }
    }
}
