using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{

    [SerializeField] private int maxHP;
    private int hp;

    private void Start()
    {
        hp = maxHP;
    }

    void Update()
    {
        
    }

    public void TakeDamage(int damage) 
    {
        if (damage >= hp)
        {
            Destroy(gameObject);
        }
        else
        {
            hp -= damage;
        }
    }
}
