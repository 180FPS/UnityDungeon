using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2.5f;
    public bool canMove = true;
    public void SetMovement(bool canMove)
    {
        this.canMove = canMove;
    }

    /// <summary>
    /// Sets the player movement using a GamePad.    
    /// </summary>
    private void ControllerMovement()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(0, 0, z);
        transform.Rotate(0, x * 150, 0);
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
            transform.position = new Vector3(-3.08f, -0.62f, -5.12f);
        }
    }
}