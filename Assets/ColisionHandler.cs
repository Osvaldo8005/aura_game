using UnityEngine;
using UnityEngine.UI;

public class ColisionHandler : MonoBehaviour
{
    [Header("Configuración")]
    [SerializeField] private RectTransform objetoSprite;
    [SerializeField] private float distanciaColision = 100f;

    [Header("Referencias")]
    [SerializeField] private Image imagenColor;

    [Header("Colores")]
    [SerializeField] private Color colorNormal = new Color(1f, 0f, 0f, 0.5f);
    [SerializeField] private Color colorActivo = new Color(0f, 1f, 0f, 0.9f);

    private bool dentroDeZona = false;
    private AudioSource audioSource;
    private AudioClip sonidoColision;

    private void Start()
    {
        if (imagenColor != null)
        {
            imagenColor.color = colorNormal;
        }

        // Cargar el sonido desde la carpeta Resources (nombre exacto)
        sonidoColision = Resources.Load<AudioClip>("Magic 57-echo");

        // Agregar AudioSource si no existe
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (sonidoColision == null)
        {
            Debug.LogError("No se pudo cargar el sonido desde Resources/Magic 57-echo");
        }
        else
        {
            Debug.Log("Sonido cargado correctamente: " + sonidoColision.name);
        }
    }

    private void Update()
    {
        if (objetoSprite == null || imagenColor == null) return;

        float distancia = Vector2.Distance(
            objetoSprite.anchoredPosition,
            GetComponent<RectTransform>().anchoredPosition
        );

        if (distancia <= distanciaColision && !dentroDeZona)
        {
            dentroDeZona = true;
            Debug.Log("¡Colisión detectada! El sprite entró en la zona.");
            imagenColor.color = colorActivo;

            if (audioSource != null && sonidoColision != null)
            {
                audioSource.PlayOneShot(sonidoColision);
                Debug.Log("Reproduciendo sonido: " + sonidoColision.name);
            }
        }
        else if (distancia > distanciaColision && dentroDeZona)
        {
            dentroDeZona = false;
            Debug.Log("El sprite salió de la zona.");
            imagenColor.color = colorNormal;
        }
    }
}