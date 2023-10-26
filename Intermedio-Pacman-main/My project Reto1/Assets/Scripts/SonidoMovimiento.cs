using UnityEngine;

public class SonidoMovimiento : MonoBehaviour
{
    public AudioClip sonidoMovimiento; // Asigna el clip de sonido en el Inspector
    private AudioSource audioSource;

    private void Start()
    {
        // Obtén el componente AudioSource del objeto
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        // Comprueba las entradas del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Si alguna de las teclas de flecha se presiona, reproduce el sonido de movimiento
        if (movimientoHorizontal != 0 || movimientoVertical != 0)
        {
            if (!audioSource.isPlaying)
            {
                // Reproduce el sonido de movimiento
                audioSource.PlayOneShot(sonidoMovimiento);
            }
        }
    }
}
