using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    [Header("Task Details")]
    [SerializeField] private int numberOfTasks;

    [Header("GameObjects")]
    [SerializeField] GameObject col;
    [SerializeField] GameObject arrow;

    public void completeTask()
	{
        numberOfTasks--;
        if(numberOfTasks <= 0)
		{
            Destroy(col);
            arrow.SetActive(true);
           
		}

	}
}
