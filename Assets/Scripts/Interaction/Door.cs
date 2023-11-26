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
        this._parentTransformForward.x = Mathf.Abs(z);
        this._parentTransformForward.z = Mathf.Abs(x);
    }

    public override void interaction(GameObject source)
    {
        this._opened = !this._opened;

        float dirCalc = Vector3.Scale(this.transform.position, this._parentTransformForward).magnitude - Vector3.Scale(source.transform.position, this._parentTransformForward).magnitude;

        //float dirCalc = (Vector3.Scale(this.transform.position, this._parentTransformForward) - Vector3.Scale(source.transform.position, this._parentTransformForward)).magnitude;

        Debug.Log(dirCalc);

        this._direction = dirCalc > 0 ? 1 : -1;
        Debug.Log(this.transform.parent.transform.parent.forward);
        Debug.Log("x : " + (this.transform.position.x - source.transform.position.x));
        Debug.Log("y : " + (this.transform.position.z - source.transform.position.z));
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
