using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.VisualScripting.Member;

public class Door : Interactable
{
    public bool Opened{ 
        get { return _opened; }
        set { 
            _opened = value; 
            this.updateDoor();
        }
    }

    [SerializeField][Tooltip("Invert Door Opening")] private bool _invert = false;

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

        this.processDirection(source.transform);

        this.updateDoor();
    }

    private void processDirection(Transform source) //process de la direction du joueur, determine le sens d'ouverture de la porte
    {
        float dirCalc = 0;
        if (Mathf.Abs(this._parentTransformForward.x) > 0)
        {
            dirCalc = this._parentTransform.position.z - source.position.z;
        }
        else if (Mathf.Abs(this._parentTransformForward.z) > 0)
        {
            dirCalc = this._parentTransform.position.x - source.position.x;
        }
        if (this._invert) dirCalc *= -1;
        this._direction = (int)dirCalc;
    }

    private void updateDoor() //Update des valeurs d'animator, reste géré automatiquement
    {
        if (_animator != null)
        {
            _animator.SetBool("Opened", this._opened);
            _animator.SetInteger("Direction", this._direction);
        }
    }
}
