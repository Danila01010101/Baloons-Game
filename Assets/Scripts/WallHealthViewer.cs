using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class WallHealthViewer : MonoBehaviour
{
    private DestroyOnCollision _ballDetector;
    private int _health;
    private TextMeshProUGUI _healthOnUI;

    void Start()
    {
        _ballDetector = GetComponent<DestroyOnCollision>();
        _healthOnUI = GetComponentInChildren<Canvas>().GetComponentInChildren<TextMeshProUGUI>();
        UpdateScore();
    }
    private void OnEnable()
    {
        DestroyOnCollision.OnHealthChanged += UpdateScore;
    }

    private void OnDisable()
    {
        DestroyOnCollision.OnHealthChanged += UpdateScore;
    }

    private void UpdateScore()
    {
        _health = _ballDetector.GetHealth();
        _healthOnUI.text = _health.ToString();
    }
}
