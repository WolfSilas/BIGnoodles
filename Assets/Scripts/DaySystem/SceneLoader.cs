using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class SceneLoader : MonoBehaviour


{
    public string sceneName = "Day2"; // Ensure this matches your scene name exactly
    private PlayableDirector playableDirector;
    // This method is called to load the specified scene
    private void Start()
    {
        // Get the PlayableDirector component attached to this GameObject
        playableDirector = GetComponent<PlayableDirector>();

        // Subscribe to the DirectorStopped event to detect when the timeline ends
        playableDirector.stopped += OnTimelineStopped;
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
    private void OnTimelineStopped(PlayableDirector director)
    {
        // Check if the specified timeline has ended
        if (director == playableDirector)
        {
            // Load the specified scene
            SceneManager.LoadScene(sceneName);
        }
    }
    private void OnDestroy()
    {
        if (playableDirector != null)
        {
            playableDirector.stopped -= OnTimelineStopped;
        }
    }
}

