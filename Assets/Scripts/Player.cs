using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float angle = CalcCursorAngle();
        animator.SetFloat("LookAngle", angle);
    }

    float CalcCursorAngle()
    {
        Camera cam = Camera.main;
        Vector2 cursorPosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerPosition = transform.position;
        Vector2 directionSource = cursorPosition - playerPosition;
        Vector2 direction = directionSource.normalized;
        float radAngle = Mathf.Atan2(direction.y, direction.x);
        float angle = Mathf.Rad2Deg * radAngle;
        angle = (angle > 0) ? angle : angle + 360;
        Debug.Log(angle);
        return angle;
    }
}
