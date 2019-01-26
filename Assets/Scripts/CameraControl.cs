using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    [SerializeField] float speed = 2f;

    Transform startLerp;
    Transform endLerp;

    bool moving;

    float startTime;
    float distance;

	
	// Update is called once per frame
	void Update () {
        if (moving)
        {
            float distanceCovered = (Time.time - startTime) * speed;
            float fracJourney = distanceCovered / distance;

            transform.position = Vector3.Lerp(startLerp.position, endLerp.position, fracJourney);
            if (transform.position == endLerp.position)
            {
                moving = false;
            }
        }
	}

    public void Lerper(Transform start, Transform end)
    {
        startLerp = start;
        endLerp = end;
        moving = true;
        startTime = Time.time;
        distance = Vector3.Distance(start.position, end.position);
    }
}
