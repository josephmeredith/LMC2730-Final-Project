using UnityEngine;
using UnityEngine.SceneManagement;

public class cutScene : MonoBehaviour
{
    public void intoGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}