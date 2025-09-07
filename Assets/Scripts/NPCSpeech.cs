using UnityEngine;
using UnityEngine.InputSystem; // Required for new Input System

public class NPCSpeech : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Speak();
        }
    }

    public void Speak()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}