using UnityEngine;

public class QuizGradeCalculator : MonoBehaviour
{
    // variable for grade amount
    // variable for total score
    // calculate random grades between 0 and 100
    // return the average score with a grade
    // if score is greater or equal to 85 -> A
    // if score is greater or equal to 70 but smaller as 85 -> B
    // if score is greater or equal to 50 but smaller as 70 -> c
    // if score is less than 50 -> F
        
    [SerializeField] private int[] quizGrades;
    [SerializeField] private int totalScore;
    [SerializeField] private int averageScore;
    private void Start()
    {
        CalculateScores();
        CheckRank();
    }

    private void CalculateScores()
    {
        for (int i = 0; i < quizGrades.Length; i++)
        {
            quizGrades[i] = Random.Range(0, 101);
            totalScore += quizGrades[i];
        }

        averageScore = totalScore / quizGrades.Length;
    }
        
    private void CheckRank()
    {
        if (averageScore >= 85)
            Debug.Log("Congrats! You scored an 'A'!");

        else if (averageScore < 85 && averageScore >= 70)
            Debug.Log("Good work! You scored a 'B'!");
            
        else if (averageScore < 70 && averageScore >= 50)
            Debug.LogWarning("You scored a 'C'!");
            
        else if (averageScore < 50)
            Debug.LogError("Randomness doesn't like you! You scored an 'F'!");
    }
}