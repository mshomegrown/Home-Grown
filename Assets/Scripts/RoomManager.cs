using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour {

    [SerializeField] GameObject firstObject;
    [SerializeField] GameObject secondObject;
    [SerializeField] GameObject thirdObject;

    [SerializeField] GameObject toEnable;
    [SerializeField] GameObject toDisable;

    [SerializeField] GameObject cameraTransform;
    [SerializeField] Transform cameraEnd;
    [SerializeField] GameObject playerTransform;
    [SerializeField] Transform playerEnd;

    [SerializeField] int trackNumber;

    bool actions = false;


    bool first = false;
    bool second = false;
    bool third = false;

    void Update ()
    {
        CheckSelected();
		Enablers();
    }

    private void Enablers()
    {
        if (first && second && third && !actions)
        {
            actions = true;
            toEnable.SetActive(true);
            toDisable.SetActive(false);
            playerTransform.GetComponent<LightControl>().Lerper(playerTransform.transform,playerEnd);
            playerTransform.GetComponent<LightControl>().Tracker(trackNumber);
            cameraTransform.GetComponent<CameraControl>().Lerper(cameraTransform.transform,cameraEnd);

        }
    }

    private void CheckSelected()
    {
        if (!first)
        {
            first = firstObject.GetComponent<objectCheck>().touched;
        }

        if (!second)
        {
            second = secondObject.GetComponent<objectCheck>().touched;
        }

        if (!third)
        {
            third = thirdObject.GetComponent<objectCheck>().touched;
        }
    }
}
