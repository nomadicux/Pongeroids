using UnityEngine;
using System.Collections;

public class Ball_2 : MonoBehaviour {


    public float ballInitialVelocity = 300f;

    private Rigidbody2D rb;
    private float constantSpeed = 10.0f;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(ballInitialVelocity, ballInitialVelocity));

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 unit = GetComponent<Rigidbody2D>().velocity.normalized;
        GetComponent<Rigidbody2D>().velocity = unit * constantSpeed;

    }

}
