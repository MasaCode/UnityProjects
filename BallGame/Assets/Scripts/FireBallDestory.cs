using UnityEngine;
using System.Collections;

public class FireBallDestory : MonoBehaviour {

    private Vector3 place;
    private bool isDestoryed = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        place = transform.position;
        if (!isDestoryed)
        {
            if (place.x <= -70f)
            {
                Destroy(gameObject);
                isDestoryed = true;
            }
            else if (place.x >= 70f)
            {
                Destroy(gameObject);
                isDestoryed = true;
            }
        }

        if (!isDestoryed)
        {
            if(place.z <= -70f){
                Destroy(gameObject);
                isDestoryed = true;
            }
            else if (place.z >= 70f)
            {
                Destroy(gameObject);
                isDestoryed = true;
            }

            if (GameManager.Instance.Health <= 0)
            {
                Destroy(gameObject);
                isDestoryed = true;
            }

        }

	}
}
