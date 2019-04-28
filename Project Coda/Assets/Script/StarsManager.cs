using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsManager : MonoBehaviour {

    public GameObject [] slots;
    private int Best0, Best1, Best2, Best3, Best4;

    void Start () {
        if (PlayerPrefs.GetInt ("Com1") == 1) {
            Best0 = PlayerPrefs.GetInt ("Level1");
            for (int a = 0; a <= Best0; a++) {
                slots [0].transform.GetChild (a).gameObject.SetActive (true);
            }
        }
        if (PlayerPrefs.GetInt ("Com2") == 1) {
            Best1 = PlayerPrefs.GetInt ("Level2");
            for (int a = 0; a <= Best1; a++) {
                slots [1].transform.GetChild (a).gameObject.SetActive (true);

            }
        }
        if (PlayerPrefs.GetInt ("Com3") == 1) {
            Best2= PlayerPrefs.GetInt ("Level3");
            for (int a = 0; a <= Best2; a++) {
                slots [2].transform.GetChild (a).gameObject.SetActive (true);

            }
        }
        if (PlayerPrefs.GetInt ("Com4") == 1) {
            Best3 = PlayerPrefs.GetInt ("Level4");
            for (int a = 0; a <= Best3; a++) {
                slots [3].transform.GetChild (a).gameObject.SetActive (true);

            }
        }
        if (PlayerPrefs.GetInt ("Com5") == 1) {
            Best4 = PlayerPrefs.GetInt ("Level5");
            for (int a = 0; a <= Best4; a++) {
                slots [4].transform.GetChild (a).gameObject.SetActive (true);

            }
        }

    }
}
