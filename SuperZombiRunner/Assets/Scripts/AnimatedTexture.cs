using UnityEngine;
using System.Collections;

public class AnimatedTexture : MonoBehaviour {
    public Vector2 Speed = Vector2.zero;

    private Vector2 offset = Vector2.zero;
    private Material material;

    public void Start()
    {
        material = GetComponent<Renderer>().material;

        offset = material.GetTextureOffset("_MainTex");
    }

    public void Update()
    {
        offset += Speed * Time.deltaTime;

        material.SetTextureOffset("_MainTex", offset);
    }
}
