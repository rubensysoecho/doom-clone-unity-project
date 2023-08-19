using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    public int ammoAmount = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Shooting player = collision.GetComponent<Shooting>();
            player.currentAmmo += ammoAmount;
            player.ReloadUIAmmo();
            Destroy(gameObject);
        }
    }
}
