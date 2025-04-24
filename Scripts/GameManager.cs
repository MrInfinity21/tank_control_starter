using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UserInterface _userInterface;
    private static GameManager _instance;
    private int _currentScore = 0;
    
    void Start()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static GameManager GetInstance()
    {
        return _instance;
    }

    public void AddScore(int scoreAmount)
    {
        _currentScore += scoreAmount;
        _userInterface.SetScoreText(_currentScore);
    }
}
