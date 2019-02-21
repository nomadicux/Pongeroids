using UnityEngine;
using System.Collections;

public class Enemy_AI : MonoBehaviour {

    public Game_Manager gameManager;
    public Transform target;
    public float speed = 2f;
    private float minDistance = 1f;
    private float range;
    void Update()
    {
        range = Vector2.Distance(transform.position, target.position);

        if (range > minDistance)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            Destroy(target.gameObject);
            gameManager.gameOn = false; //Changes the gameManagers on state for false so that the game restarts.
        }
    }
}
