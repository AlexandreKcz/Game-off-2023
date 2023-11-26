using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    public bool Opened{ 
        get { return _opened; }
        set { 
            _opened = value; 
            this.updateDoor();
        }
    }

    private Animator _animator;
    private bool _opened = false;
    private int _direction = 0;
    private Vector3 _parentTransformForward;

    private void Start()
    {
        _animator = GetComponentInParent<Animator>();

        this._parentTransformForward = this.transform.parent.transform.parent.forward;

        /* Corrige l'orientation */
        float z = this._parentTransformForward.z;
        float x = this._parentTransformForward.x;
        this._parentTransformForward.x = z;
        this._parentTransformForward.z = x;
    }

    public override void interaction(GameObject source)
    {
        this._opened = !this._opened;

        int dirCalc = (int) (Vector3.Scale(this.transform.position, this._parentTransformForward).magnitude - Vector3.Scale(source.transform.position, this._parentTransformForward).magnitude);

        this._direction = dirCalc;
        //Debug.Log(this.transform.parent.transform.parent.forward);
        //Debug.Log(this.transform.position.x - source.transform.position.x);
        //Debug.Log(Vector3.Scale(this.transform.position, this._parentTransformForward).magnitude - Vector3.Scale(source.transform.position, this._parentTransformForward).magnitude);
        this.updateDoor();
    }

    private void updateDoor()
    {
        if (_animator != null)
        {
            _animator.SetBool("Opened", this._opened);
            _animator.SetInteger("Direction", this._direction);
        }
    }
}
