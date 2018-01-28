using UnityEngine;

public class RenderUtils : MonoBehaviour {
    /// <summary>
    /// This method receives an Unity object and RGB values to tint an object. 
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    /// <param name="red">Red channel value (from 0  to 1)</param>
    /// <param name="green">Green channel value (from 0  to 1)</param>
    /// <param name="blue">Blue channel value (from 0  to 1)</param>
    public static void ColorizeObject(Renderer unityEntity, float red, float green, float blue) {
        unityEntity.material.color = new Color(red, green, blue);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into Red.
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeRed(Renderer unityEntity) {
        ColorizeObject(unityEntity, 1, 0, 0);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into a light red.
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeLightRed(Renderer unityEntity) {
        ColorizeObject(unityEntity, 1, 0.5f, 0.5f);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into Blue.
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeBlue(Renderer unityEntity)
    {
        ColorizeObject(unityEntity, 0, 0, 1);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into light blue (cyan).
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeLightBlue(Renderer unityEntity)
    {
        ColorizeObject(unityEntity, 0.5f, 0.5f, 1);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into Green.
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeGreen(Renderer unityEntity)
    {
        ColorizeObject(unityEntity, 0, 1, 0);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into light green (lime).
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeLightGreen(Renderer unityEntity)
    {
        ColorizeObject(unityEntity, 0.5f, 1, 0.5f);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into Yellow.
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeYellow(Renderer unityEntity)
    {
        ColorizeObject(unityEntity, 1, 1, 0);
    }

    /// <summary>
    /// Tints a Unity GameObject mesh into light yellow (cream).
    /// </summary>
    /// <param name="unityEntity">A mesh renderer component of a Unity GameObject</param>
    public static void ColorizeLightYellow(Renderer unityEntity)
    {
        ColorizeObject(unityEntity, 1, 1, 0.5f);
    }
}
