using UnityEngine;
using UnityEngine.SceneManagement;

public enum Stage
{
    Grassland,
    Desert,
    Snowfield,
    Sky,
    Jungle,
    Lava,
    Underwater,
    BowserCastle
}

public class StageManager : MonoBehaviour
{
    public Stage CurrentStage { get; private set; } = Stage.Grassland;

    public void LoadStage(Stage stage)
    {
        CurrentStage = stage;
        SceneManager.LoadScene(stage.ToString());
    }

    public void ReloadCurrentStage()
    {
        SceneManager.LoadScene(CurrentStage.ToString());
    }

    public void LoadNextStage()
    {
        int next = ((int)CurrentStage + 1) % System.Enum.GetNames(typeof(Stage)).Length;
        LoadStage((Stage)next);
    }
}

