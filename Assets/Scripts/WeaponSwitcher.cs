using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    [SerializeField] int currentWeapon = 0;

    void Start()
    {
        SetWeaponActive(currentWeapon);
    }

    void Update()
    {
        int previousWeapon = currentWeapon;

        ProcessKeyInput();
        ProcessScroolWheel();

        if (previousWeapon != currentWeapon)
        {
            SetWeaponActive(currentWeapon);
        }
    }

    private void ProcessScroolWheel()
    {
        if (Input.mouseScrollDelta.y > 0)
        {
            currentWeapon = currentWeapon == 0 ? transform.childCount - 1 : currentWeapon - 1;
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            currentWeapon = currentWeapon == transform.childCount - 1 ? 0 : currentWeapon + 1;
        }

        SetWeaponActive(currentWeapon);
    }

    private void ProcessKeyInput()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentWeapon = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentWeapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentWeapon = 2;
        }

        SetWeaponActive(currentWeapon);
    }

    private void SetWeaponActive(int weaponIndex)
    {
        if (weaponIndex > transform.childCount - 1)
        {
            weaponIndex = 0;
        }

        foreach (Transform weapon in transform)
        {
            weapon.gameObject.SetActive(weaponIndex == currentWeapon);
            weaponIndex++;
        }
    }

}
