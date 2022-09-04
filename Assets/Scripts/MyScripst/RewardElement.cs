using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardElement : MonoBehaviour
{
	[SerializeField] private int cantidadPuntos;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player"))
		{
			ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);
			Destroy(gameObject);
		}
	}
}
