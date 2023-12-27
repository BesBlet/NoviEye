using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public LoadingEmulation loadingEmulation;

    public GameObject mainMenu;
    public GameObject loadingScreen;
    public GameObject characterScreen;

    private void Update()
    {
        if (loadingEmulation.loadingBar.value >= loadingEmulation.loadingBar.maxValue)
        {
            StartCoroutine(LoadingDelay());
        }
    }
    IEnumerator LoadingDelay()
    {
        yield return new WaitForSeconds(2f);
        mainMenu.SetActive(false);
        loadingScreen.SetActive(false);
        characterScreen.SetActive(true);
    }
}
