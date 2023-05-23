using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScene : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField]
    private AudioSource musicAmbient;

    public string sceneName;

    public Timer timer;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            musicAmbient.Stop();
            timer.EndTime();
            SceneManager.LoadScene(sceneName);
        }
    }

}
