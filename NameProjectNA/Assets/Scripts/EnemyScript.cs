using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public Transform player;
    public float speed = 3f;
    Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        rbody.MovePosition(position);
        transform.LookAt(player);
    }
}
