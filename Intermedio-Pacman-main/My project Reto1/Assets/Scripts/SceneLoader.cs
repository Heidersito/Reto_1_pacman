using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string retouno; // Nombre de la escena que deseas cargar
    public float timeScale = 1f; // Valor del time scale que deseas establecer

    public void LoadScene()
    {
        StartCoroutine(LoadSceneAsync());
    }

    private IEnumerator LoadSceneAsync()
    {
        Time.timeScale = timeScale; // Establece el time scale antes de cargar la escena

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(retouno);

        // Mientras la escena se está cargando, puedes mostrar una pantalla de carga o realizar otras tareas

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
