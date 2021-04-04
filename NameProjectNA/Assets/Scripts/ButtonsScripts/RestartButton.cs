using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    Button restart;
    // Start is called before the first frame update
    void Start()
    {
        restart = GetComponent<Button>();
        restart.onClick.AddListener(RestartGame);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RestartGame()
    {
        SceneManager.LoadScene("Level1Scene");
    }
}
