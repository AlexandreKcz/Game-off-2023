using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class switchZoneTest : Interactable
{
    [Header("Assignables")]
    [SerializeField] private Transform _spawnTeleport;
    [SerializeField] private CinemachineVirtualCamera _transitionVcam;

    [Header("Static Components")]
    private static PlayerLocomotion _locomotion;
    private static CinemachineVirtualCamera _playerVcam;
    private static CinemachinePOVExtension _pov;
    private static Volume _transitionVolume;
    private static LensDistortion _transitionLensDistortion;
    private static InventoryManager _inventoryManager;

    [Header("Tweakables")]
    [SerializeField][Tooltip("cam final rotation on transition end")] private Vector3 _camRotationOveride = Vector3.zero;
    [SerializeField][Tooltip("transition time, must be changed in cmBrain too")] private float _transitionTime = .25f;
    [SerializeField] private bool _reverseFishEye = false;

    private void Awake()
    {
        GameObject player = GameObject.Find("Player");

        if(switchZoneTest._locomotion == null) switchZoneTest._locomotion = player.GetComponent<PlayerLocomotion>();
        if(switchZoneTest._playerVcam == null)
        {
            switchZoneTest._playerVcam = GameObject.Find("Player Virtual Camera").GetComponent<CinemachineVirtualCamera>();
            switchZoneTest._pov = switchZoneTest._playerVcam.gameObject.GetComponent<CinemachinePOVExtension>();
        }

        if(switchZoneTest._transitionVolume == null)
        {
            switchZoneTest._transitionVolume = GameObject.Find("Transition Volume").GetComponent<Volume>();
        }

        if(switchZoneTest._transitionLensDistortion == null)
        {
            /* Recupere la lensDist depuis le volume via tryGet */
            LensDistortion tmp;
            if(switchZoneTest._transitionVolume.profile.TryGet<LensDistortion>(out tmp))
            {
                switchZoneTest._transitionLensDistortion = tmp;
            }
        }

        if(switchZoneTest._inventoryManager == null)
        {
            if(InventoryManager.Instance != null)
            {
                switchZoneTest._inventoryManager = InventoryManager.Instance;
            }
            else
            {
                switchZoneTest._inventoryManager = FindObjectOfType<InventoryManager>();
            }
        }
    }


    public override void interaction(GameObject source)
    {
        Debug.Log("switch zone");
        StartCoroutine(camTransition());
    }

    private IEnumerator camTransition()
    {
        StartCoroutine(volumeTransition());
        switchZoneTest._inventoryManager.animTrigger();
        _playerVcam.Priority = 5;
        _transitionVcam.Priority = 15;
        _locomotion.LockPlayer = _pov.lockCam = true;
        yield return new WaitForSeconds(_transitionTime);
        _pov.OverrideRotation = _camRotationOveride;
        _locomotion.LockPlayer = _pov.lockCam = false;
        _locomotion.TeleportPlayer(_spawnTeleport.position);
        _playerVcam.Priority = 15;
        _transitionVcam.Priority = 5;
        _playerVcam.transform.rotation = _spawnTeleport.rotation;
    }


    private IEnumerator volumeTransition()
    {
        if (_reverseFishEye)
        {
            switchZoneTest._transitionLensDistortion.intensity.value = 1f;
        }
        else
        {
            switchZoneTest._transitionLensDistortion.intensity.value = -1f;
        }

        _transitionVolume.weight = 0;

        float betterTransitionTime = _transitionTime;

        float initTime = Time.time;

        float delta = Time.deltaTime;

        int steps;

        steps = (int) (betterTransitionTime / delta);

        int currentSteps = 0;

        while(currentSteps < steps * 2)
        {
            float stamp = Time.time;

            if(currentSteps <= steps)
            {
                _transitionVolume.weight = currentSteps / (float)steps;
            } else
            {
                _transitionVolume.weight = (steps - (currentSteps - steps)) / (float)steps;
            }

            while((Time.time - stamp) < (betterTransitionTime / (float)steps))
            {
                yield return null;
            }

            currentSteps++;
        }

        _transitionVolume.weight = 0;

        yield return new WaitForEndOfFrame();
    }
}
