using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSway : MonoBehaviour
{
    [SerializeField] private float _intensity;
    [SerializeField] private float _smooth;

    private Quaternion _originRotation;
    private Transform _weaponParent;

    private Vector3 _targetWeaponBobPosition;
    private Vector3 _weaponParentOrigin;

    private Vector2 _playerMovement;
    private Vector2 _mouseDelta;

    private float _movementCounter;
    private float _idleCounter;

    private InputManager _inputManager;

    private void Start()
    {
        _weaponParent = transform.parent;

        _originRotation = transform.localRotation;
        _weaponParentOrigin = _weaponParent.localPosition;

        _inputManager = InputManager.Instance;

        if(_inputManager == null)
        {
            Debug.LogWarning("Input Manager null in itemSway, setting from findObject");

            _inputManager = FindObjectOfType<InputManager>();
        }
    }

    private void Update()
    {
        UpdateSway();

        _playerMovement = _inputManager.GetPlayerMovement();
        _mouseDelta = _inputManager.GetMouseDelta();

        if(_playerMovement.magnitude == 0)
        {
            HeadBob(_idleCounter, .025f, .025f);
            _idleCounter += Time.deltaTime;
            _weaponParent.localPosition = Vector3.Lerp(_weaponParent.localPosition, _targetWeaponBobPosition, Time.deltaTime * .8f);
        } else
        {
            HeadBob(_idleCounter, .035f, .035f);
            _idleCounter += Time.deltaTime * 3f;
            _weaponParent.localPosition = Vector3.Lerp(_weaponParent.localPosition, _targetWeaponBobPosition, Time.deltaTime * 1.2f);
        }
    }

    private void UpdateSway()
    {
        float t_x_mouse = _mouseDelta.x;
        float t_y_mouse = _mouseDelta.y;

        Quaternion t_x_adj = Quaternion.AngleAxis(-_intensity * t_x_mouse, Vector3.up);
        Quaternion t_y_adj = Quaternion.AngleAxis(_intensity * t_y_mouse, Vector3.right);
        Quaternion target_Rotation = _originRotation * t_x_adj * t_y_adj;

        transform.localRotation = Quaternion.Lerp(transform.localRotation, target_Rotation, Time.deltaTime * _smooth);
    }

    void HeadBob(float p_z, float p_x_intensity, float p_y_intensity)
    {
        _targetWeaponBobPosition = _weaponParentOrigin + new Vector3(Mathf.Cos(p_z) * p_x_intensity, Mathf.Sin(p_z * 2) * p_y_intensity, 0);
    }

    public void resetPos()
    {
        _weaponParent.localPosition = _weaponParentOrigin;
        transform.localRotation = _originRotation;
    }
}
