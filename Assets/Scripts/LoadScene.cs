using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level01");
    }

    
    public void LoadLevel2()
    {
        Debug.Log("Level 2 Coming Soon!");
    }
}
