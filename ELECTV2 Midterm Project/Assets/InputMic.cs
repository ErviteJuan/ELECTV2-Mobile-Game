using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMic : MonoBehaviour
{
    public PlayerController Player;
    string CurrentMic = string.Empty;
    AudioClip micInput;
    float[] waveData;

    void Start()
    {
        if (Microphone.devices.Length > 0)
        {
            CurrentMic = Microphone.devices[0];
        }
        if (CurrentMic != string.Empty)
        {
            micInput = Microphone.Start(CurrentMic, true, 300, 48000);
        }
    }

    void Update()
    {
        if (CurrentMic == string.Empty)
            return;
        int dec = 128; //power 2
        waveData = new float[dec];
        int micPosition = Microphone.GetPosition(null) - (dec + 1);
        micInput.GetData(waveData, micPosition);

        float _lvl = waveData[waveData.Length - 1] * waveData[waveData.Length - 1];
        float _sqLvl = Mathf.Sqrt(Mathf.Sqrt(_lvl));
        float _sensitivity = _sqLvl * 5;

        if (_sensitivity > 2)
        {
            Player.PlayerUp();
        }
    }
}
