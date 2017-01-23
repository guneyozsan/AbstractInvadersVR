using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;  // Needed for Math

public class AudioGenerator : MonoBehaviour
{
    public Transform parameterSource;

    // un-optimized version
    public double frequencyX = 440;
    public double frequencyY = 440;
    public float baseFrequency = 400;
    public double gain = 0.05;

    private double incrementX;
    private double incrementY;
    private double phaseX;
    private double phaseY;
    private double sampling_frequency = 48000;

    void OnAudioFilterRead(float[] data, int channels)
    {
        
        // update increment in case frequency has changed
        incrementX = frequencyX * 2 * Math.PI / sampling_frequency;
        incrementY = frequencyY * 2 * Math.PI / sampling_frequency;
        for (var i = 0; i < data.Length; i = i + channels)
        {
            phaseX = phaseX + incrementX;
            phaseY = phaseY + incrementY;
            // this is where we copy audio data to make them “available” to Unity
            data[i] = (float)(gain * Math.Sin(phaseX));
            data[i + 1] = (float)(gain * Math.Sin(phaseY));
            //Debug.Log(data[i] + " " + data[i + 1]);
            // if we have stereo, we copy the mono data to each channel
            //if (channels == 2) data[i + 1] = data[i];
            if (phaseX > 2 * Math.PI) phaseX = 0;
            if (phaseY > 2 * Math.PI) phaseY = 0;
        }
    }

    void Update()
    {
        
        frequencyX = parameterSource.position.x * 20 + baseFrequency;
        frequencyY = parameterSource.position.y * 20 + baseFrequency;
    }
}