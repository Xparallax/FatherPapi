using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,2f);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(GameObject.FindWithTag("Enemy"));
        Destroy(GameObject.FindWithTag("God"));
    }
}
