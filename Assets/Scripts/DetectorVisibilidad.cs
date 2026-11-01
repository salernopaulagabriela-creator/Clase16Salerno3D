using UnityEngine;
using TMPro;

public class DetectorVisibilidad : MonoBehaviour
{
    [SerializeField] float vida = 100f;
    [SerializeField] float danioPorSegundo = 10f;
    [SerializeField] TMP_Text textoVida;

    MeshRenderer meshRenderer;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        if (meshRenderer.isVisible)
        {
            vida -= danioPorSegundo * Time.deltaTime;
        }

        textoVida.text = "Vida: " + Mathf.CeilToInt(vida);

        if (vida <= 0)
        {
            vida = 0;
            textoVida.text = "Gana el vigilante";
            Debug.Log("Gana el vigilante");
        }
    }
}