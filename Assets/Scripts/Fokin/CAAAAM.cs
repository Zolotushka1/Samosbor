using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAAAAM : MonoBehaviour
{
    [SerializeField] private float _sensivity;
    [SerializeField] private Transform _player;
    [SerializeField] private float _verticalLover;
    [SerializeField] private float _verticalUpper;
    private float _currentVerticalAngle;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        _currentVerticalAngle = transform.localRotation.eulerAngles.x;
        if (_currentVerticalAngle > _verticalLover)
        {
            _currentVerticalAngle -= 360;
            if (_currentVerticalAngle < _verticalUpper)
            {
                _currentVerticalAngle = 0;
                Debug.LogWarning($"Угол на {name} выходит за пределы [{_verticalUpper}, {_verticalLover}]");
            }
        }
    }


    void Update()
    {       
        var vertical = -Input.GetAxis("Mouse Y") * _sensivity * Time.deltaTime;
        var horizontal = Input.GetAxis("Mouse X") * _sensivity * Time.deltaTime;

        _currentVerticalAngle = Mathf.Clamp(_currentVerticalAngle + vertical, _verticalUpper, _verticalLover);
        transform.localRotation = Quaternion.Euler(_currentVerticalAngle, 0, 0);

        _player.Rotate(0, horizontal, 0);
    }
}

