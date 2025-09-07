using UnityEngine;
using TMPro; // For TMP Dropdown

public class MenuManager : MonoBehaviour
{
    [Header("Menu Panel")]
    public GameObject Panel; // The canvas or panel to hide

    public void OnStartButton()
    {
        Debug.Log("Start button clicked!");

        // Hide the menu
        if (Panel != null)
            Panel.SetActive(false);
        else
            Debug.LogWarning("Menu Panel is not assigned!");
    }
}