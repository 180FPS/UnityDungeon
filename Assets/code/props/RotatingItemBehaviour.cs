using UnityEngine;
/// <summary>
/// Rotates a GameObject into its Y axis.
/// </summary>
public class RotatingItemBehavior : MonoBehaviour {
    private void Update()
    {
        transform.Rotate(0, 60 * Time.deltaTime, 0);
	}
}
