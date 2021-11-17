using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class follow : MonoBehaviour
{


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			SceneManager.LoadScene("lost");
		}
		/*if (other.tag == "platform")
		{
			scoreField.AddNumber(pointsToAdd);
		}*/
	}


	public Transform target;

	void Update()
	{
		if (target.position.y > transform.position.y)
		{
			Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
