using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCamToPlayer : MonoBehaviour
{
	private GameObject cameraRoot;
	private GameObject playerRoot;
  // Start is called before the first frame update
  void Start()
  {
		cameraRoot = GameObject.FindGameObjectWithTag("camera_root");
		playerRoot = GameObject.FindGameObjectWithTag("player_root");

		if (cameraRoot != null && playerRoot != null)
		{
			cameraRoot.transform.SetParent(playerRoot.transform);
		}
		else
		{
			Debug.Log("error finding roots");
		}
	}

  // Update is called once per frame
  void FixedUpdate()
  {
		cameraRoot.transform.rotation = new Quaternion(0.0f, 360.0f - playerRoot.transform.rotation.y, 0.0f, 0.0f);
  }
}
