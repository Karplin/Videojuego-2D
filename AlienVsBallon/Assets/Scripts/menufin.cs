using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menufin : MonoBehaviour
{
    [SerializeField] GameObject menuf;

    void Update()
    {
        if (Scorescript.scoreValue > 499)
        {
            menuf.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Home(int SceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneID);
        Scorescript.scoreValue = 5;
            
    }
}
