using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseSen : MonoBehaviour
{
    public Slider slider_x;
    public Slider slider_y;
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string xPref = "xPref";
    private static readonly string yPref = "yPref";
    private int firstPlayInt;
    private float xFloat;
    private float yFloat;
    public Look look;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0)
        {
            xFloat = 1f;
            yFloat = 1f;
            PlayerPrefs.SetFloat(xPref, xFloat);
            PlayerPrefs.SetFloat(yPref, yFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
            slider_x.value = xFloat;
            slider_y.value = yFloat;
            look.xSensitivity = slider_x.value;
            look.ySensitivity = slider_y.value;
        }
        else
        {
            xFloat = PlayerPrefs.GetFloat(xPref);
            slider_x.value = xFloat;
            yFloat = PlayerPrefs.GetFloat(yPref);
            slider_y.value = yFloat;
            look.xSensitivity = slider_x.value;
            look.ySensitivity = slider_y.value;
        }
    }

    public void SaveSoundSettings()
    {
        PlayerPrefs.SetFloat(xPref, slider_x.value);
        PlayerPrefs.SetFloat(yPref, slider_y.value);
    }

    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSettings();
        }
    }

    public void UpdateSound()
    {
        look.xSensitivity = slider_x.value;
        look.ySensitivity = slider_y.value;
    }
}
