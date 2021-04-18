using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour 
{
	[SerializeField]private Transform groundCheck;
	private Rigidbody2D rb;
	private bool isGrounded = false;

	public LayerMask GroundLayers;

	[SerializeField] private float speedX = 5.86f;
	[SerializeField] private float speedY = 18f;

	void Start () 
	{
		groundCheck = transform.FindChild("Ground Check");
		rb = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate () 
	{
		isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.15f, GroundLayers);
		Debug.Log(isGrounded);

		float x = Input.GetAxis("Horizontal");
		if (Input.GetAxis("Jump") > 0 && isGrounded)
		{
			rb.AddForce(Vector2.up * speedY, ForceMode2D.Impulse);
		}
		rb.velocity = new Vector3(x * speedX, rb.velocity.y, 0);
	}
}
