using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    int coin = 0;
    public Text coin_Text;
    public int coin_no;
    // Start is called before the first frame update
    void Start()
    {
        coin_Text.text = coin.ToString();
        coin_no = FindObjectsOfType<coin>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        coin_no = FindObjectsOfType<coin>().Length;
        if(coin_no<=0)
        {
            SceneManager.LoadScene(0);
            print("You Won");
        }
    }
    public void coin_Collected()
    {
        coin += 1;
        coin_Text.text = coin.ToString();
    }
}
