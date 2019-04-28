using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetAll : MonoBehaviour {

    public void Reset () {
        PlayerPrefs.SetInt ("Tutorial", 0); // Reset the tutorial
        for (int i = 1; i <= 5; i++) {
            PlayerPrefs.SetInt ("Level" + i, -1); //Reset the levels that complete;
        }
        for (int a = 1; a <= 5; a++) {
            PlayerPrefs.SetInt ("Com" + a, 0); //Reset the stars in each levels
        }
        PlayerPrefs.Save ();
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex); //Reload the Game
    }

}
