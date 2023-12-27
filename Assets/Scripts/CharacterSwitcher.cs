using RedBlueGames.Tools.TextTyper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSwitcher : MonoBehaviour
{
    public Characters[] characters;
    
    public Text nameText;
    public TextTyper textTyper;
    public Image contentImage;

    public GameObject glitchEffect;
    public GameObject SearchText;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeContent(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeContent(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeContent(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeContent(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ChangeContent(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ChangeContent(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            ChangeContent(6);
        }
    }
    IEnumerator GlitchDelay()
    {
        glitchEffect.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        glitchEffect.SetActive(false);
    }
    public void ChangeContent(int i)
    {
        SearchText.SetActive(false);
        StartCoroutine(GlitchDelay());

        nameText.text = characters[i].nameCharater;
        contentImage.sprite = characters[i].characterImage;
        textTyper.TypeText(characters[i].contentCharacter, 0.07f);
    }
}
