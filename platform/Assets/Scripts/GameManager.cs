using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject replayBtn;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        replayBtn.SetActive(true);

    }

    public void OnReplayBtnPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
