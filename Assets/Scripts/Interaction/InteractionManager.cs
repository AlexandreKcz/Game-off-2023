using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    private InputManager _inputManager;

    [SerializeField] private Camera _camera;

    [SerializeField] private LayerMask _interactionLayer;

    [Range(0f, 20f)] [SerializeField] private float _interactionDistance = 10f;

    private void Awake()
    {
        _inputManager = InputManager.Instance;

        if(_inputManager == null)
        {
            _inputManager = FindObjectOfType<InputManager>();
        }

        _camera = Camera.main;
    }

    private void Update()
    {
        if (_inputManager.PlayerInteractThisFrame()) checkForInteraction();
    }

    private void checkForInteraction()
    {
        RaycastHit hit;

        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out hit, _interactionDistance, _interactionLayer))
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
