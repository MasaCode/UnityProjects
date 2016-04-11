using UnityEngine;
using System.Collections;

public class PixelPerfectCamera : MonoBehaviour {

    public static float PixelsToUnits = 1f;
    public static float scale = 1f;
    public Vector2 nativeResolution = new Vector2(240, 160);

    public void Awake()
    {
        var _camera = GetComponent<Camera>();
        if (!_camera.orthographic) return; // the Camera is not set as Orthographic mode, it dose not do anything.

        scale = Screen.height / nativeResolution.y;
        PixelsToUnits *= scale;
        _camera.orthographicSize = (Screen.height / 2.00f) / PixelsToUnits;

        /*
        Debug.Log("Scale : " + scale);
        Debug.Log("PixelsToUnits : " + PixelsToUnits);
        Debug.Log("Screen height : " + Screen.height);
        Debug.Log("Screen.height / 2 : " + Screen.height / 2.00f);
        */
        
    }
}
