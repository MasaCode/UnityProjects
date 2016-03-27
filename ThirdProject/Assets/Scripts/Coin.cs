using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

    [SerializeField]
    private float rotateSpeed = 1.0f;
    [SerializeField]
    private float floatSpeed = 0.5f;
    [SerializeField]
    private float movementDistance = 0.5f;

    private float StartingPositionY;
    private bool isMovingUp = true;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            Pickup();
        }
    }

	// Use this for initialization
	void Start () {
        StartingPositionY = transform.position.y;
        transform.Rotate(transform.up, Random.Range(0f, 360));
    }

    void Update()
    {
        Spin();
        CoinMovement();
    }

    private void Pickup()
    {
        GameManage.Instance.CoinNumber++;
        Destroy(gameObject);
    }

    private void Spin()
    {
        
        transform.Rotate(transform.up,360*rotateSpeed*Time.deltaTime);
        return;
    }

    private void CoinMovement()
    {
        
            float NewPositionY = transform.position.y + (isMovingUp ? 1 : -1) * 2 * movementDistance * floatSpeed * Time.deltaTime;

            if (NewPositionY > StartingPositionY + movementDistance)
            {
                NewPositionY = StartingPositionY + movementDistance;
                isMovingUp = false;
            }else if(NewPositionY < StartingPositionY){
                NewPositionY = StartingPositionY;
                isMovingUp = true;
            }
            transform.position = new Vector3(transform.position.x, NewPositionY, transform.position.z);
            return;
    }

}
