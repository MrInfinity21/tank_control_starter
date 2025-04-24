using TMPro;
using UnityEngine;

public class UserInterface : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private GameObject _pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            TriggerPauseMenu();
        }
    }

    public void TriggerPauseMenu() 
    { 
        if (_pauseMenu.activeInHierarchy) 
        { 
            _pauseMenu.SetActive(false); 
            Time.timeScale = 1f;
        }
        else 
        { 
            _pauseMenu.SetActive(true); 
            Time.timeScale = 0f;
        }
    }
    

    public void ExitGame()
    {
        Application.Quit();
    }
    public void SetScoreText(int score)
    {
        _scoreText.text = "Score: " + score;
    }
    
}