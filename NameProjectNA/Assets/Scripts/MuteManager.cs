using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteManager : MonoBehaviour
{
    private bool mute;
    // Start is called before the first frame update
    void Start()
    {
        mute = false;
    }

    // Update is called once per frame
    void Update()
    {
        mute = !mute;

    }
}
