using UnityEngine;

public class CreatePlayer : MonoBehaviour
{
	public GameObject player;

  // Start is called before the first frame update
  void Start()
  {
		Spawn();
  }

	void Spawn()
	{
		Instantiate(player, new Vector3(0.0f, 3.0f, 0.0f), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
	}
}
