using System;
using TMPro;
using UnityEngine;
using static Coins;

public class EndGame : MonoBehaviour
{
    //---- SCORE kills types enemy ----
    [SerializeField]
    private TextMeshProUGUI RedEnemyScore;

    [SerializeField]
    private TextMeshProUGUI BlueEnemyScore;

    [SerializeField]
    private TextMeshProUGUI PurpleEnemyScore;

    //--- Score type coins ---
    [SerializeField]
    private TextMeshProUGUI GdCoinScore;

    [SerializeField]
    private TextMeshProUGUI SilvCoinScore;

    [SerializeField]
    private TextMeshProUGUI BroCoinScore;

    // --- END Timer ---
    [SerializeField]
    private TextMeshProUGUI EndTime;

    void Start()
    {
        TypeCoinsEndGame();
        EndTimer();
        TypeEnemyEndGame();
    }

    private void EndTimer()
    {
        TimeSpan spanTime = TimeSpan.FromSeconds(GameController.instance.EndTime);
        EndTime.text = " : " + spanTime.Minutes + " : " + spanTime.Seconds;
    }

    private void TypeCoinsEndGame()
    {
            BroCoinScore.text = GameController.instance.ScoreNbrBronzeCoins.ToString();
            SilvCoinScore.text = GameController.instance.ScoreNbrSilverCoins.ToString();
            GdCoinScore.text = GameController.instance.ScoreNbrGoldCoins.ToString();
    }
    private void TypeEnemyEndGame()
    {
        RedEnemyScore.text = GameController.instance.ScoreNbrRedEnemy.ToString();
        BlueEnemyScore.text = GameController.instance.ScoreNbrBlueEnemy.ToString();
        PurpleEnemyScore.text = GameController.instance.ScoreNbrPurpleEnemy.ToString();
    }
}