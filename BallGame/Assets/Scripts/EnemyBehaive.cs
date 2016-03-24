using UnityEngine;
using System.Collections;

public class EnemyBehaive : MonoBehaviour {
    private float speedZ,speedX;
    private int Count;
    private Vector3 movement;
    

	// Use this for initialization
	void Start () {
        speedZ = Random.Range(-0.50f, 0.50f);
        speedX = Random.Range(-0.50f, 0.50f);
        Count = 100;
        
	}

   

	// Update is called once per frame
	void FixedUpdate () {
        if (Count == 100)
        {
            
            movement = RandomMovement();
            Count = 0;
        }
        movement = Check(movement);
        transform.position = new Vector3(movement.x + speedX,movement.y, movement.z + speedZ);
        Count++;
	}

    private Vector3 Check(Vector3 place)
    {
        Vector3 value;
        if (place.x >= 50f)
        {
            place.x = 48f;
            speedX = -speedX;
        }
        else if (place.x <= -50f)
        {
            place.x = -48f;
            speedX = -speedX;
        }

        if (place.z >= 50f)
        {
            place.z = 48f;
            speedZ = -speedZ;
        }
        else if (place.z <= -50f)
        {
            place.z = -48f;
            speedZ = -speedZ;
        }

        return place;
    }

    private Vector3 RandomMovement()
    {
        Vector3 values = new Vector3(transform.position.x + Random.Range(-0.50f, 0.50f), 0f, transform.position.z + Random.Range(-0.50f, 0.50f));
        return values;
    }

}
