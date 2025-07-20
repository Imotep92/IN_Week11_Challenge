using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using TMPro;
using UnityEngine.VFX;

public class GameManager : MonoBehaviour
{
    public static GameManager _gameManager;
    public Button _button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        _gameManager = this;
    }

    void Start()
    {
        _button = GetComponent<Button>(); // Get Button component
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
