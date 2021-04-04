using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    Button back;
    // Start is called before the first frame update
    void Start()
    {
        back = GetComponent<Button>();
        back.onClick.AddListener(GoBack);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void GoBack()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
