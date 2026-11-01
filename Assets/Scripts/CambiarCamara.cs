using UnityEngine;

public class CambiarCamara : MonoBehaviour
{
    [SerializeField] Camera[] camaras;
    [SerializeField] float cooldown = 2f;
    float tiempoUltimoCambio;

    void Start()
    {
        ActivarCamara(0);
        tiempoUltimoCambio = -cooldown;
    }

    void Update()
    {
        if (Time.time - tiempoUltimoCambio < cooldown)
        {
            return;
        }

        for (int i = 0; i < camaras.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                ActivarCamara(i);
                tiempoUltimoCambio = Time.time;
            }
        }
    }

    void ActivarCamara(int indice)
    {
        for (int i = 0; i < camaras.Length; i++)
        {
            camaras[i].gameObject.SetActive(i == indice);
        }
    }
}