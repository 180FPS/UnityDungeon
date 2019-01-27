using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public bool canMove = true;
    public bool isIsometric = true;

    /// <summary>
    /// Sets the movement state of the player
    /// </summary>
    /// <param name="canMove">Whether the player can move or not</param>
    public void SetMovement(bool canMove)
    {
        this.canMove = canMove;
    }

    /// <summary>
    /// Sets the player movement using a GamePad.   
    /// When in isometric perspective we use IsometricMovement,
    /// when in rectangular perspective we use  HorizontalMovement
    /// </summary>
    protected void ControllerMovement()
    {
        if (isIsometric)
        {
            IsometricMovement();
        }
        else
        {
            HorizontalMovement();
        }

    }

    /// <summary>
    /// Moves the player when using isometric perspective.
    /// </summary>
    private void IsometricMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float inputAngle = Mathf.Atan2(verticalInput, horizontalInput);

        float scaleX = Mathf.Cos(inputAngle) * Mathf.Sign(horizontalInput);
        float scaleZ = Mathf.Sin(inputAngle) * Mathf.Sign(verticalInput);

        float x = horizontalInput * Time.deltaTime * speed * scaleX;
        float z = verticalInput * Time.deltaTime * speed * scaleZ;

        var realX = x * Mathf.Cos(45 * Mathf.Deg2Rad) + z * Mathf.Cos(135 * Mathf.Deg2Rad);
        var realZ = x * Mathf.Sin(45 * Mathf.Deg2Rad) + z * Mathf.Sin(135 * Mathf.Deg2Rad);

        Vector3 moveDirection = new Vector3(realX, 0, realZ);
        transform.position += moveDirection * speed * Time.deltaTime;

        if (horizontalInput != 0 || verticalInput != 0)
        {
            float angle = Mathf.Atan2(realX, realZ) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
        }
    }

    /// <summary>
    /// Moves the player when using rectangular perspective
    /// </summary>
    private void HorizontalMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        float inputAngle = Mathf.Atan2(verticalInput, horizontalInput);

        float scaleX = Mathf.Cos(inputAngle) * Mathf.Sign(horizontalInput);
        float scaleZ = Mathf.Sin(inputAngle) * Mathf.Sign(verticalInput);

        float x = horizontalInput * Time.deltaTime * speed * scaleX;
        float z = verticalInput * Time.deltaTime * speed * scaleZ;

        Vector3 moveDirection = new Vector3(x, 0, +z);
        transform.position += moveDirection * speed * Time.deltaTime;

        if (horizontalInput != 0 || verticalInput != 0)
        {
            float angle = Mathf.Atan2(x, z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
        }
    }

    /// <summary>
    /// Updates the player
    /// </summary>
    private void Update()
    {
        if (canMove)
        {
            ControllerMovement();
        }
        FallOff();
    }

    /// <summary>
    /// Handles fall scenario
    /// </summary>
    private void FallOff()
    {
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}