using UnityEngine;
using System.Collections;

public class Player_Movement_2 : MonoBehaviour
{

    public float speed = 1.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;

        if (Input.GetButtonDown("left"))
            RotateLeft();
        else if (Input.GetButtonDown("right"))
            RotateRight();
    }

    void RotateLeft()
    {
        transform.Rotate(Vector3.forward * -90);
    }

    void RotateRight()
    {
        transform.Rotate(Vector3.forward * 90);
    }



}
