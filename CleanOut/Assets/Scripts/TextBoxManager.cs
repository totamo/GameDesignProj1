using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

    public GameObject textbox;
    public Text thetext;
    public Text thetext2;
    public TextAsset textfile;
    public string[] textline;
    public int currentline;
    public int endatline;
    public PlayerMovements player;
    public bool isactive;
    public bool stopplayermovement;

	// Use this for initialization
	void Start () {

        player = FindObjectOfType<PlayerMovements>();

        if(textfile != null) {
            textline = (textfile.text.Split('\n')); }

        if(endatline == 0) {
            endatline = textline.Length - 1; }

        if (isactive) {
            EnableTextBox(); }
        else {
            DisableTextBox(); } }
	
	// Update is called once per frame
	void Update () {

        if(!isactive) {
            return; }

        thetext.text = textline[currentline];

        if(Input.GetKeyDown(KeyCode.Space)) {
            currentline += 1; }

        if(currentline > endatline) {
            DisableTextBox(); } }

    public void EnableTextBox() {
        textbox.SetActive(true);
        isactive = true;
        player.canmove = false;  }

    public void DisableTextBox() {
        textbox.SetActive(false);
        isactive = false;
        player.canmove = true; }

    public void ReloadScript(TextAsset thetext) {
        if (thetext != null) {
            textline = new string[1];
            textline = (thetext.text.Split('\n')); } }
}
