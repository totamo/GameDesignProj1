using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour {

    Rigidbody2D rbody;
    Animator anim;
    public List<string> win_con = new List<string>();
    GameObject[] kids;
    public bool canmove;
    public bool kids_test = false;
    public bool wife_test = false;
    public bool dog_test = false;
    public AudioClip sound;

	// Use this for initialization
	void Start () {

        rbody = GetComponent<Rigidbody2D> ();
        anim = GetComponent<Animator> (); }
	
	// Update is called once per frame
	void Update () {

        if (!canmove) {
            return; }

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (movement_vector != Vector2.zero) {
            anim.SetBool("Is_Walking", true);
            anim.SetFloat("Input_x", movement_vector.x);
            anim.SetFloat("Inpuy_y", movement_vector.y); }
        else {
            anim.SetBool("Is_Walking", false); }

        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * 100); }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("AirFreshener"))
        {
            other.gameObject.SetActive(false);
            win_con.Add("AirFreshener");
            GetComponent<AudioSource>().PlayOneShot(sound);
        }

        if (other.gameObject.CompareTag("Bone"))
        {
            other.gameObject.SetActive(false);
            dog_test = true;
            win_con.Add("Bone");
            GetComponent<AudioSource>().PlayOneShot(sound);
        }

        if (other.gameObject.CompareTag("Cookie"))
        {
            other.gameObject.SetActive(false);
            kids_test = true;
            GetComponent<AudioSource>().PlayOneShot(sound);
        }

        if (other.gameObject.CompareTag("ToiletPaper"))
        {
            other.gameObject.SetActive(false);
            win_con.Add("ToiletPaper");
            GetComponent<AudioSource>().PlayOneShot(sound);
        }

        if (other.gameObject.CompareTag("Perfume"))
        {
            other.gameObject.SetActive(false);
            wife_test = true;
            GetComponent<AudioSource>().PlayOneShot(sound);
        }

        if (other.gameObject.CompareTag("Plunger"))
        {
            other.gameObject.SetActive(false);
            win_con.Add("Plunger");
            GetComponent<AudioSource>().PlayOneShot(sound);
        }

        if (other.gameObject.CompareTag("Kids"))
        {
            if (kids_test)
            {
                kids = GameObject.FindGameObjectsWithTag("Kids");
                foreach (GameObject go in kids)
                {
                    go.SetActive(false);
                }
            }
        }

        if (other.gameObject.CompareTag("Mom"))
        {
            if (wife_test)
            {
                other.gameObject.SetActive(false);
            }
        }

        if (other.gameObject.CompareTag("Dog"))
        {
            if (dog_test)
            {
                other.gameObject.SetActive(false);
            }
        }

        if (other.gameObject.CompareTag("Win"))
        {
            if (win_con.Contains("Plunger") && win_con.Contains("AirFreshener") && win_con.Contains("Plunger"))
            {
                //GetComponent<AudioSource>().PlayOneShot(sound);
                Application.LoadLevel("WinScreen");
            }
        }
    }
}
