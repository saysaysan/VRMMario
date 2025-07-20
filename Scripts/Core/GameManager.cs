using UnityEngine;

using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public enum GameState
    {
        MainMenu,
        Playing,
        Paused,
        GameOver
    }

    public UnityEvent<GameState> OnStateChanged;

    public GameState CurrentState { get; private set; }
    public int Coins { get; private set; }
    public int Lives { get; private set; } = 3;

    [SerializeField]
    private StageManager stageManager;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeState(GameState.MainMenu);
    }

    public void StartGame()
    {
        Coins = 0;
        Lives = 3;

        if (stageManager != null)
        {
            stageManager.LoadStage(Stage.Grassland);
        }

        ChangeState(GameState.Playing);
    }

    public void PauseGame()
    {
        if (CurrentState == GameState.Playing)
        {
            Time.timeScale = 0f;
            ChangeState(GameState.Paused);
        }
    }

    public void ResumeGame()
    {
        if (CurrentState == GameState.Paused)
        {
            Time.timeScale = 1f;
            ChangeState(GameState.Playing);
        }
    }

    public void GameOver()
    {
        ChangeState(GameState.GameOver);
        Time.timeScale = 0f;
    }

    public void PlayerDied()
    {
        Lives--;
        if (Lives <= 0)
        {
            GameOver();
        }
        else if (stageManager != null)
        {
            stageManager.ReloadCurrentStage();
        }
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        OnStateChanged?.Invoke(newState);
    }

    public void AddCoin(int amount = 1)
    {
        Coins += amount;
    }
}
