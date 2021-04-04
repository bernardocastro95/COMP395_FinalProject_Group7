using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InstructionsButton : MonoBehaviour
{
    Button instructions;
    // Start is called before the first frame update
    void Start()
    {
        instructions = GetComponent<Button>();
        instructions.onClick.AddListener(howTo);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void howTo()
    {
        SceneManager.LoadScene("InstructionsScene");
    }
}
