using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class DestroyOffscreenObject : MonoBehaviour
{
    public delegate void OnDestroy();
    public event OnDestroy DestroyCallback;
    
    public float offset = 16f;

    private bool offScreen;
    private float offScreenX;
    private Rigidbody2D body2d;

    public void Awake()
    {
        body2d = GetComponent<Rigidbody2D>();
        offScreenX = 0;
    }

    public void Start()
    {
        offScreenX = (Screen.width / PixelPerfectCamera.PixelsToUnits) / 2 + offset;
    }

    public void Update()
    {
        var posX = transform.position.x;
        var dirX = body2d.velocity.x;

        if (Mathf.Abs(posX) > offScreenX)
        {
            if (dirX < 0 && posX < -offScreenX)
                offScreen = true;
            else if (dirX > 0 && posX > offScreenX)
                offScreen = true;
        }
        else
            offScreen = false;


        if (offScreen)
            OnOutOfBounds();
    }

    private void OnOutOfBounds()
    {
        offScreen = false;
        GameObjectUtil.Destroy(gameObject);

        if (DestroyCallback != null)
            DestroyCallback();
    }
}

