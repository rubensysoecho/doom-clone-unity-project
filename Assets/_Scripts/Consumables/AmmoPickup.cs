using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Shooting player = collision.GetComponent<Shooting>();
            if (player.currentAmmo != player.maxAmmo)
            {
                player.FillAmmo();
                player.ReloadUIAmmo();
                Destroy(gameObject);
            }
        }
    }
}
