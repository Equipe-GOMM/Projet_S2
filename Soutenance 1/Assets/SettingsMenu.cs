using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audiomixer;
    public TMP_Dropdown resdropdown;
    public Toggle vSyncToggle;

    Resolution[] resolutions;

    void Start ()
    {
        resolutions = Screen.resolutions;
       
        resdropdown.ClearOptions();
        
        List<string> options = new List<string>();
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.width && resolutions[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }
        
        resdropdown.AddOptions(options);
        resdropdown.value = currentResolutionIndex;
        resdropdown.RefreshShownValue();
    }
    public void SetVolume(float v)
    {
        audiomixer.SetFloat("Volume", v);
    }

    public void SetFullScreen(bool fs)
    {
        Screen.fullScreen = fs;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width,resolution.height,Screen.fullScreen);
    }
    public void SetQuality(int qualityI)
    {
        QualitySettings.SetQualityLevel(qualityI);
    }

    public void SetVsync()
    {
        if (vSyncToggle.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }
}
