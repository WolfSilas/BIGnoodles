using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class TransitionController : MonoBehaviour
{
    public string day2SceneName = "Day2";

    private PlayableDirector playableDirector;

    void Start()
    {
        playableDirector = GetComponent<PlayableDirector>();
        if (playableDirector != null)
        {
            playableDirector.stopped += OnTimelineFinished;
        }
    }

    private void OnTimelineFinished(PlayableDirector director)
    {
        if (director == playableDirector)
        {
            // Load Day 2 scene
            SceneManager.LoadScene(day2SceneName);
        }
    }
}
