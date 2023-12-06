using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour
{
    // Start is called before the first frame update
    public void menu_Start()
    {
        SceneManager.LoadScene(1);
        
    }
    public void menu_Quit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    
}
