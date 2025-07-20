using UnityEngine;
using UnityEngine.Playables;

[RequireComponent(typeof(Collider))]
public class CutsceneTrigger : MonoBehaviour
{
    public PlayableDirector director;
    public MonoBehaviour playerController;

    private bool hasPlayed;

    void Start()
    {
        if (director == null)
        {
            director = GetComponent<PlayableDirector>();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (hasPlayed || director == null) return;

        if (other.CompareTag("Player"))
        {
            if (playerController != null)
            {
                playerController.enabled = false;
            }
            director.stopped += OnCutsceneFinished;
            director.Play();
            hasPlayed = true;
        }
    }

    private void OnCutsceneFinished(PlayableDirector obj)
    {
        director.stopped -= OnCutsceneFinished;
        if (playerController != null)
        {
            playerController.enabled = true;
        }
    }
}
