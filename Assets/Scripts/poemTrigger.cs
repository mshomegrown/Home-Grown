using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class poemTrigger : MonoBehaviour
{
    public GameObject uiObject;
    [SerializeField] List<string> inputText = new List<string>();
    // Start is called before the first frame update
    string text;
    void Start()
    {
        foreach (var line in inputText) {
            text += line + "\n";
        }
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            uiObject.SetActive(true);
            print(text);
            uiObject.GetComponent<Text>().text = text;
            //StartCoroutine("WaitForSec");
        }
    }

    //IEnumerator WaitForSec()
    //{
    //    yield return new WaitForSeconds(30);
    //    uiObject.SetActive(false);
    //}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump")){
            uiObject.SetActive(false);
        }
    }
}