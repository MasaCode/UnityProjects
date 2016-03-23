using UnityEngine;
using System.Collections;

public class EnemyCreation : MonoBehaviour {

    public GameObject enemy;
    private int enemyCount;
	// Use this for initialization
	void Start () {
       enemyCount = 0;    
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 placement;
           if(enemyCount <= 10){
               placement = RandomPlacement();
               Instantiate(enemy,placement,transform.rotation);
               enemyCount++;
           }
	}
   
    public Vector3 RandomPlacement(){
        Random rnd = new Random();
        float x,y,z;
        Vector3 value;
		x = Random.Range(-45f, 45f);
        y =3f;
		z = Random.Range(-45f, 45f);
        value = new Vector3(x,y,z);
        return value;
	}
    
}
