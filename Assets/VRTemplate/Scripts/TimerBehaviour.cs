using UnityEngine;

public class TimerBehaviour : MonoBehaviour
{
    //時間を表示するUI
    [SerializeField] private TMPro.TextMeshProUGUI timerText;
    
    //タイマー
    private float timer = 0f;
    
    //タイマーを開始する
    public void StartTimer()
    {
        timer = 0f;
    }
    
    //タイマーを更新する
    private void Update()
    {
        timer += Time.deltaTime;
        
        //タイマーを表示する
        timerText.text = $"Time: {timer:F2}";
    }
    
    //タイマーを取得する
    public float GetTimer()
    {
        return timer;
    }
    
    //タイマーをリセットする
    public void ResetTimer()
    {
        timer = 0f;
    }
}
