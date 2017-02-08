using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTextAtLine : MonoBehaviour {

    public TextAsset thetext;
    public TextAsset thetext2;
    public int startline;
    public int endline;
    public TextBoxManager thetextman;
    public PlayerMovements tests;

	// Use this for initialization
	void Start () {

        thetextman = FindObjectOfType<TextBoxManager>();
        tests = FindObjectOfType<PlayerMovements>(); }
	
	// Update is called once per frame
	void Update () {}

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.name == "Player" && tests.kids_test == false && gameObject.CompareTag("Kids")) {
            thetextman.ReloadScript(thetext);
            thetextman.currentline = startline;
            thetextman.endatline = endline;
            thetextman.EnableTextBox(); }

        if(other.name == "Player" && tests.kids_test == true && gameObject.CompareTag("Kids")) {
            thetextman.ReloadScript(thetext2);
            thetextman.currentline = startline;
            thetextman.endatline = endline;
            thetextman.EnableTextBox();
            }

        if (other.name == "Player" && tests.wife_test == false && gameObject.CompareTag("Mom")) {
            thetextman.ReloadScript(thetext);
            thetextman.currentline = startline;
            thetextman.endatline = endline;
            thetextman.EnableTextBox(); }

        if (other.name == "Player" && tests.wife_test == true && gameObject.CompareTag("Mom")) {
            thetextman.ReloadScript(thetext2);
            thetextman.currentline = startline;
            thetextman.endatline = endline;
            thetextman.EnableTextBox(); }

        if (other.name == "Player" && tests.dog_test == false && gameObject.CompareTag("Dog")) {
            thetextman.ReloadScript(thetext);
            thetextman.currentline = startline;
            thetextman.endatline = endline;
            thetextman.EnableTextBox(); }

        if (other.name == "Player" && tests.dog_test == true && gameObject.CompareTag("Dog")) {
            thetextman.ReloadScript(thetext2);
            thetextman.currentline = startline;
            thetextman.endatline = endline;
            thetextman.EnableTextBox(); }

    } }
