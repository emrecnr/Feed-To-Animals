using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private Color originalColor;
    public Color hoverColor;
    private Renderer renderers;

    private void Start()
    {
        Time.timeScale = 1;
        renderers = GetComponent<Renderer>();
        originalColor = renderers.material.color;
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(1);
    }
    private void OnMouseEnter()
    {
        renderers.material.color = hoverColor;
    }
    private void OnMouseExit()
    {
        renderers.material.color = originalColor;
    }
}
