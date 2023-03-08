using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
  
    [Header("Timeline")]
    public PlayableDirector direcotor; 
    [Header("UI")]
    public GameObject canvas; 
    public GameObject intro_Panel; 
    [Header("Camera")]
    public GameObject main_camera; 
    public GameObject timeLine_camera; 

    // Start is called before the first frame update
    void Start()
    {
       
        main_camera.SetActive(true);
        canvas.SetActive(true);
        direcotor.played += Director_played;
        direcotor.stopped += Director_stopped;
    }
    public void Play_TimeLine()
    {
        direcotor.Play();
    }
   public void Director_played(PlayableDirector obj)
    {
        main_camera.SetActive(false);
        canvas.SetActive(false);
    }
    public void Director_stopped(PlayableDirector obj)
    {
        timeLine_camera.SetActive(false);
        main_camera.SetActive(true);
        canvas.SetActive(true);
        intro_Panel.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
