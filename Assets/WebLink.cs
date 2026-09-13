using UnityEngine;

public class WebLink : MonoBehaviour
{
    [SerializeField] private string url;

    public void SetUrl(string newUrl)
    {
        url = newUrl;
    }

    public void Open()
    {
        if (string.IsNullOrWhiteSpace(url))
            return;

        Application.OpenURL(url);
    }
}
