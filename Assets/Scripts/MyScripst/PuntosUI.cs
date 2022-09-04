using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PuntosUI : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
 void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        Debug.Log(ControladorPuntos.Instance.returnPuntos());
        textMesh.text =ControladorPuntos.Instance.returnPuntos().ToString();
    }

}
