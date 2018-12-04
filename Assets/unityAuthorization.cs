// https://docs.unity3d.com/ScriptReference/Application.RequestUserAuthorization.html

using UnityEngine;
// using UnityEngine.iOS;
using System.Collections;

// Show WebCams and Microphones on an iPhone/iPad.
// Make sure NSCameraUsageDescription and NSMicrophoneUsageDescription
// are in the Info.plist.

public class unityAuthorization : MonoBehaviour
{
    IEnumerator Start()
    {

        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            Debug.Log("webcam found");
        	findWebCams();
        }
        else
        {
            Debug.Log("webcam not found");
        }


        yield return Application.RequestUserAuthorization(UserAuthorization.Microphone);
        if (Application.HasUserAuthorization(UserAuthorization.Microphone))
        {
            Debug.Log("Microphone found");
        	findMicrophones();
        }
        else
        {
            Debug.Log("Microphone not found");
        }
    }

    void findWebCams()
    {
        foreach (var device in WebCamTexture.devices)
        {
            Debug.Log("Name: " + device.name);
        }
    }

    void findMicrophones()
    {
		// player did not compile?!

        // foreach (var device in Microphone.devices)
        // {
        //     Debug.Log("Name: " + device);
        // }
    }
}