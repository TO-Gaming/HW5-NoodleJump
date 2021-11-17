using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class mover : MonoBehaviour
{

	public float speed = 8f;

	Rigidbody2D rb;

	float move = 0f;

	// Use this for initialization
	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		move = Input.GetAxis("Horizontal") * speed;
	}

	void FixedUpdate()
	{
		Vector2 velocity = rb.velocity;
		velocity.x = move;
		rb.velocity = velocity;
	}
}
