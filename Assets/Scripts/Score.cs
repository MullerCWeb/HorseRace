using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private Transform transformPlayer;
    
    void Update()
    {
        scoreText.text = "Score : " + transformPlayer.position.z.ToString("0");
    }
}
