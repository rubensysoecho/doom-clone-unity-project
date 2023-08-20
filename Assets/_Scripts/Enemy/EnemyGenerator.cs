using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{

    public GameObject enemy;
    public float cooldown = 3f;
    private float actualTime;

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= actualTime)
        {
            Instantiate(enemy);
            actualTime = Time.time + cooldown;
        }
    }
}
