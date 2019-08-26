using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour {
    public GameObject [] objectS;
    public GameObject tutorialPanel;
    public GameObject gameMenu;
    public bool newGame;
    private int touchCount;
    private int checker;

    private Checker checkme;
    // Use this for initialization
    void Start () {
        checker = PlayerPrefs.GetInt ("Tutorial");
        if (checker == 0) {
            touchCount = 0;
            Time.timeScale = 0;
            gameMenu.SetActive (false);
            tutorialPanel.SetActive (true);
        }
        else {
            Time.timeScale = 1;
        }
	}
    public void HideObjects () {
        
        if (touchCount == 0) {
            objectS [0].SetActive (false);
            objectS [1].SetActive (true);
        }else if (touchCount == 1) {
            objectS [1].SetActive (false);
            objectS [2].SetActive (true);
        }else if (touchCount == 2) {
            objectS [2].SetActive (false);
            tutorialPanel.SetActive (false);
            gameMenu.SetActive (true);
            Time.timeScale = 1;
            PlayerPrefs.SetInt ("Tutorial", checker = 1);
            SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
        }
        touchCount++;
    }
}
