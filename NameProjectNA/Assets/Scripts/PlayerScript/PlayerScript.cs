using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject player;
    public float speed = 5f;
    private Rigidbody characterRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<GameObject>();
        characterRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        // -1 ~ 1

        Vector3 velocity = new Vector3(inputX, 0, inputZ);
        velocity *= speed;
        characterRigidbody.velocity = velocity;
    }
}
