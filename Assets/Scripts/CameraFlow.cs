using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothSpeed = 5f;

    [Header("Limites do mapa")]
    [SerializeField] private Vector2 minPosition;
    [SerializeField] private Vector2 maxPosition;
    private void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position;
            desiredPosition.z = transform.position.z;

            desiredPosition.x = Mathf.Clamp(desiredPosition.x, minPosition.x, maxPosition.x);
            desiredPosition.y = Mathf.Clamp(desiredPosition.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, desiredPosition,smoothSpeed * Time.deltaTime);
        }
    }
}
