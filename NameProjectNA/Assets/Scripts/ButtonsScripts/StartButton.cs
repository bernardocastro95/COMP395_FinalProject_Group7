using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    Button start;
    // Start is called before the first frame update
    void Start()
    {
        start = GetComponent<Button>();
        start.onClick.AddListener(startGame);
    }

    void startGame()
    {
        SceneManager.LoadScene("Level1Scene");
    }
}
