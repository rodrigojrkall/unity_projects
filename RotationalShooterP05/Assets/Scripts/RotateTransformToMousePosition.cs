using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTransformToMousePosition : MonoBehaviour
{
    public float angleOffSet = 30.0f;

    void Start()
    {

    }

    void Update()
    {
        rotateToMousePostion();
    }

    void rotateToMousePostion()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
        float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);

        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle - angleOffSet));
    }

    float AngleBetweenPoints(Vector2 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
