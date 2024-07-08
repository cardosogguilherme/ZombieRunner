using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] Cinemachine.CinemachineVirtualCamera cinemachineCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomedOutSensitivity = 2f;
    [SerializeField] float zoomedInSensitivity = .5f;

    private bool zoomedInToogle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToogle)
            {
                zoomedInToogle = true;
                // fpsCamera.fieldOfView = zoomedInFOV;
                cinemachineCamera.m_Lens.FieldOfView = zoomedInFOV;
                fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
            }
            else
            {
                zoomedInToogle = false;
                // fpsCamera.fieldOfView = zoomedOutFOV;
                cinemachineCamera.m_Lens.FieldOfView = zoomedOutFOV;
                fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
                fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
            }
        }
    }
}
