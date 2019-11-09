using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScale : MonoBehaviour
{
	public float size;
	public float speed;

	private bool isActive;
  // Start is called before the first frame update
  void Start()
  {
		isActive = false;
		this.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
  }

	private void FixedUpdate()
	{
		if (isActive && this.transform.localScale.x < size)
		{
			ScaleUp();
		}

		if (!isActive && this.transform.localScale.x > 0.0f)
		{
			ScaleDown();
		}

		if (this.transform.localScale.x > -0.05f && this.transform.localScale.x < 0.05f)
		{
			this.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("player"))
		{
			isActive = true;
		}
	}
	private void OnTriggerExit(Collider other)
	{
		if (other.gameObject.CompareTag("player"))
		{
			isActive = false;
		}
	}

	void ScaleUp()
	{
		this.transform.localScale += new Vector3(speed, speed, speed);
	}

	void ScaleDown()
	{
		this.transform.localScale -= new Vector3(speed, speed, speed);
	}
}
