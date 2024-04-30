using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Vector2 _delta;
    private bool _isRotating;
    [SerializeField] private float _rotationSpeed = 0.5f;

    public void OnLook (InputAction.CallbackContext context)
    {
        _delta = context.ReadValue<Vector2>();
    }

    public void OnRotate (InputAction.CallbackContext context)
    {
        _isRotating = context.started || context.performed;
    }

    private void LateUpdate()
    {
        if (_isRotating)
        {
            transform.Rotate(new Vector3(_delta.y * _rotationSpeed, -_delta.x * _rotationSpeed, 0.0f));
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0.0f);
        }
    }
}
