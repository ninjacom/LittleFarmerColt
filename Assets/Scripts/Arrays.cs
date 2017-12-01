using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

    int[,] pigletArray = new int[10, 3];
    int[,] pigArray = new int[10, 3];
    int[,] chickArray = new int[10, 3];
    int[,] chickenArray = new int[10, 3];

    // Use this for initialization
    void Start () {
		
        for(int i = 0; i < 10; i++)
        {
            //piglet Array initial values
            pigletArray[i, 0] = 1; //visible: 0=no; 1=yes
            pigletArray[i, 1] = 0; //corn
            pigletArray[i, 2] = 0; //water

            //adult pig Array initial values
            pigletArray[i, 0] = 0; //visible: 0=no; 1=yes
            pigletArray[i, 1] = 0; //corn
            pigletArray[i, 2] = 0; //water

            //baby chick Array initial values
            chickArray[i, 0] = 1; //visible: 0=no; 1=yes
            chickArray[i, 1] = 0; //corn
            chickArray[i, 2] = 0; //water

            //adult chicken Array initial values
            chickenArray[i, 0] = 0; //visible: 0=no; 1=yes
            chickenArray[i, 1] = 0; //corn
            chickenArray[i, 2] = 0; //water
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
