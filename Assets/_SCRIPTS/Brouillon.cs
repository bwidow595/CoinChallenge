using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brouillon : MonoBehaviour
{
    /* 
    public AudioSource musicAmbient;

    public void ChangeMusic(AudioClip music)
    {
        musicAmbient.Stop();
        musicAmbient.clip = music;
        musicAmbient.Play();
    }
    
    [SerializeField] private int scoreTotal;
     public int ScoreTotal { get { return scoreTotal; } set { scoreTotal = value; } }

      instance.scoreBronze += score;

         instance.scoreIHM.text = "Score : " + instance.scoreBronze.ToString();

     [SerializeField] private int scoreKill;
     public int ScoreKill { get { return scoreKill; } set { scoreKill = value; } }
     //---- Inventory ----
     [System.Serializable]
     public class Inventory : MonoBehaviour
     {
         public int BronzeCoin;
         public int SilverCoin;
         public int GoldCoin;
     }
 }
 /RdEnemyScore.text = GameController.instance.ScoreKill.ToString();
         GdCoinScore.text = GameController.instance.ScoreTotal.ToString();

  public void SaveToJson()
     {
         string inventoryData = JsonUtility.ToJson(inventory);
         string filePath = Application.persistentDataPath + "/inventoryData.json";
         Debug.Log(filePath);
         System.IO.File.WriteAllText(filePath, inventoryData);
         Debug.Log("Save data");
     }
     public void LoadFromJson()
     {
         string filePath = Application.persistentDataPath + "/inventoryData.json";
         string inventoryData = System.IO.File.ReadAllText(filePath);

         inventory = JsonUtility.FromJson<Inventory>(inventoryData);
         Debug.Log("Chargement effectué");
     }




 [System.Serializable]
 public class Enemy
 {
     public int EnemyRed;
     public int EnemyPurple;
     public int EnemyBlue;
 }

    public int GetScoreBonus()
 {
     return this.scoreBonus;
 }
 public int scoreBonus; 

   public int EnemyValue
     {
         get
         {
             switch (enemyType)
             {
                 case EnemyType.EnemyRed: return 2;
                 case EnemyType.EnemyPurple: return 5;
                 case EnemyType.EnemyBlue: return 10;
                 default: return 0;
             }
         }
     }


 /* private void SpawnPointManager(Transform[] spawnPoint)
   {
       for ( int i = 0;i < spawnPoint.Length;i++)
       {
           transform.position = spawnPoint[i].position;
       }
   }

 [SerializeField]
 private int scoreBonusKill;
 public int GetScoreBonusKill()
 {
     return this.scoreBonusKill;
 }
    GameController.IncScoreKill(enemyType);
    int score = kill.GetScoreBonusKill();

 int score = kill.GetScoreBonusKill();
             Debug.Log("Kill score" + score);
             GameController.IncScoreKill(score);



    public static void IncScoreKill(int score)
    {
        instance.scoreKill += score;
    }



    //--- COINS SCORE ---

    [SerializeField] private int scoreTotal;
    public int ScoreTotal { get { return scoreTotal; } set { scoreTotal = value; } }


    // --- KILLS SCORE ---
    [SerializeField] private int scoreKill;
    public int ScoreKill { get { return scoreKill; } set {  scoreKill = value; } }
    */



}