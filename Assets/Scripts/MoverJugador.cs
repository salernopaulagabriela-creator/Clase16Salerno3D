using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    [SerializeField] float velocidad = 5f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(x, 0, z) * velocidad * Time.deltaTime);
    }
}