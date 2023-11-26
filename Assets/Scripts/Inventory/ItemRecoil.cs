using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemRecoil : MonoBehaviour
{
    private Vector3 _currentRotation,
                    _targetRotation,
                    _targetPosition,
                    _currentPosition,
                    _initialItemPosition;

    [SerializeField] private Transform _cam;

    [SerializeField] private float _recoilX;
    [SerializeField] private float _recoilY;
    [SerializeField] private float _recoilZ;

    [SerializeField] private float _kickbackZ;

    [SerializeField] private float _snapiness;
    [SerializeField] private float _returnAmount;

    private void Start()
    {
        _initialItemPosition = transform.localPosition;
    }

    private void Update()
    {
        _targetRotation = Vector3.Lerp(_targetRotation, Vector3.zero, Time.deltaTime * _returnAmount);
        _currentRotation = Vector3.Slerp(_currentRotation, _targetRotation, Time.fixedDeltaTime * _snapiness);
        transform.localRotation = Quaternion.Euler(_currentRotation);

        back();
    }

    public void recoil()
    {
        _targetPosition -= new Vector3(0, 0, _kickbackZ);
        _targetRotation += new Vector3(_recoilX, Random.Range(-_recoilY, _recoilY), Random.Range(-_recoilZ, _recoilZ));
    }

    private void back()
    {
        _targetPosition = Vector3.Lerp(_targetPosition, _initialItemPosition, Time.deltaTime * _returnAmount);
        _currentPosition = Vector3.Lerp(_currentPosition, _targetPosition, Time.fixedDeltaTime * _snapiness);
        transform.localPosition = _currentPosition;
    }
}
