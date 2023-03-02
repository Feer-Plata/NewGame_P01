using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{

    public void MainMenu()
    {
        //Carga el menu principal.
        SceneManager.LoadScene(0);
    }
    public void Iniciar()
    {
        //Carga el juego.
        //Scoring.score = 0;
        SceneManager.LoadScene(1);

    }
    public void ReIniciar()
    {
        //Carga el juego.
        //Scoring.score = 0;
        SceneManager.LoadScene(1);

    }
    public void Finalizar()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }
}
