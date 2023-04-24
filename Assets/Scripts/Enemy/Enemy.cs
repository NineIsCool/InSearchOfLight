using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public int health;

    public float positionPatrol;
    public Transform point;
    public bool movingRight = true;

    public float stoppingDistance;

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public int damage;

    private float stopTime;
    public float startStopTime;
    public float normalSpeed;

    Transform player;
    private Rigidbody2D rb;
    private Animator anim;
    private Player gamePlayer;

    private bool chill = false;
    private bool angry = false;
    private bool goBack = false;


    void Start()
    {
        gamePlayer = FindObjectOfType<Player>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        normalSpeed = speed;
    }

    void Update()
    {
        if (stopTime <= 0)
        {
            speed = normalSpeed;
        }
        else
        {
            speed = 0;
            stopTime -= Time.deltaTime;
        }

        if (health <= 0)
        {
            Die();
            Destroy(gameObject);
        }
        if (Vector2.Distance(transform.position, point.position) < positionPatrol && angry == false)
        {
            chill = true;
        }

        if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position)!=0)
        {
            angry = true;
            chill = false;
            goBack = false;
        }

        if (Vector2.Distance(transform.position, player.position) > stoppingDistance || Vector2.Distance(transform.position, player.position) == 0)
        {
            goBack = true;
            angry = false;
        }

        

        if (chill)
        {
            Chill();
        }
        else if (angry)
        {
            Angry();
        }
        else if (goBack)
        {
            GoBack();
        }
    }

    void Chill()
    {
        if (transform.position.x > point.position.x + positionPatrol)//�����
        {
            if (transform.localScale.x > 0) transform.localScale = new Vector2(-0.4f, 0.4f);
            movingRight = false;
        }
        else if (transform.position.x < point.position.x - positionPatrol)
        {
            if (transform.localScale.x < 0) transform.localScale = new Vector2(0.4f, 0.4f);
            movingRight = true;
        }

        if (movingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }

    void Angry()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        speed = 1f;
        if (transform.position.x - player.position.x > 0 && transform.localScale.x > 0)//�����
        {
            transform.localScale = new Vector2(-0.4f, 0.4f);
        }
        else if (transform.position.x - player.position.x < 0 && transform.localScale.x < 0)
        {
            transform.localScale = new Vector2(0.4f, 0.4f);
        }
    }

    void GoBack()
    {
        if (transform.position.x < point.position.x && transform.localScale.x > 0)//�����
        {
            transform.localScale = new Vector2(-0.4f, 0.4f);
        }
        if (transform.position.x > point.position.x && transform.localScale.x < 0)
        {
            transform.localScale = new Vector2(0.4f, 0.4f);
        }
        speed = 0.3f;
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    }

    public void TakeDamage(int damage)
    {
        stopTime = startStopTime;
        health -= damage;
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("IsDeath");
    }
}
