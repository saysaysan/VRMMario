using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
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

    public Stage currentStage = Stage.Grassland;

    public void LoadStage(Stage stage)
    {
        currentStage = stage;
        SceneManager.LoadScene(stage.ToString());
    }

    public void LoadNextStage()
    {
        int next = ((int)currentStage + 1) % System.Enum.GetNames(typeof(Stage)).Length;
        LoadStage((Stage)next);
    }
}

