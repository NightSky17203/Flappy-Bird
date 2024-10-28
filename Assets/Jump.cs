using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    // Start is called before the first frame update
    public float flaps;
    public Rigidbody2D body;
    public LogicScript Logic;
    public bool bird =true;
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("LogicScrpt").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && bird)
        {
            body.velocity = Vector2.up * flaps;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.Gameover();
        bird= false;
    }

}
