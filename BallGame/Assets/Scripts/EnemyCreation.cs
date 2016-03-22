using UnityEngine;
using System.Collections;

public class EnemyCreation : MonoBehaviour {

    public GameObject enemy;
    private int Count;
    private int enemyCount;
	// Use this for initialization
	void Start () {
	   Count = 0;
       enemyCount = 0;    
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 placement;
	   if((Count%2) == 0){
			placement = RandomPlacement ();
           if(enemyCount <= 100){
                Instantiate(enemy,placement,transform.rotation);
                enemyCount++;
           }
       }
        Count++;
	}
   
    public Vector3 RandomPlacement(){
        Random rnd = new Random();
        float x,y,z;
        Vector3 value;
		x = Random.Range(-45f, 45f);
        y =20f;
		z = Random.Range(-45f, 45f);
        value = new Vector3(x,y,z);
        return value;
	}
    
}
