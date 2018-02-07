using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;
    public bool canMove = true;
    public void SetMovement(bool canMove)
    {
        this.canMove = canMove;
    }

    /// <summary>
    /// Sets the player movement using a GamePad.    
    /// </summary>
    protected void ControllerMovement()
    {
        // Retrieve the current values for the left axis.
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        // Move the player in the angle of the two axis.
        Vector3 moveDirection = new Vector3(x, 0, +z);
        transform.position += moveDirection * speed * Time.deltaTime;
        
        // Rotate the player to the axis angle.
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) // Prevent the player rotation if one of the axis is zero.
        {
            Vector3 moveAngle = new Vector3(0, 45, +0); // Rotate the player from its Y axis.
            float angle = Mathf.Atan2(x, z) * Mathf.Rad2Deg; // Obtain the tangent of the angle.
            transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0)); // Rotate the player.
        }
    }

    private void Update()
    {
        if (canMove)
        {
            ControllerMovement();
        }
        FallOff();
    }

    private void FallOff()
    {
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(0f, 0f, 0f);
        }
    }
}