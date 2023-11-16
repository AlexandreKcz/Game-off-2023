using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class switchZoneTest : Interactable
{
    [Header("Assignables")]
    [SerializeField] private Transform spawnTeleport;
    [SerializeField] private PlayerLocomotion locomotion;
    [SerializeField] private CinemachineVirtualCamera playerVcam;
    [SerializeField] private CinemachineVirtualCamera transitionVcam;
    [SerializeField] private CinemachinePOVExtension pov;
    [SerializeField] private Volume transitionVolume;

    [Header("Tweakables")]
    [SerializeField][Tooltip("cam final rotation on transition end")] private Vector3 camRotationOveride = Vector3.zero;
    [SerializeField][Tooltip("transition time, must be changed in cmBrain too")] private float transitionTime = .5f;



    public override void interaction(GameObject source)
    {
        Debug.Log("switch zone");
        StartCoroutine(camTransition());
    }

    private IEnumerator camTransition()
    {
        StartCoroutine(volumeTransition());
        playerVcam.Priority = 5;
        transitionVcam.Priority = 15;
        locomotion.LockPlayer = pov.lockCam = true;
        yield return new WaitForSeconds(transitionTime);
        pov.OverrideRotation = camRotationOveride;
        locomotion.LockPlayer = pov.lockCam = false;
        locomotion.TeleportPlayer(spawnTeleport.position);
        playerVcam.Priority = 15;
        transitionVcam.Priority = 5;
        playerVcam.transform.rotation = spawnTeleport.rotation;
    }


    private IEnumerator volumeTransition()
    {
        Debug.Log("start transition");
        transitionVolume.weight = 0;

        float betterTransitionTime = .25f;

        float initTime = Time.time;

        float delta = Time.deltaTime;

        Debug.Log(delta);

        int steps;

        steps = (int) (betterTransitionTime / delta);

        /* Vieille boucle (obsolete mais je garde)
        for (int i = 0; i < steps; i ++)
        {
            transitionVolume.weight = i / (float) steps;
            yield return new WaitForSeconds((((float)betterTransitionTime / 2f) / (float) steps));
        }
        for (int i = steps; i > 0; i--)
        {
            transitionVolume.weight = i / (float) steps;
            yield return new WaitForSeconds((((float)betterTransitionTime / 2f) / (float)steps));
        }*/

        int currentSteps = 0;

        while(currentSteps < steps * 2)
        {
            float stamp = Time.time;

            if(currentSteps <= steps)
            {
                transitionVolume.weight = currentSteps / (float)steps;
            } else
            {
                transitionVolume.weight = (steps - (currentSteps - steps)) / (float)steps;
            }

            while((Time.time - stamp) < (betterTransitionTime / (float)steps))
            {
                //Debug.Log("waiting");
                //yield return new WaitForEndOfFrame();
                yield return null;
            }

            currentSteps++;
        }

        transitionVolume.weight = 0;

        yield return new WaitForEndOfFrame();

        Debug.Log("end transition");
        Debug.Log(Time.time - initTime);
    }
}
