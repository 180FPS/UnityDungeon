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
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        Vector3 moveDirection = new Vector3(x, 0, +z);
        transform.position += moveDirection * speed * Time.deltaTime;
        
        if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Vector3 moveAngle = new Vector3(0, 45, +0);
            float angle = Mathf.Atan2(x, z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
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