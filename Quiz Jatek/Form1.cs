using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class Form1 : Form
    {
        private readonly List<Question> questions = new List<Question>
        {
            new Question("Ki nyerte meg a Mr. Olympia versenyt 7-szer?",
                new[] { "Arnold Schwarzenegger", "Jay Cutler", "Ronnie Coleman", "Lee Haney" }, 0),
            new Question("Melyik híresség ismert a 'The King' becenévrõl?",
                new[] { "Phil Heath", "Ronnie Coleman", "Kai Greene", "Dorian Yates" }, 1),
            new Question("Ki a 'The Shadow' becenéven ismert?",
                new[] { "Frank Zane", "Shawn Ray", "Dorian Yates", "Chris Bumstead" }, 2),
            new Question("Mekkora Larry Wheels hivatalos fekvenyomó rekordja?",
                new[] { "275 kg", "307 kg", "320 kg", "290 kg" }, 1),
            new Question("Mennyi Larry Wheels hivatalos guggolási rekordja?",
                new[] { "400 kg", "375 kg", "410 kg", "420 kg" }, 2),
            new Question("Mennyi Larry Wheels húzódzkodás rekordja (súlyos húzódzkodásban)?",
                new[] { "100 kg", "115 kg", "90 kg", "130 kg" }, 3),
            new Question("Mennyi Anatoly a világrekorder ukrán erõemelõ fekvenyomása?",
                new[] { "305 kg", "320 kg", "335 kg", "345 kg" }, 2),
            new Question("Melyik gyakorlatban világrekorder Hafthor Bjornsson (The Mountain)?",
                new[] { "Guggolás", "Fekvenyomás", "Deadlift (felhúzás)", "Overhead press" }, 2),
            new Question("Mekkora Hafthor Bjornsson hivatalos deadlift rekordja?",
                new[] { "450 kg", "501 kg", "500 kg", "515 kg" }, 1),
            new Question("Ki tartja a világ legnagyobb szumó deadlift rekordját?",
                new[] { "Eddie Hall", "Jamal Browner", "Hafthor Bjornsson", "Kirill Sarychev" }, 1),
            new Question("Mennyi Jamal Browner szumó deadlift rekordja?",
                new[] { "475 kg", "495 kg", "500 kg", "460 kg" }, 2),
            new Question("Melyik testépítõ híres az 'Iron Generation' YouTube sorozatból?",
                new[] { "Larry Wheels", "Simeon Panda", "Mike O'Hearn", "Chris Bumstead" }, 0),
            new Question("Mekkora Kirill Sarychev hivatalos fekvenyomási világrekordja?",
                new[] { "335 kg", "350 kg", "360 kg", "370 kg" }, 2),
            new Question("Ki nyerte a Classic Physique kategóriát Mr. Olympia-n 4 alkalommal?",
                new[] { "Chris Bumstead", "Breon Ansley", "Terrence Ruffin", "Arash Rahbar" }, 0),
            new Question("Melyik testépítõ ismert a 'Mass Monster' stílusról?",
                new[] { "Ronnie Coleman", "Jay Cutler", "Markus Ruhl", "Branch Warren" }, 2),
            new Question("Ki nyerte a Mr. Olympia-t 4 alkalommal és híres a 'Quad Stomp'-ról?",
                new[] { "Jay Cutler", "Ronnie Coleman", "Phil Heath", "Kai Greene" }, 0),
            new Question("Mennyi Eddie Hall hivatalos deadlift rekordja?",
                new[] { "500 kg", "501 kg", "490 kg", "495 kg" }, 0),
            new Question("Melyik testépítõ ismert az 'Aesthetic Physique' stílusról?",
                new[] { "Frank Zane", "Arnold Schwarzenegger", "Flex Wheeler", "Chris Bumstead" }, 0),
        };

        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            if (questions.Count > 0)
                LoadQuestion();
            else
                MessageBox.Show("Nincsenek kérdések a játékhoz!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var currentQuestion = questions[currentQuestionIndex];
                lblQuestion.Text = $"Kérdés {currentQuestionIndex + 1}: {currentQuestion.Text}";
                btnAnswer1.Text = currentQuestion.Answers[0];
                btnAnswer2.Text = currentQuestion.Answers[1];
                btnAnswer3.Text = currentQuestion.Answers[2];
                btnAnswer4.Text = currentQuestion.Answers[3];
            }
            else
            {
                ShowResults();
            }
        }

        private void CheckAnswer(int selectedAnswerIndex)
        {
            if (currentQuestionIndex >= questions.Count)
                return;

            var currentQuestion = questions[currentQuestionIndex];
            if (selectedAnswerIndex == currentQuestion.CorrectAnswerIndex)
            {
                score++;
                MessageBox.Show("Helyes válasz!", "Gratulálok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Helytelen válasz! A helyes válasz: {currentQuestion.Answers[currentQuestion.CorrectAnswerIndex]}",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            currentQuestionIndex++;
            LoadQuestion();
        }

        private void ShowResults()
        {
            MessageBox.Show($"Vége a játéknak! Pontszámod: {score}/{questions.Count}", "Eredmények", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnAnswer1_Click(object sender, EventArgs e) => CheckAnswer(0);
        private void btnAnswer2_Click(object sender, EventArgs e) => CheckAnswer(1);
        private void btnAnswer3_Click(object sender, EventArgs e) => CheckAnswer(2);
        private void btnAnswer4_Click(object sender, EventArgs e) => CheckAnswer(3);
    }

    public class Question
    {
        public string Text { get; }
        public string[] Answers { get; }
        public int CorrectAnswerIndex { get; }

        public Question(string text, string[] answers, int correctAnswerIndex)
        {
            if (answers == null || answers.Length != 4)
                throw new ArgumentException("Pontosan 4 válaszlehetõség szükséges!");

            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
