using System;

namespace Exercise_12
{
    class Student : IStudent
    {        
        private List<string> _testsTaken = new();
        public string[] TestsTaken
        {
            get
            {
                return _testsTaken.Count == 0 ? new[] { "No tests taken" } : _testsTaken.ToArray();
            }
        }

        public void TakeTest(Testpaper paper, string[] answers)
        {
            int correctAnswers = 0;
            int passMark = Convert.ToInt32(paper.PassMark.Substring(0, paper.PassMark.Length-1));

            for (int i = 0; i < answers.Length; i++)
            {
                if (paper.MarkScheme[i] == answers[i])
                {
                    correctAnswers++;
                }
            }

            int testResult = (correctAnswers * 100) / answers.Length;

            if (testResult >= passMark)
            {
                _testsTaken.Add($"{paper.Subject}: Passed! ({testResult}%)");
            }
            else
            {
                _testsTaken.Add($"{paper.Subject}: Failed! ({testResult}%)");
            }  
        }
    }
}