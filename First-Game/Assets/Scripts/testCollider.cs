using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCollider : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }
}
