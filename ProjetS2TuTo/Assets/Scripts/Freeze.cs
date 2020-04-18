using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    bool _isFrozen = false;
    private int seconds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_pendingFreezDuration < 0 && !_isFrozen)
        {
            StartCoroutine("DoFreeze");
        }
    }

    float _pendingFreezDuration = 0f;

    public void Freezer()
    {
        _pendingFreezDuration = seconds;
    }

    IEnumerator DoFreeze()
    {
        _isFrozen = true;
        var original = Time.timeScale;
        Time.timeScale = 0f;

        yield return new WaitForSecondsRealtime(seconds);
        Time.timeScale = original;
        _pendingFreezDuration = 0f;
        _isFrozen = false;
    }
}
