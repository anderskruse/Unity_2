using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpCounter : MonoBehaviour

{
    [SerializeField] TextMeshProUGUI counter;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void counterText()
    {
        counter.text = "Score: " + score.ToString();
    }

   public void increment()
    {
        score++;
        counterText();
    }
}
