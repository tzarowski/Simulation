using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManagerScript : MonoBehaviour {

    public static int score;
    public GameObject ScoreText;


    // Use this for initialization
    void Start () {
        score = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        ScoreText.GetComponent<TextMesh>().text = score.ToString();

        if (score >= 10)
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
	}
}
