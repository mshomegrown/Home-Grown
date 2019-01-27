using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {

    float moveX;
    float moveZ;

    AudioSource audioSource;
    [SerializeField] List<AudioClip> tracks = new List<AudioClip>();

    [SerializeField] float speed = 2f;
    [SerializeField] float lerpSpeed = 1f;

    Transform startLerp;
    Transform endLerp;

    bool moving;

    float startTime;
    float distance;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(tracks[0]);
    }

    // Update is called once per frame
    void Update () {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");
        transform.position = transform.position + new Vector3(-moveX * speed, 0, -moveZ * speed) * Time.deltaTime;

        if(moving){
            float distanceCovered = (Time.time - startTime) * lerpSpeed;
            float fracJourney = distanceCovered / distance;

            transform.position = Vector3.Lerp(startLerp.position, endLerp.position, fracJourney);
            if(transform.position == endLerp.position) {
                moving = false;
            }
        }
	}

    public void Tracker (int trackNumber) {
        audioSource.Stop();
        audioSource.PlayOneShot(tracks[trackNumber]);
    }

    public void Lerper (Transform start, Transform end) {
		startLerp = start;
		endLerp = end;
        moving = true;
        startTime = Time.time;
        distance = Vector3.Distance(start.position, end.position);
    }
}
