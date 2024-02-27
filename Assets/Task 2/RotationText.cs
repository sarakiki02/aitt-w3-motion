using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Example : MonoBehaviour
{
    public TextMeshProUGUI accelerometerText;

    void Start()
    {
        //accelerometerText = GetComponent<TextMeshProUGUI>;

        accelerometerText.text =
            "X X Axis\nY Y Axis\nZ Z Axis";
    }

    void Update()
    {
        accelerometerText.text =
        "X Axis = " + Input.acceleration.x +
        "\nY Axis = " + Input.acceleration.y +
        "\nZ Axis = " + Input.acceleration.z;
    }
}
