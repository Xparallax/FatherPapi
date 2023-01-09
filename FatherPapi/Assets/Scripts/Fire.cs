using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private Transform barrel;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private GameObject[] ammo;

    private int ammoAmount;

    // Start is called before the first frame update
    void Start()
    {
      for (int i = 0; i <= 2; i++)
      {
        ammo[i].gameObject.SetActive(false);
      }   
      ammoAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && ammoAmount > 0)
        {
            var spawnedBullet = Instantiate(bullet, barrel.position, barrel.rotation);
            spawnedBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 500f);
            ammoAmount -= 1;
            ammo[ammoAmount].gameObject.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ammoAmount = 3;
            for (int i = 0; i <= 2; i++)
            {
                ammo[i].gameObject.SetActive(true);
            }
        }
    }
}
