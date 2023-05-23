using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static CollectibleScript;

public class Coins : MonoBehaviour
{
    [SerializeField]
    private float speedX = 0.5f;
    [SerializeField]
    private float speedY = 0.5f;
    [SerializeField]
    private float speedZ = 0f;

    [SerializeField]
    private int scoreBonus;

    [SerializeField]
    private CoinsType coinsType;
    
    void Update()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime);
    }
    public int GetScoreBonus()
    {
        return this.scoreBonus;
    }

    public CoinsType GetCoinsType()
    {
        return this.coinsType;
    }
}







