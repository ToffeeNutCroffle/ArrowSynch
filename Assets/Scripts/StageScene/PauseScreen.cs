using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    // Start is called before the first frame update

    public void Tomenue()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("RESTART!");
    }

    public void Resume()
    {
        GameManager.instance.theMusic.UnPause();
        Time.timeScale=1;
        GameManager.instance.pauseOn=false;
        GameManager.instance.pauseScreen.SetActive(false);
        Debug.Log("RESUME!");
    }
}
