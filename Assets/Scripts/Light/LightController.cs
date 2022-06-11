using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class LightController : MonoBehaviour
{
	[SerializeField] private GameObject light;

	private PlayerInput playerInteract;

	public void TurOffLight()
	{
			light.SetActive(false);
	}
	public void InteractWithLight(InputAction.CallbackContext context)
	{

		Debug.Log("Action was done!!!");
	}
    
}
