using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D player;
    public float moveForce;

    // Start is called before the first frame update
    void Start()
    {

    }
// Update is called once per frame
void Update()
    {
        if(Input.GetKey(KeyCode.A)) {
            player.AddForce(Vector2.left * moveForce);
        }

        if (Input.GetKey(KeyCode.D)) {
            player.AddForce(Vector2.right * moveForce);
        }
    }}
