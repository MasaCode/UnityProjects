using UnityEngine;
using System.Collections;

public class TimeManager : MonoBehaviour {

    public void ManipulateTime(float newTime, float duration)
    {
        if (Time.timeScale == 0)
            Time.timeScale = 0.1f;

        StartCoroutine(FadeTo(newTime,duration));
    }

    IEnumerator FadeTo(float value, float time)
    {
        for (float t = 0f; t < 1f; t += Time.deltaTime / time)
        {
            Time.timeScale = Mathf.Lerp(Time.timeScale, value, t);

            if (Mathf.Abs(value - Time.timeScale) < 0.01f)
            {
                Time.timeScale = value;
                
                //yield return false; //TODO : I need to think about how it work.....
                                //But So far it seems like working good.
            }

            yield return null;
        }
    }
}
