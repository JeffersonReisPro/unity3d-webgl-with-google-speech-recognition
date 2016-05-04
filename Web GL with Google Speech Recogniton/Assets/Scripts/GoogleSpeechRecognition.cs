using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoogleSpeechRecognition : MonoBehaviour {

    public Text text;
    private string myResponse = "...";

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = myResponse;
    }


    /// <summary>
    /// The browser sends the result of speech recognition in this role.
    /// </summary>
    /// <param name="result"> result of speech recognition </param>
    public void GetResponse(string result)
    {
        myResponse = result;
    }

    /// <summary>
    /// Start speech recognition in the browser
    /// </summary>
    public void StartSpeechRecognitionInTheBrowser()
    {
        Application.ExternalCall("startButtonFromUnity3D");
    }



}
