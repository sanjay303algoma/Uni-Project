using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame1 : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("NextScene2");
    }
}

