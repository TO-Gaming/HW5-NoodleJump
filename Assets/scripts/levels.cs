using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels : MonoBehaviour
{
	public GameObject platformPrefab;
	public GameObject nextlevel;

	public int numberOfPlatforms = 150;
	float easyWidth = 4f;
	float hardWidth = 5.5f;
	float minY = .5f;
	float maxY = 1.5f;
	


	// Use this for initialization
	void Start()
	{

		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			if (i<numberOfPlatforms/2)
            {
				spawnPosition.y += Random.Range(minY, maxY);
				spawnPosition.x = Random.Range(-easyWidth, easyWidth);
				Instantiate(platformPrefab, spawnPosition, Quaternion.Euler(0, 0, -30));


            }
            else
            {
				minY = 1.5f;
				maxY = 2.5f;
				spawnPosition.y += Random.Range(minY, maxY);
				spawnPosition.x = Random.Range(-hardWidth, hardWidth);
				Instantiate(platformPrefab, spawnPosition, Quaternion.Euler(0, 0, -30));
			}
			
		}
		spawnPosition.y += 3;
		Instantiate(nextlevel, spawnPosition, Quaternion.Euler(0, 0, -30));

	}


}
