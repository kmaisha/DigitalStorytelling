using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNextDialogueSound : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public AudioClip sound; // sound effect to play when transitioning

    void ClickChoiceSound()
    {
        newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        AudioSource.PlayClipAtPoint(sound, transform.position);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
