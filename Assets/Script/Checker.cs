﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Checker : MonoBehaviour {

    public int num;
    public float timer;
    public Slider time;
    //public float minutes { get { return Mathf.Floor (timer / 60f); } }
    //public float seconds { get { return Mathf.Floor (timer % 60f); } }

    public GameObject[] Star;
    public GameObject [] Text;
    public GameObject Gameover;
    public GameObject GamePanel;
    public GameObject Next;
    public GameObject Pause;
    public GameObject Play;


    private ManageDragAndDrop drag;
    private int Best;
    public int check;
    public GameObject [] objects;
    public Text txtTimer;

    void Start () {
        txtTimer.text = (timer % 60).ToString ("00");
        time.maxValue = timer;
        time.value = timer;
        check=PlayerPrefs.GetInt ("Tutorial");
        if (check == 1) {
            Time.timeScale = 1;
            for (int i = 0; i <= objects.Length; i++) {
                objects [i].GetComponent<Image> ().raycastTarget = true;
            }
        }
        
    }


	// Update is called once per frame
	void Update () {
        if (check == 1) {
            timer -= Time.deltaTime;
            time.value = timer;
            txtTimer.text = string.Format("{0}:{1}", Mathf.Floor(timer / 60).ToString ("00"), (timer % 60).ToString ("00"));
        }

        if (timer <= 0)
        {
            StarReward (3);
            Time.timeScale = 0;
            txtTimer.text = string.Format ("{0}:{1}", 0, 0);
        }

        if (num == 0)
        {
            Time.timeScale = 0;
            if (SceneManager.GetActiveScene().name == "Level1")
            {
                PlayerPrefs.SetInt ("Com1", 1);
                if (timer <= 40 && timer >=  20)
                {
                    StarReward (2);
                }
                if (timer <= 19.99 && timer >= 10)
                {
                    StarReward (1);
                }
                if (timer <= 9.99 && timer >= 0.01)
                {
                    StarReward (0);
                }
            }

            if (SceneManager.GetActiveScene ().name == "Level2")
            {
                PlayerPrefs.SetInt ("Com2", 1);
                if (timer <= 40 && timer >= 25)
                {
                    StarReward (2);
                }
                if (timer <= 24.99 && timer >= 15)
                {
                    StarReward (1);
                }
                if (timer <= 14.99 && timer >= 0.01)
                {
                    StarReward (0);
                }
            }

            if (SceneManager.GetActiveScene ().name == "Level3")
            {
                PlayerPrefs.SetInt ("Com3", 1);
                if (timer <= 50 && timer >= 30)
                {
                    StarReward (2);
                }
                if (timer <= 29.99 && timer >= 15)
                {
                    StarReward (1);
                }
                if (timer <= 14.99 && timer >= 0.01)
                {
                    StarReward (0);
                }
            }

            if (SceneManager.GetActiveScene ().name == "Level4")
            {
                PlayerPrefs.SetInt ("Com4", 1);
                if (timer <= 60 && timer >= 35)
                {
                    StarReward (2);
                }
                if (timer <= 34.99 && timer >= 15)
                {
                    StarReward (1);
                }
                if (timer <= 14.99 && timer >= 0.01)
                {
                    StarReward (0);
                }
            }

            if (SceneManager.GetActiveScene ().name == "Level5")
            {
                PlayerPrefs.SetInt ("Com5", 1);
                if (timer <= 55 && timer >= 37)
                {
                    StarReward (2);
                }
                if (timer <= 36.99 && timer >= 20)
                {
                    StarReward (1);
                }
                if (timer <= 19.99 && timer >= 0.01)
                {
                    StarReward (0);
                }
            }
        }

    }

    public void PauseTheGame () {
        Pause.SetActive (false);
        Play.SetActive (true);
        Time.timeScale = 0;
        StarReward (4); 
    }

    public void PlayTheGame () {
        Play.SetActive (false);
        Pause.SetActive (true);
        Time.timeScale = 1;
        GamePanel.SetActive (false);
        for (int i = 0; i <= objects.Length; i++) {
            objects [i].GetComponent<Image> ().raycastTarget = true;
        }
    }

    public void NextLevel ()
    {
        SaveAll ();
        Time.timeScale = 1;
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
    }

    public void Retry () {
        SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
    }

    public void BacktoMain () {
        SaveAll ();
        SceneManager.LoadScene (0);
    }
    public void SaveAll () {
        PlayerPrefs.Save ();
    }
    public void StarReward (int number) {
		
		GamePanel.SetActive (true);

        PlayerPrefs.GetInt (SceneManager.GetActiveScene ().name, Best);
        if (Best <= 2) {
            Best = number;
            PlayerPrefs.SetInt (SceneManager.GetActiveScene ().name, Best);

        }
        switch (number) {
            case 0: Star [0].SetActive (true);
                    Text [0].SetActive (true);
                    Next.SetActive (true);
                    Pause.SetActive (false);
                    Play.SetActive (false);
                    break;
            case 1: Star [1].SetActive (true);
                    Text [1].SetActive (true);
                    Next.SetActive (true);
                    Pause.SetActive (false);
                    Play.SetActive (false);
                    break;
            case 2: Star [2].SetActive (true);
                    Text [2].SetActive (true);
                    Next.SetActive (true);
                    Pause.SetActive (false);
                    Play.SetActive (false);
                    break;
            case 3: Gameover.SetActive (true);
                    Next.SetActive (false);
                    break;
            case 4: for (int i = 0; i < objects.Length; i++) {
                        objects [i].GetComponent<Image>().raycastTarget = false;
                    }
                    Next.SetActive (false);
                    break;

        }    
    }

}
