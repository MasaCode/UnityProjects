using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    public GameObject[] prefabs;
    public bool active = true;
    public Vector2  delayRange = new Vector2(1,2); //Minimum is 1 (x) and Maximan is 2 (y)

    private float delay;

    public void Start()
    {
        StartCoroutine(EnemyGenerator());
        ResetDelay();
    }

    IEnumerator EnemyGenerator()
    {
        yield return new WaitForSeconds(delay);

        if (active)
        {
            var _transform = transform;
            GameObjectUtil.Instantiate(prefabs[Random.Range(0, prefabs.Length)],_transform.position);
            ResetDelay();
        }

        StartCoroutine(EnemyGenerator());
    }

    private void ResetDelay()
    {
        delay = Random.Range(delayRange.x, delayRange.y);
    }
}
