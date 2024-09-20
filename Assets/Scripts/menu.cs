using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject MenuPanel;
    public GameObject InfoPanel;
    public GameObject CreditPanel;

    void Start()
    {
        MenuPanel.SetActive(true);
        InfoPanel.SetActive(false);
        CreditPanel.SetActive(false);
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
        CreditPanel.SetActive(false);
    }

    public void BackButton()
    {
        MenuPanel.SetActive(true );
        InfoPanel.SetActive(false);
        CreditPanel.SetActive(false);

    }

    public void CreditButton()
    {
        MenuPanel.SetActive(false );
        InfoPanel.SetActive(false);
        CreditPanel.SetActive(true);
        Debug.Log("credit");
    }
}
