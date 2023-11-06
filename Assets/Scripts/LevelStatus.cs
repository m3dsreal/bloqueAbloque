#nullable enable

using System;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class LevelStatus : MonoBehaviour
{
    [SerializeField] private Slider? _barProgressNumbers;
    [SerializeField] private Slider? _barProgressABC;
    [SerializeField] private GameObject? _popupCorrect;
    [SerializeField] private GameObject? _popupIncorrect;
    [SerializeField] private GameObject _congrulations;
    [SerializeField] private TextMeshProUGUI _setText;
    [SerializeField] private bool correctValue = true;
    [SerializeField] private string[] Numbers; 
    [SerializeField] private int count;
    [SerializeField] private float _updateSlider;

    private int valNumber;

    void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Numbers.Length);
        if(_barProgressNumbers != null) _barProgressNumbers.value = .1f;
        if(_barProgressABC != null) _barProgressABC.value = 0.037f;

        Debug.Log(valNumber);
        Debug.Log(_updateSlider);

        count = 0;
        _setText.text = Numbers[count];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkAnswer()
    {
        //

        if (correctValue == true)
        {
           if(_popupCorrect != null) _popupCorrect.SetActive(true);
        }
        else
        {
            if(_popupIncorrect != null)_popupIncorrect.SetActive(true);
        }
    }


    public void nextQuestion()
    {
        if (count < Numbers.Length)
        {
            count++;
            _setText.text = Numbers[count];
            if (_barProgressNumbers != null) _barProgressNumbers.value += .1f;
            if (_barProgressABC != null) _barProgressABC.value += 0.037f;
            if (_popupCorrect != null) _popupCorrect.SetActive(false);
        }
        else 
        {
            _congrulations.SetActive(true);
        }

    }

    public void resetGame()
    {
        if(_barProgressNumbers != null) _barProgressNumbers.value = .1f;
        if (_barProgressABC != null) _barProgressABC.value = 0.037f;
        count = 0;
        _setText.text = Numbers[count];
        if(_popupIncorrect != null) _popupIncorrect.SetActive(false);


    }

    public void returnHome()
    {
        SceneManager.LoadScene(3);
    }
}
