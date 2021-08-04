using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GamerOverScreen : MonoBehaviour
{

    public Text Textopuntos;
    public void Setup(int score)
    {
        score = Scorescript.scoreValue;
        gameObject.SetActive(true);
  
        Textopuntos.text = "Helio Obtenido: " + score.ToString() ;
    }
         
    public void RestartButton()
    {
        SceneManager.LoadScene("Gameplay");
        Scorescript.scoreValue = 5;

    }

    public void ExitButton()
    {

        SceneManager.LoadScene("Mainmenu");
        Scorescript.scoreValue = 5;

    }



}
