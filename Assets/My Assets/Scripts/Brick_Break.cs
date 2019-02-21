using UnityEngine;
using System.Collections;

public class Brick_Break : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Wall")
        {
            Destroy(col.gameObject);
        }
    }
}
