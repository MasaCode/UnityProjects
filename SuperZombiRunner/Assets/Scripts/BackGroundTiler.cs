using UnityEngine;
using System.Collections;

public class BackGroundTiler : MonoBehaviour {
    public int textureSize = 32;
    public bool scaleHorizontally = true;
    public bool scaleVertically = true;


    public void Start()
    {
        var Width = scaleHorizontally ? Mathf.Ceil(Screen.width / (textureSize * PixelPerfectCamera.scale)) : 1;
        var Height = scaleVertically ? Mathf.Ceil(Screen.height / (textureSize * PixelPerfectCamera.scale)) : 1;

        transform.localScale = new Vector3(Width * textureSize, Height * textureSize, 1);

        GetComponent<Renderer>().material.mainTextureScale = new Vector3(Width, Height, 1);
    }
}
