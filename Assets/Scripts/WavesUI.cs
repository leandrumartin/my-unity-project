using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WavesUI : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        WaveManager.instance.onChanged.AddListener(RefreshText);
    }

    void RefreshText()
    {
        text.text = "Remaining Waves: " + WaveManager.instance.waves.Count;
    }
}
