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
    // Índigo místico (idle) → violeta luminoso (activo)
    [SerializeField] private Color colorNormal = new Color(0.22f, 0.12f, 0.48f, 0.45f);
    [SerializeField] private Color colorActivo = new Color(0.55f, 0.35f, 0.95f, 0.75f);
    [SerializeField] private float velocidadTransicion = 6f;
    [SerializeField] private float intensidadPulso = 0.12f;

    private bool dentroDeZona = false;
    private Color colorObjetivo;
    private AudioSource audioSource;
    private AudioClip sonidoColision;

    private void Start()
    {
        colorObjetivo = colorNormal;

        if (imagenColor != null)
        {
            imagenColor.color = colorNormal;
        }

        // Cargar el sonido desde la carpeta Resources (nombre exacto)
        sonidoColision = Resources.Load<AudioClip>("magic57-echo");

        // Agregar AudioSource si no existe
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        if (sonidoColision == null)
        {
            Debug.LogError("No se pudo cargar el sonido desde Resources/magic57-echo");
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
            colorObjetivo = colorActivo;
            Debug.Log("¡Colisión detectada! El sprite entró en la zona.");

            if (audioSource != null && sonidoColision != null)
            {
                audioSource.PlayOneShot(sonidoColision);
                Debug.Log("Reproduciendo sonido: " + sonidoColision.name);
            }
        }
        else if (distancia > distanciaColision && dentroDeZona)
        {
            dentroDeZona = false;
            colorObjetivo = colorNormal;
            Debug.Log("El sprite salió de la zona.");
        }

        Color destino = colorObjetivo;
        if (dentroDeZona)
        {
            float pulso = 1f + Mathf.Sin(Time.time * 3.5f) * intensidadPulso;
            destino.a = Mathf.Clamp01(colorActivo.a * pulso);
            destino.r = Mathf.Clamp01(colorActivo.r + 0.08f * Mathf.Sin(Time.time * 2.2f));
            destino.b = Mathf.Clamp01(colorActivo.b + 0.05f * Mathf.Cos(Time.time * 2.2f));
        }

        imagenColor.color = Color.Lerp(imagenColor.color, destino, Time.deltaTime * velocidadTransicion);
    }
}
