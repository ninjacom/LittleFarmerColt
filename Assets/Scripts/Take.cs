using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour {

    Animator anim;
    int takeHash = Animator.StringToHash("Take");

    public AudioClip points;
    private AudioSource source;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();

        source = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.T))
        {
            anim.Play(takeHash);

            GameData.water = GameData.water + 1;
            Debug.Log(GameData.water);

            source.PlayOneShot(points);
        }
        
	}
}
