using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    public int currentAmmo;
    public GameObject bulletImpact;
    public Camera cameraView;
    public Animator anim;

    public float shootingCooldown = 1f;
    private float nextShoot;

    // Interfaz
    public Text txt_ammo;

    // Start is called before the first frame update
    void Start()
    {
        txt_ammo.text = currentAmmo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && currentAmmo > 0 && Time.time >= nextShoot)
        {
            Shoot();
            nextShoot = Time.time + shootingCooldown;
        }
    }

    void Shoot()
    {
        Ray ray = cameraView.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Has dado en el blanco! - Objetivo: " + hit.transform.name);
            Instantiate(bulletImpact, hit.point, transform.rotation);
        }
        else
        {
            Debug.Log("Has fallado!");
        }
        currentAmmo--;
        ReloadUIAmmo();
        anim.SetTrigger("Shoot");
    }

    public void ReloadUIAmmo()
    {
        txt_ammo.text = currentAmmo.ToString();
    }
}
