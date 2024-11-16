using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;

    private Camera cam;

    public Weapon activeWeapon;
    
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp (0)) {
            PrepareWeapon ();
        }
        
        if (Input.GetMouseButtonUp (1)) {
            activeWeapon.RechargeWeapon();
        }
    }

    private void PrepareWeapon()
    {
        Debug.Log("weapon fun call");
        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay (Input.mousePosition);

        Enemy targetEnemy = null;

        if (Physics.Raycast (ray, out hit, float.PositiveInfinity, layerMask)) {
            //ray hits somthing with collider
            if (hit.collider.tag.Equals ("enemy")) {
                //ray hits enemy
                targetEnemy = hit.collider.GetComponent <Enemy> ();
            }
        }
        if (targetEnemy != null && activeWeapon.HasEnoughBullets())
        {
            targetEnemy.TakeDamage(activeWeapon.damage);
        }
        activeWeapon.PerformShot();
    }
}