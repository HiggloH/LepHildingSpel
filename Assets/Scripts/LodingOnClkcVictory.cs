﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LodingOnClkcVictory : MonoBehaviour
{
    public void LoadScene(int level)
    {
        if (Player.Win1 == false)
        {
            Application.LoadLevel(level);
            Player.Win1 = true;
        }
        else
        {
            Application.LoadLevel("Level3");
        }
    }
}
