using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSceneOnClick : MonoBehaviour {

    public void LoadScene (int scene)
    {
        Application.LoadLevel(scene);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
