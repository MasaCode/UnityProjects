using UnityEngine;
using System.Collections;

public class EnemyBehaive : MonoBehaviour {
    private float speed;
    private int Count;
    private Vector3 movement;
    

	// Use this for initialization
	void Start () {
        speed = Random.Range(-1.00f, 1.00f);
        Count = 100;
        movement = RandomMovement();
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Count == 100)
        {
            
            movement = RandomMovement();
            Count = 0;
        }
        movement = Check(movement);
        transform.Translate(movement.x*speed,0f,movement.z*speed);

        Count++;
	}

    private Vector3 Check(Vector3 place)
    {
        if (place.x >= 50f)
        {
            place.x = 48f;
        }
        else if (place.x <= -50f)
        {
            place.x = -48f;
        }

        if (place.z >= 50f)
        {
            place.z = 48f;
        }
        else if (place.z <= -50f)
        {
            place.z = -48f;
        }

        return place;
    }

    private Vector3 RandomMovement()
    {
        Vector3 values = new Vector3(Random.Range(-0.50f, 0.50f), 0f, Random.Range(-0.50f, 0.50f));
        return values;
    }

}
