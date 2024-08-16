using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject InfoPanel;

    void Start()
    {
        MenuPanel.SetActive(true);
        InfoPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void InfoButton()
    {
        MenuPanel.SetActive(false );
        InfoPanel.SetActive(true);
    }

    public void BackButton()
    {
        MenuPanel.SetActive(true );
        InfoPanel.SetActive(false);
        Debug.Log("back");

    }
}
