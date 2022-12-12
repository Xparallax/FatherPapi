using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lootheal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player");
            {
                var HealComponent = collision.GetComponent<Health>();
                if (HealComponent != null)
                {
                    HealComponent.Heal(3);
                }
                  if(collision.tag == "Player");
                {
                    Destroy(gameObject);
                }
            }
        }

        
    
}
