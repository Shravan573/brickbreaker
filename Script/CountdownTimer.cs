using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 300f;

    [SerializeField]  Text countdownText;

    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {
        currentTime -= 1 * Time.deltaTime;

    }
}
