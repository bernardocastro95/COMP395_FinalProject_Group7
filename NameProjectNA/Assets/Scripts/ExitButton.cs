using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    Button exit;
    // Start is called before the first frame update
    void Start()
    {
        exit = GetComponent<Button>();
        exit.onClick.AddListener(exitGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void exitGame()
    {
        Debug.Log("Exiting Button has been clicked");
        Application.Quit();
    }
}
