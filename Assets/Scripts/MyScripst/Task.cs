using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{

    [Header("Dependencies")]
	[SerializeField] private TaskController taskcontroller;
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			taskcontroller.completeTask();
		}
	}

  }
