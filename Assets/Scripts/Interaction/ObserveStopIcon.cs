using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserveStopIcon : MonoBehaviour
{
    private Observable _objetObserve;

    public Observable ObjetObserve
	{
		get { return _objetObserve; }
		set { _objetObserve = value; }
	}

	public void Click()
	{
		_objetObserve.StopObserve();
	}
}
