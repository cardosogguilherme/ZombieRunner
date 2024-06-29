using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] Cinemachine.CinemachineVirtualCamera cinemachineCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;

    private bool zoomedInToogle = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!zoomedInToogle)
            {
                zoomedInToogle = true;
                fpsCamera.fieldOfView = zoomedInFOV;
                cinemachineCamera.m_Lens.FieldOfView = zoomedInFOV;
            }
            else
            {
                zoomedInToogle = false;
                fpsCamera.fieldOfView = zoomedOutFOV;
                cinemachineCamera.m_Lens.FieldOfView = zoomedOutFOV;
            }
        }
    }
}
