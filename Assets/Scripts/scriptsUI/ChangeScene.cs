using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] GameObject buttonPause;
    [SerializeField] GameObject menuPause;
    private bool gamePaused = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Play();
            }
            else
            {
                Pause();
            }
        }

    }
    public void ChangeScenes(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Pause()
    {
        gamePaused = true;
        Time.timeScale = 0;
        buttonPause.SetActive(false);
        menuPause.SetActive(true);
    }
    public void Play()
    {
        gamePaused = false;
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        menuPause.SetActive(false);

    }
    public void Res()

    {
        gamePaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void close()
    {
        Application.Quit();
    }
}
