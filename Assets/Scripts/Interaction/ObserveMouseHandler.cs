using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObserveMouseHandler : MonoBehaviour, IDragHandler, IScrollHandler
{
	private GameObject _objetObserve;
	private float _scaleMultiplier;

	private int etatZoom = 1; // 0 = dézoomé, 1 = normal, 2 = zoomé

	[Range(0f, 10f)] [SerializeField] private float[] tabZoomScales = { 1f, 5f, 10f };

	[Range(0f, 1f)] [SerializeField] private float sensibility = 1f;

	[SerializeField]
	private Camera observerCamera;

	public float ScaleMultiplier
	{
		get { return _scaleMultiplier; }
		set { _scaleMultiplier = value; }
	}

	public GameObject ObjetObserve
	{
		get { return _objetObserve; }
		set
		{
			etatZoom = 1;
			_objetObserve = value;
			_objetObserve.transform.localScale = new Vector3(this.tabZoomScales[etatZoom], this.tabZoomScales[etatZoom], this.tabZoomScales[etatZoom]) * this._scaleMultiplier;
		}
	}

	public void OnDrag(PointerEventData eventData)
	{
		_objetObserve.transform.RotateAround(_objetObserve.transform.position, observerCamera.transform.up, -eventData.delta.x * sensibility);
		_objetObserve.transform.RotateAround(_objetObserve.transform.position, observerCamera.transform.right, eventData.delta.y * sensibility);
	}

	public void OnScroll(PointerEventData eventData)
	{
		if (eventData.scrollDelta.normalized.y > 0 && etatZoom != 2) { etatZoom++; }
		if (eventData.scrollDelta.normalized.y < 0 && etatZoom != 0) { etatZoom--; }

		_objetObserve.transform.localScale = new Vector3(this.tabZoomScales[etatZoom], this.tabZoomScales[etatZoom], this.tabZoomScales[etatZoom]) * this._scaleMultiplier;
	}
}
