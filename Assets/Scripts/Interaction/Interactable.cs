using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    protected InteractionManager _interactionManager;

	private void Awake()
	{
		_interactionManager = FindObjectOfType<InteractionManager>();
	}
	public abstract void interaction(GameObject source);
}
