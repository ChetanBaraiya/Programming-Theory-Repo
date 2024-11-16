using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;

    private Camera cam;

    public Weapon activeWeapon;
    
    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp (0)) {
            PrepareWeapon ();
        }
        
        if (Input.GetKeyDown(KeyCode.R)) {
           
            activeWeapon.RechargeWeapon();
        }
    }

    private void PrepareWeapon()
    {
        Debug.Log("weapon function call");
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

        if ( !activeWeapon.HasEnoughBullets())
        {
            GameManager.Instance.ShowRechargeMessage();
        }
        if (targetEnemy != null&& activeWeapon.HasEnoughBullets())
        {
            targetEnemy.TakeDamage(activeWeapon.damage);
        }
        activeWeapon.PerformShot();
    }
}