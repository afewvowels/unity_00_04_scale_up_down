using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlayer : MonoBehaviour
{
	public float speed;
	public float rotation;

	private Rigidbody rb;

  void Start()
  {
		rb = this.GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
		if(Input.GetKey(KeyCode.W))
		{
			rb.AddRelativeForce(new Vector3(0.0f, 0.0f, speed), ForceMode.Impulse);
		}
		if(Input.GetKey(KeyCode.A))
		{
			rb.AddRelativeTorque(new Vector3(0.0f, -rotation, 0.0f), ForceMode.Impulse);
		}
		if (Input.GetKey(KeyCode.D))
		{
			rb.AddRelativeTorque(new Vector3(0.0f, rotation, 0.0f), ForceMode.Impulse);
		}
	}
}
