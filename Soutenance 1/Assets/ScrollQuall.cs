using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollQuall : MonoBehaviour
{
    
    public void SetQuality(int qualityI)
    {
        QualitySettings.SetQualityLevel(qualityI);
    }
    
    // Start is called before the first frame update
    /*void Start()
    {
        string[] qual = QualitySettings.names;
        slidequal.maxValue = qual.Length - 1;
        int quality = QualitySettings.GetQualityLevel();
        slidequal.value = quality;
        qualitytime.text = qual[quality];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
