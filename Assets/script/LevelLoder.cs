﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoder : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;

    public void LoadLevel(int sceneIndex)
    {
        // AsyncOperation operation =  SceneManager.LoadSceneAsync(sceneIndex);

        StartCoroutine(LoadAsynchronously(sceneIndex));
        
    }

    IEnumerator LoadAsynchronously(int sceneIndex) {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            //Debug.Log(progress);
            slider.value = progress;
            progressText.text = progress * 100f +"%";



            yield return null;
        }
    }

	// Use this for initialization
	/*void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
