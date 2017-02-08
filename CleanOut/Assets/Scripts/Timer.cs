using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public int timedisplace;
    public int timetotal = 75;
    public int timeleft = 75;
    public Text countdowntime;

	// Use this for initialization
	void Start () {

        StartCoroutine("LoseTime");

	}
	
	// Update is called once per frame
	void Update () {

        countdowntime.text = ("Time: " + timeleft);

        if (timeleft <= 0)
        {
            StopCoroutine("LoseTime");
            timedisplace = timetotal - timeleft;
            Application.LoadLevel("LoseScreen");
        }

	}

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeleft--;
        }
    }
}
