using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingEmulation : MonoBehaviour
{
    public Slider loadingBar;
    public Text loadingText;

    private void Start()
    {
        
    }
    private void Update()
    {
        loadingBar.value += Time.deltaTime * 3f;
        loadingText.text = (int)loadingBar.value + "%";

        if (loadingBar.value < 80f)
        {
            loadingBar.value += 3f;
        }
        else if (loadingBar.value > 80f)
        {
           
        }
       
    }
}
