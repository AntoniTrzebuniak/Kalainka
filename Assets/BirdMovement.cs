using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Birdbody;
    public float jumpHeight = 5;
    Vector2 v = new Vector2(0f, 1f);
    public LogicScript logic;
    public bool IsBirdAlive = true;

    void Start()
    {
        gameObject.name = "Bob";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsBirdAlive)
        {
            Birdbody.velocity = v * jumpHeight;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        IsBirdAlive = false;
    }
}
