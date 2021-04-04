using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public GameObject toggle;
    // Start is called before the first frame update
    void Start()
    {
        if (toggle.GetComponent<Toggle>().isOn)
        {
            print("Game is muted");
        }
        else
        {
            print("Game is not muted");
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
