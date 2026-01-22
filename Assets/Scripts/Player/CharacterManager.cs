using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CharacterManager : MonoBehaviour
{

    public int characterIndex;
 
    void Start()
    {
        characterIndex = PlayerPrefs.GetInt("SelectedCharacter", 0);
    }
}
