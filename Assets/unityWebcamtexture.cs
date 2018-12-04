// https://docs.unity3d.com/ScriptReference/WebCamTexture.Play.html
// Starts the default camera and assigns the texture to the current renderer
using UnityEngine;
using System.Collections;

public class unityWebcamtexture : MonoBehaviour
{
	public WebCamTexture webcamTexture;

	public int index = 0;
    void Start()
    {
		WebCamDevice[] devices = WebCamTexture.devices;
        if (devices.Length > 0)
        {
			webcamTexture = new WebCamTexture();
            webcamTexture.deviceName = devices[index % devices.Length].name; // last
            webcamTexture.Play();

			Renderer renderer = GetComponent<Renderer>();
			renderer.material.mainTexture = webcamTexture;
        }
    }
}
