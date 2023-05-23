
using UnityEngine;
using TMPro;
using System.Collections.Generic;
using static EnemyStats;

public class GameController : MonoBehaviour
{
    //--- COINS SCORE ---
    [SerializeField] private int scoreTotal;
    public int ScoreTotal { get { return scoreTotal; } set { scoreTotal = value; } }

    [SerializeField] private int scoreNbrBronzeCoins;
    public int ScoreNbrBronzeCoins { get { return scoreNbrBronzeCoins; } set { scoreNbrBronzeCoins = value; } }

    [SerializeField] private int scoreNbrSilverCoins;
    public int ScoreNbrSilverCoins { get { return scoreNbrSilverCoins; } set { scoreNbrSilverCoins = value; } }

    [SerializeField] private int scoreNbrGoldCoins;
    public int ScoreNbrGoldCoins { get { return scoreNbrGoldCoins; } set { scoreNbrGoldCoins = value; } }

    // --- KILLS SCORE ---
    [SerializeField] private int scoreNbrRedEnemy;
    public int ScoreNbrRedEnemy { get { return scoreNbrRedEnemy; } set { scoreNbrRedEnemy = value; } }

    [SerializeField] private int scoreNbrBlueEnemy;
    public int ScoreNbrBlueEnemy { get { return scoreNbrBlueEnemy; } set { scoreNbrBlueEnemy = value; } }

    [SerializeField] private int scoreNbrPurpleEnemy;
    public int ScoreNbrPurpleEnemy { get { return scoreNbrPurpleEnemy; } set { scoreNbrPurpleEnemy = value; } }

    //--- END TIMER ---
    private float endTime;
    public float EndTime { get { return endTime; } set { endTime = value; } }

    [SerializeField]
    private TextMeshProUGUI scoreIHM;

    // reference singleton
    public static GameController instance;

    void Awake()
    {
        //singleton
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public static void IncScoreCoins(int score)
    {
        instance.scoreTotal += score;

        instance.scoreIHM.text = "Score : " + instance.scoreTotal.ToString();
    }

    public static void NbrTypeCoins(CoinsType type)
    {
        switch (type) {
            case CoinsType.BRONZE:
                instance.scoreNbrBronzeCoins++;
                break;
            case CoinsType.SILVER:
                instance.scoreNbrSilverCoins++;
                break;
            case CoinsType.GOLD:
                instance.scoreNbrGoldCoins++;
                break;
                default: break;
        }
    }

    public static void NbrTypeEnemy(EnemyType type)
    {
        switch (type)
        {
            case EnemyType.EnemyRed:
                instance.scoreNbrRedEnemy++;
                break;
            case EnemyType.EnemyBlue:
                instance.scoreNbrBlueEnemy++;
                break;
            case EnemyType.EnemyPurple:
                instance.scoreNbrPurpleEnemy++;
                break;
            default: break;
        }
    }
}











/*  private List<EnemyStats.EnemyType> enemyTypes;

private EnemyStats enemyStats; */



