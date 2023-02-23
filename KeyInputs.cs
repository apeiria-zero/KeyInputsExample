using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class KeyInputs : MonoBehaviour
{
    [SerializeField]
    Button button;
    [SerializeField]
    Text text;

    private delegate IEnumerator CoroutineDelegate();

    void Start()
    {
        CoroutineDelegate coroutineDelegate = InputCoroutine;
        button.onClick.AddListener(() =>
        {
            StartCoroutine(InputCoroutine());
        });
    }
    void Update()
    {

    }

    IEnumerator InputCoroutine()
    {
        Debug.Log("run");
        yield return new WaitUntil(() => Input.anyKeyDown);
        foreach (KeyCode code in Enum.GetValues(typeof(KeyCode)))
        {
            if (Input.GetKeyDown(code))
            {
                Debug.Log($"{code.ToString()}Ç™ì¸óÕÇ≥ÇÍÇ‹ÇµÇΩÅE");
                text.GetComponent<Text>().text = code.ToString();
            }
        }
    }
}
