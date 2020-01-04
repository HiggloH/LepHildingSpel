using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public static Dictionary<string, float> directions = new Dictionary<string, float>();
    void Awake()
    {
        directions.Add("up", 1);
        directions.Add("down", -1);
        directions.Add("right", 1);
        directions.Add("left", -1);
    }
}
