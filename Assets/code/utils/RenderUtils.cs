using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderUtils : MonoBehaviour {
    /**
     * This method receives an Unity object and RGB values to tint an object. 
     **/
    public static void colorizeObject(Renderer unityEntity, float red, float green, float blue) {
        unityEntity.material.color = new Color(red, green, blue);
    }

    public static void colorizeRed(Renderer unityEntity) {
        colorizeObject(unityEntity, 1, 0, 0);
    }

    public static void colorizeLightRed(Renderer unityEntity) {
        colorizeObject(unityEntity, 1, 0.5f, 0.5f);
    }

    public static void colorizeBlue(Renderer unityEntity)
    {
        colorizeObject(unityEntity, 0, 0, 1);
    }

    public static void colorizeLightBlue(Renderer unityEntity)
    {
        colorizeObject(unityEntity, 0.5f, 0.5f, 1);
    }

    public static void colorizeGreen(Renderer unityEntity)
    {
        colorizeObject(unityEntity, 0, 1, 0);
    }

    public static void colorizeLightGreen(Renderer unityEntity)
    {
        colorizeObject(unityEntity, 0.5f, 1, 0.5f);
    }

    public static void colorizeYellow(Renderer unityEntity)
    {
        colorizeObject(unityEntity, 1, 1, 0);
    }

    public static void colorizeLightYellow(Renderer unityEntity)
    {
        colorizeObject(unityEntity, 1, 1, 0.5f);
    }
}
