﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSettings : MonoBehaviour
{
    //OBSOLETE; replaced by Ivan's save system
    //Stores a series of settings that are loaded into the next scene
    public float maxhealth;

    void Awake()
    {
        
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += SettingAssigner;
    }

    void SettingAssigner(Scene scene, LoadSceneMode mode)
    {
        if(scene.name != "MainMenu")
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>().MaxHealth = maxhealth;
        }
    }

    private void Start()
    {
        Destroy(this.gameObject);
    }

}
