using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsManager : MonoBehaviour {

    public GameObject [] slots;
    private int Best = 0;
    private int levels = 1;
    private int total;
    private string level = "Level";
    // Use this for initialization
    void Start () {
        for (int i = 0; i < 5; i++) {
            total = levels + i;
            //Debug.Log (level + total);
            Best = PlayerPrefs.GetInt (level + total);
            for (int a = 0; a <= Best; a++) {
                slots [i].transform.GetChild (a).gameObject.SetActive (true);
            }
            
        }
        

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void GetChildren () {
    }
    void GetSlots () {
    }
}
