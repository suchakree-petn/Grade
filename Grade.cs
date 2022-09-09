public class Grade
{
    public int[] Score = new int[8];
    public void ScoreArray(){
        for(int i=0;i<8;i++){
            Score[i] = ScoreConvertStringToInt();
        }
    }

    public int ScoreConvertStringToInt()
    {
        string StrScore = Console.ReadLine();
        if (int.TryParse(StrScore, out int Number))
        {
            return Number;
        }
        else
        {
            throw new Exception("Plase enter score correctly");
        }
    }
    public string ShowGrade(int Grade){
        return Grade;
    }
    public int ShowScore(int Score){
        return Score;
    }
    public string ConvertScoreToGrade(int Score)
    {
        if (Score > 100 || Score < 0)
        {
            throw new Exception("Please input Score 1-100");
        }
        if (IsGradeA(Score))
        {
            return "Grade A";
        }
        else if
        (
            IsGradeBplus(Score)
        )
        {
            return "Grade B+";
        }
        else if
        (
            IsGradeB(Score))
        {
            return "Grade B";
        }
        else if
        (
            IsGradeCplus(Score))
        {
            return "Grade C+";
        }
        else if
        (
            IsGradeC(Score))
        {
            return "Grade C";
        }
        else if
        (
            IsGradeDplus(Score))
        {
            return "Grade D+";
        }
        else if
        (
            IsGradeD(Score))
        {
            return "Grade D";
        }
        else if (IsGradeF(Score))
        {
            return "Grade F";
        }
        return "0";
    }
    public static bool IsGradeA(int Score)
    {
        return Score <= 100 && Score >= 80;
    }
    public static bool IsGradeBplus(int Score)
    {
        return Score < 80 && Score >= 75;
    }
    public static bool IsGradeB(int Score)
    {
        return Score < 75 && Score >= 70;
    }
    public static bool IsGradeCplus(int Score)
    {
        return Score < 70 && Score >= 65;
    }
    public static bool IsGradeC(int Score)
    {
        return Score < 65 && Score >= 60;
    }
    public static bool IsGradeDplus(int Score)
    {
        return Score < 60 && Score >= 55;
    }
    public static bool IsGradeD(int Score)
    {
        return Score < 55 && Score >= 50;
    }
    public static bool IsGradeF(int Score)
    {
        return Score < 50 && Score >= 0;
    }
}