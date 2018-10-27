using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private const float SPEED = 4.0f;

    private void Update()
    {
        float translationX = Input.GetAxis("Horizontal") * Time.deltaTime * SPEED;
        float translationY = Input.GetAxis("Vertical") * Time.deltaTime * SPEED;

        transform.Translate(translationX, translationY, 0);
    }
}
