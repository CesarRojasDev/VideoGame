using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reward : MonoBehaviour
{
	[SerializeField] private float scorePoints;

    [Header("Dependencies")]
	[SerializeField] public Score score;
	private void OnTriggerEnter2D(Collider2D other)
	{

		if (other.CompareTag("Player"))
		{
			score.AddPoints(scorePoints);
			Destroy(gameObject);
		}
	}
}
