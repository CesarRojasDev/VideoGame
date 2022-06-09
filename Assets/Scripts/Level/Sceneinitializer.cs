using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Sceneinitializer : MonoBehaviour
{
	[Header("Dependencies")]
	public SceneSO[] sceneDependencies;
	[Header("On Scene Ready")]
	public UnityEvent onDependenciesLoaded;

	void Start()
	{
		StartCoroutine(LoadDependencies());
	}
	private IEnumerator LoadDependencies()
	{
		for (int i = 0; i <= this.sceneDependencies.Length - 1; i++)
		{
			SceneSO sceneToLoad = this.sceneDependencies[i];
			if(SceneManager.GetSceneByName(sceneToLoad.name).isLoaded == false)
			{
				var loadOperation = SceneManager.LoadSceneAsync(sceneToLoad.name, LoadSceneMode.Additive);
				while (loadOperation.isDone == false)
				{
					yield return null;
				}
			}
		}
		if (onDependenciesLoaded != null)
			onDependenciesLoaded.Invoke();
	}
}
