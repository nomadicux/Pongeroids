using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{

    public float ballInitialVelocity = 300f;

    private Rigidbody2D rb;
    private bool ballInPlay;

    // Use this for initialization
    void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(ballInitialVelocity, ballInitialVelocity));

    }

    // Update is called once per frame
    void Update()
    {
      /**  if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector2(ballInitialVelocity, ballInitialVelocity));
        }**/
    }

    void FixedUpdate()
    {
        rb.AddForce(new Vector2(ballInitialVelocity, ballInitialVelocity));
    }
}
