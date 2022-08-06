using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text _timerGame;
    private float timer = 90f; 


    void Start()
    {
        
    }
        
    void Update()
    {
        timer -= Time.deltaTime;
        _timerGame.text = "Timer: " + Mathf.Round(timer) + " sec.";

        if (timer <= 0)
        {
            //GameOver
        }
    }
}
