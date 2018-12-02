﻿// https://docs.unity3d.com/ScriptReference/WebCamTexture.Play.html
// Starts the default camera and assigns the texture to the current renderer
using UnityEngine;
using System.Collections;

public class unityWebcamtexture : MonoBehaviour
{
    void Start()
    {
        WebCamTexture webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }
}
