using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{

    public void BackToStart()
    {
        SceneManager.LoadScene("StartScenes");
    }
}
