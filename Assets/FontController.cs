using UnityEngine;
using TMPro;

public class FontController : MonoBehaviour
{
    [Header("Configuración del Texto")]
    [SerializeField] private TextMeshProUGUI textoTitulo;

    [Header("Configuración del Tamaño")]
    [SerializeField] private float incrementoFuente = 5f;
    [SerializeField] private float tamañoMinimo = 20f;
    [SerializeField] private float tamañoMaximo = 150f;
    [SerializeField] private float tamañoInicial = 72f;

    private void Start()
    {
        if (textoTitulo == null)
        {
            Debug.LogError("FontController: No se ha asignado ningún texto!");
            return;
        }
        textoTitulo.fontSize = tamañoInicial;
    }

    public void AumentarFuente()
    {
        if (textoTitulo == null) return;
        float nuevoTamano = textoTitulo.fontSize + incrementoFuente;
        if (nuevoTamano <= tamañoMaximo)
        {
            textoTitulo.fontSize = nuevoTamano;
        }
    }

    public void DisminuirFuente()
    {
        if (textoTitulo == null) return;
        float nuevoTamano = textoTitulo.fontSize - incrementoFuente;
        if (nuevoTamano >= tamañoMinimo)
        {
            textoTitulo.fontSize = nuevoTamano;
        }
    }

    public void ResetearFuente()
    {
        if (textoTitulo == null) return;
        textoTitulo.fontSize = tamañoInicial;
    }
}