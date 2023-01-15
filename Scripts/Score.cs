using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;

    public Text scoreText;

    private float initOffset = -5;

    void Update()
    {
        scoreText.text = (player.position.z - initOffset).ToString("0");
    }

}