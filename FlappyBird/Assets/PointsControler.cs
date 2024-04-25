using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointsControler : MonoBehaviour
{
    public TextMeshProUGUI textField;
    public BirdController birdController;

    // Start is called before the first frame update
    void Start()
    {
        textField.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        textField.text = birdController.Points.ToString();
    }
}
