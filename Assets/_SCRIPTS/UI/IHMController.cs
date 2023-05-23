using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class IHMController : MonoBehaviour
{
     private GameController gameController;

     private int scoreTotal;

    private TextMeshProUGUI textScore;

    [SerializeField] private GameObject gameOverPanel;

    [SerializeField] private GameObject Player;

    private bool gameover;

    private Timer tmer;

    private AudioSource audioSource;
    [SerializeField] private AudioClip sfxGameOver;

    [SerializeField]
    private AudioSource musicAmbient;

    private void Awake()
    {
        gameController = GetComponent<GameController>();
        tmer = GetComponent<Timer>();
        gameOverPanel.SetActive(false);
        audioSource = GetComponent<AudioSource>();
    }

    public void CheckGameOver()
    {
        if (tmer.countDownStartValue > 0)
        {
            gameover = false;
            gameOverPanel.SetActive(false);
        }
        else if (tmer.countDownStartValue <= 0)
        {
            musicAmbient.Stop();
            audioSource.PlayOneShot(sfxGameOver);
            gameover = true;
            Player.gameObject.GetComponent<PlayerController>().enabled = false;
            gameOverPanel.SetActive(true);
        }
    }
}
