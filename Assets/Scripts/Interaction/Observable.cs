using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Observable : Interactable
{
	[Range(0f, 10f)] [SerializeField] private float scaleMultiplier = 1f;

	private PlayerLocomotion _locomotion;
	private CinemachinePOVExtension _cam;
	private static GameObject _curseurUI, _iconStopObserve, _zoneObserve;
	private static ObserveStopIcon _scriptIconStopObserve;
	private static ObserveMouseHandler _scriptObserveMouse;

	private static Camera _cameraObserve;

	private GameObject itemObserve;
	private bool _isObserved = false;
	private void Start()
	{
		_locomotion = FindObjectOfType<PlayerLocomotion>();
		_cam = FindObjectOfType<CinemachinePOVExtension>();
		if(_curseurUI == null && _iconStopObserve == null && _zoneObserve == null)
		{
			Observable._curseurUI = GameObject.Find("curseur");
			Observable._iconStopObserve = GameObject.Find("ObserveStopIcon");
			Observable._zoneObserve = GameObject.Find("ObserveZone");
			Observable._iconStopObserve.SetActive(false);
			Observable._zoneObserve.SetActive(false);
			Observable._scriptIconStopObserve = Observable._iconStopObserve.GetComponent<ObserveStopIcon>();
			Observable._scriptObserveMouse = Observable._zoneObserve.GetComponent<ObserveMouseHandler>();
			Observable._cameraObserve = GameObject.Find("ObserveCamera").GetComponent<Camera>();
			Observable._cameraObserve.enabled = false;
		}
	}
	public override void interaction(GameObject source)
	{
		if(_isObserved)
		{
			StopObserve();
		}
		else
		{
			BeginObserve();
		}
	}

	public void BeginObserve()
	{
		_isObserved = true;
		Cursor.lockState = CursorLockMode.Confined;
		Cursor.visible = true;
		_locomotion.LockPlayer = true;
		_cam.lockCam = true;
		Observable._curseurUI.SetActive(false);
		Observable._iconStopObserve.SetActive(true);
		Observable._zoneObserve.SetActive(true);
		Observable._scriptIconStopObserve.ObjetObserve = this;
		this._interactionManager.CanInteract = false;

		itemObserve = Instantiate(this.gameObject, new Vector3(1000, 1000, 1000), Quaternion.identity);

		Observable._scriptObserveMouse.ScaleMultiplier = scaleMultiplier; // IMPORTANT : définir le multiplicateur avant de définir l'objet
		Observable._scriptObserveMouse.ObjetObserve = itemObserve;

		Observable._cameraObserve.enabled = true;
	}

	public void StopObserve()
	{
		_isObserved = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = true;
		_locomotion.LockPlayer = false;
		_cam.lockCam = false;
		Observable._curseurUI.SetActive(true);
		Observable._iconStopObserve.SetActive(false);
		Observable._zoneObserve.SetActive(false);
		this._interactionManager.CanInteract = true;

		Observable._cameraObserve.enabled = false;

		Destroy(itemObserve);
	}
}
