using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    [SerializeField] private GameObject botonAudio;
    [SerializeField] private GameObject menuAudio;
    private bool juegoPausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (juegoPausado)
            {
                Reanudar();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Audio()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        botonAudio.SetActive(false);
        menuAudio.SetActive(true);
    }
    public void Pause()
    {
        juegoPausado = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }
    public void Reanudar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }
    public void Reiniciar()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);

    }

    public void Cerrar()
    {
        Application.Quit();
    }
    public void CerrarPanel()
    {
        juegoPausado = false;
        Time.timeScale = 1f;
        botonAudio.SetActive(true);
        menuAudio.SetActive(false);
    }
}
