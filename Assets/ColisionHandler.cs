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

    private void Start()
    {
        if (imagenColor != null)
        {
            imagenColor.color = colorNormal;
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
        }
        else if (distancia > distanciaColision && dentroDeZona)
        {
            dentroDeZona = false;
            Debug.Log("El sprite salió de la zona.");
            imagenColor.color = colorNormal;
        }
    }
}