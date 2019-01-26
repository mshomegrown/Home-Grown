using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectCheck : MonoBehaviour
{
    // void Start()
    // {
    //     print("hello");
    // }
    public bool touched;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            AddTouch();
            print(touched);
        }
    }

    public void AddTouch()
    {
        touched = true;
    }
    // Update is called once per frame
    void Update()
    {

    }
}