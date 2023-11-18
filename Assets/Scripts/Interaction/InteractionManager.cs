using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public Camera Camera
    {
        get { return _camera; }
        set { _camera = value; }
    }

    private bool _canInteract = true;

    public bool CanInteract
    {
        get { return _canInteract; }
        set { _canInteract = value; }
    }

    [SerializeField] private LayerMask interactionLayer;

    [Range(0f, 20f)] [SerializeField] private float interactionDistance = 10f;

    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }

    public void checkForInteraction()
    {
		if (!_canInteract) { return; }

        RaycastHit hit;

        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, interactionDistance, interactionLayer))
        {
            Interactable inter = hit.transform.gameObject.GetComponent<Interactable>();

            if(inter == null)
            {
                Debug.LogError("Interaction sans script sur l'objet : " + hit.transform.gameObject.name + " un objet interactif doit avoir un script héritant de Interactable");
                return;
            }

            inter.interaction(this.gameObject);
        }
    }
}
