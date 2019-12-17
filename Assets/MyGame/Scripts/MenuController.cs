using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour{
    public void Play()
    {
        SceneManager.LoadScene(GetComponent<GameManager>().mainScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
