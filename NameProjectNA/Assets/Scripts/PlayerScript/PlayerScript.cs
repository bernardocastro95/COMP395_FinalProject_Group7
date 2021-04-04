using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject player;
    public float playerSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        float northSouth = Input.GetAxis("Vertical") * playerSpeed;
        float westEast = Input.GetAxis("Horizontal") * playerSpeed;
    }
}
