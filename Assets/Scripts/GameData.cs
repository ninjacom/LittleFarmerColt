using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour {

    private static int _corn = 0;
    private static int _water = 0;

    public static int water
    {
        get { return _water; }
        set { _water = value; }
    }

    public static int corn
    {
        get { return _corn; }
        set { _corn = value; }
    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
