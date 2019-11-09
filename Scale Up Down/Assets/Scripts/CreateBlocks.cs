using System;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{
	public int worldSize;
	public GameObject block;

	private int arrSize;

  // Start is called before the first frame update
  void Start()
  {
		arrSize = Convert.ToInt32(worldSize / 2.0f);
		SpawnBlocks();
  }

  // Update is called once per frame
  void Update()
  {
        
  }

	void SpawnBlocks()
	{
		for (int i = -arrSize; i < arrSize; i += 4)
		{
			for (int j = -arrSize; j < arrSize; j += 4)
			{
				SpawnBlock(i, j);
			}
		}
	}

	void SpawnBlock(float posX, float posZ)
	{
		Instantiate(block, new Vector3(posX, 0.0f, posZ), new Quaternion(0.0f, 0.0f, 0.0f, 0.0f));
	}
}
