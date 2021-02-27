using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedCar : MonoBehaviour
{
    public Slider CarSilder;
    public static float change = 0f;

    public void changeValue()
    {
        change = CarSilder.value;
    }
}
