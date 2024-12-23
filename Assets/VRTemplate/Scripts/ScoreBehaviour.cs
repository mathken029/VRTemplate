using System;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    //スコアを表示するUI
    [SerializeField] private TMPro.TextMeshProUGUI scoreText;
    
    //スコア
    private int score = 0;

    private void Update()
    {
        //スコアを表示する
        scoreText.text = $"Score: {score}";
    }

    //スコアを加算する
    public void AddScore(int point)
    {
        score += point;
    }
    
    //スコアを取得する
    public int GetScore()
    {
        return score;
    }
    
    //スコアをリセットする
    public void ResetScore()
    {
        score = 0;
    }
}
