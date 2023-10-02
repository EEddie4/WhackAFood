using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerX : MonoBehaviour
{
    public float TimeLeft =60; //Holds the time left
    public bool TimerOn = false; //Boolean to check if timer is active or inactive

    public TextMeshProUGUI TimerTxt; //Displays the timer in game UI

    private GameManagerX gameManagerX2; //Reference to the Game Manager to reference method in the Game Manager
   
    void Start()
    {
        TimerOn = true;
        gameManagerX2 = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }

    void Update()
    {
        if (gameManagerX2.isGameActive)
        {
        if(TimerOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time is UP!");
                TimeLeft = 0;
                TimerOn = false;
                gameManagerX2.isGameActive = false;
            }
        }

        }
    }



    public void updateTimer(float currentTime) //This method updates the timer in the code
    {
        
        {
        currentTime += 1;

        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = "Timer: " + string.Format("{0:00}", seconds);
        }
    }

}