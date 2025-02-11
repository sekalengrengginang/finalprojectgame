﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.IO;

public class ScoreUi : MonoBehaviour
{
    public RowUi rowUi;
    public ScoreManager scoreManager;
    
    void Start()
    {
        name= PlayerPrefs.GetString("player_name");
        scoreManager.AddScore(new Score(name,HitungSkor.scoreValue));
        var scores = scoreManager.GetHighScores().ToArray();
        for (int i = 0; i < scores.Length; i++)
        {
            var row = Instantiate(rowUi, transform).GetComponent<RowUi>();
            row.rank.text = (i + 1).ToString();
            row.name.text = scores[i].name;
            row.score.text = scores[i].score.ToString();
        }
    }

}

