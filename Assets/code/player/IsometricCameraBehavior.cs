using UnityEngine;

/// <summary>
/// Positions a Camera object to the coordenates of a given GameObject.
/// The camera must be rotated 30 degrees in the X angle and multipliers of 45 angles in the y Axis.
/// </summary>
public class IsometricCameraBehavior : MonoBehaviour {
    public GameObject player;
    public float offsetX = -4;
    public float offsetZ = -4;
    public float maximumDistance = 2;
    public float playerVelocity = 10;
    private float movementX;
    private float movementZ;   
	
	/// <summary>
    /// This method is called every frame update.
    /// </summary>
	void Update () {
        movementX = ((player.transform.position.x + offsetX - this.transform.position.x)) / maximumDistance;
        movementZ = ((player.transform.position.z + offsetZ - this.transform.position.z)) / maximumDistance;
        this.transform.position += new Vector3(movementX * playerVelocity * Time.deltaTime, 0, movementZ * playerVelocity * Time.deltaTime);
	}
}
