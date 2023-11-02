using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchZoneTest : Interactable
{
    [SerializeField] private Transform _spawnTeleport;
    [SerializeField] private PlayerController _player;
    [SerializeField] private CinemachineVirtualCamera _camera;
    [SerializeField] private CinemachineVirtualCamera _transitionCam;
    [SerializeField] private CinemachinePOVExtension _pov;

    public override void interaction(GameObject source)
    {
        Debug.Log("switch zone");
        StartCoroutine(camTransition());
    }

    private IEnumerator camTransition()
    {
        _camera.Priority = 5;
        _transitionCam.Priority = 15;
        _player.lockPlayer = _pov.lockCam = true;
        yield return new WaitForSeconds(1.5f);
        _pov.resetCamPos = true;
        _player.lockPlayer = _pov.lockCam = false;
        _player.TeleportPlayer(_spawnTeleport.position);
        _camera.Priority = 15;
        _transitionCam.Priority = 5;
        _camera.transform.rotation = _spawnTeleport.rotation;
    }
}
