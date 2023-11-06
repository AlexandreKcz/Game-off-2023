using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchZoneTest : Interactable
{
    [SerializeField] private Transform spawnTeleport;
    [SerializeField] private PlayerLocomotion locomotion;
    [SerializeField] private CinemachineVirtualCamera playerVcam;
    [SerializeField] private CinemachineVirtualCamera transitionVcam;
    [SerializeField] private CinemachinePOVExtension pov;

    public override void interaction(GameObject source)
    {
        Debug.Log("switch zone");
        StartCoroutine(camTransition());
    }

    private IEnumerator camTransition()
    {
        playerVcam.Priority = 5;
        transitionVcam.Priority = 15;
        locomotion.LockPlayer = pov.lockCam = true;
        yield return new WaitForSeconds(1.5f);
        pov.resetCamPos = true;
        locomotion.LockPlayer = pov.lockCam = false;
        locomotion.TeleportPlayer(spawnTeleport.position);
        playerVcam.Priority = 15;
        transitionVcam.Priority = 5;
        playerVcam.transform.rotation = spawnTeleport.rotation;
    }
}
