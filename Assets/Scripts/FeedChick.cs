using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedChick : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (GameData.water > 0)
        {
            GameData.water = GameData.water - 1; //add water to chicken's holdings
        }
        if (GameData.corn > 0)
        {
            GameData.corn = GameData.corn - 1; //add corn to the chicken's holdings
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
