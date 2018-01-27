using UnityEngine;
using System.Collections;
/// <summary>
/// Utils class that allows the use of common analityc geometry formulas.
/// </summary>
public class GeometryUtils {
    private GeometryUtils() {
        // Hide this constructor.
    }

    /// <summary>
    /// Returns the float value of the distance between two objects.
    /// </summary>
    /// <param name="x1">The x position of the object calling this method.</param>
    /// <param name="x2">The x position of the object to compare to.</param>
    /// <param name="y1">The y position of the object calling this method.</param>
    /// <param name="y2">The y position of the object to compare to.</param>
    /// <returns>The float value of the distance.</returns>
    public static float DistanceBetweenPoints(float x1, float x2, float y1, float y2) {
        return Mathf.Sqrt(Mathf.Pow(x2 - x1, 2) + Mathf.Pow(y2 - y1, 2));
    }
}
