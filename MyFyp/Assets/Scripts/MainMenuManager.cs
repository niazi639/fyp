using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuManager : MonoBehaviour
{
    public Slider musicvalue;
    public Slider soundvalue;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void SetVolumn()
    {
        Debug.Log("volume");
        PlayerPrefs.SetFloat("music", musicvalue.value);
        PlayerPrefs.SetFloat("sound", soundvalue.value);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
