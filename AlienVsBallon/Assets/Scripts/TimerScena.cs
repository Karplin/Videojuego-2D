using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TimerScena : MonoBehaviour
{
    // Start is called before the first frame update
    public float timestart = 0.0f;
    public float timeend = 51.0000f;
    public float tiempo = 5.0f;
    public string escena;
    public Text eltexto;

    void Start()
    {

       
    }

    // Update is called once per frame
    public void Update()
    {
        
        tiempo += Time.deltaTime;
        eltexto.text = tiempo.ToString();
        if (tiempo > timeend)
        {
            SceneManager.LoadScene(escena);
        }

    }
    void Skip(float timestart, float timeend = 1.0f, string escena = "Mainmenu")
    {
       
    }


}
