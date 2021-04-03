using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsButton : MonoBehaviour
{
    Button setting;
    // Start is called before the first frame update
    void Start()
    {
        setting = GetComponent<Button>();
        setting.onClick.AddListener(settings);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void settings()
    {
        SceneManager.LoadScene("SettingScene");
    }
}
