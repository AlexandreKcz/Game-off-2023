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
    private Transform _parentTransform;

    private void Start()
    {
        _animator = GetComponentInParent<Animator>();

        this._parentTransform = this.transform.parent.transform.parent;
        this._parentTransformForward = this._parentTransform.forward;
    }

    public override void interaction(GameObject source)
    {
        this._opened = !this._opened;

        float dirCalc = 0;
        Debug.Log("orientation : " + "x : " + this._parentTransformForward.x + " y : " + this._parentTransformForward.y + " z : " + this._parentTransformForward.z); ;
        if (Mathf.Abs(this._parentTransformForward.x) > 0)
        {
            Debug.Log("using z from x as compatative");
            dirCalc = this._parentTransform.position.z - source.transform.position.z;
        }
        else if (Mathf.Abs(this._parentTransformForward.z) > 0)
        {
            Debug.Log("using x from z as compatative");
            dirCalc = this._parentTransform.position.x - source.transform.position.x;
        }

        //float dirCalc = Vector3.Scale(this._parentTransform.position, this._parentTransformForward).magnitude - Vector3.Scale(source.transform.position, this._parentTransformForward).magnitude;

        //float dirCalc = (Vector3.Scale(this.transform.position, this._parentTransformForward) - Vector3.Scale(source.transform.position, this._parentTransformForward)).magnitude;

        Debug.Log((int)dirCalc);

        this._direction = (int) dirCalc;
        /*
        Debug.Log(this.transform.parent.transform.parent.forward);
        Debug.Log("x : " + (this.transform.position.x - source.transform.position.x));
        Debug.Log("y : " + (this.transform.position.z - source.transform.position.z));*/
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
