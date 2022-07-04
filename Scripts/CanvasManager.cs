using UnityEngine;
using TMPro;

public class CanvasManager : MonoBehaviour
{
    private TextMeshProUGUI Score;
    private TextMeshProUGUI Lose;

    private int ScoreInt;
    private int LoseInt;

    private void Start()
    {
        Score = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>();
        Lose = GameObject.FindGameObjectWithTag("Lose").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        Score.SetText(ScoreInt.ToString());
        Lose.SetText(LoseInt.ToString());
    }

    public void ScorePlusOne()
    {
        ScoreInt++;
    }

    public void LosePlusOne()
    {
        LoseInt++;
    }
}
