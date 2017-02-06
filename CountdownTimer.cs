using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {
    public string sceneToChangeTo;
    private float timer = 300f;
    private Text timerText;
    private string timerSeconds;
    private string timerMinutes;
    private string finishTime;
	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        timerMinutes = ((int)timer / 60).ToString("00");
        timerSeconds = (timer % 60).ToString("00");
        timerText.text = timerMinutes + ":" + timerSeconds;
        if ( )
        {
            finishTime = timerMinutes + ":" + timerSeconds;
            Application.LoadLevel("winScene");
        }
        if (timer <= 0)
        {
            Application.LoadLevel(sceneToChangeTo);
        }
	}
}
