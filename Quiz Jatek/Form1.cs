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
            new Question("Melyik h�ress�g ismert a 'The King' becen�vr�l?",
                new[] { "Phil Heath", "Ronnie Coleman", "Kai Greene", "Dorian Yates" }, 1),
            new Question("Ki a 'The Shadow' becen�ven ismert?",
                new[] { "Frank Zane", "Shawn Ray", "Dorian Yates", "Chris Bumstead" }, 2),
            new Question("Mekkora Larry Wheels hivatalos fekvenyom� rekordja?",
                new[] { "275 kg", "307 kg", "320 kg", "290 kg" }, 1),
            new Question("Mennyi Larry Wheels hivatalos guggol�si rekordja?",
                new[] { "400 kg", "375 kg", "410 kg", "420 kg" }, 2),
            new Question("Mennyi Larry Wheels h�z�dzkod�s rekordja (s�lyos h�z�dzkod�sban)?",
                new[] { "100 kg", "115 kg", "90 kg", "130 kg" }, 3),
            new Question("Mennyi Anatoly a vil�grekorder ukr�n er�emel� fekvenyom�sa?",
                new[] { "305 kg", "320 kg", "335 kg", "345 kg" }, 2),
            new Question("Melyik gyakorlatban vil�grekorder Hafthor Bjornsson (The Mountain)?",
                new[] { "Guggol�s", "Fekvenyom�s", "Deadlift (felh�z�s)", "Overhead press" }, 2),
            new Question("Mekkora Hafthor Bjornsson hivatalos deadlift rekordja?",
                new[] { "450 kg", "501 kg", "500 kg", "515 kg" }, 1),
            new Question("Ki tartja a vil�g legnagyobb szum� deadlift rekordj�t?",
                new[] { "Eddie Hall", "Jamal Browner", "Hafthor Bjornsson", "Kirill Sarychev" }, 1),
            new Question("Mennyi Jamal Browner szum� deadlift rekordja?",
                new[] { "475 kg", "495 kg", "500 kg", "460 kg" }, 2),
            new Question("Melyik test�p�t� h�res az 'Iron Generation' YouTube sorozatb�l?",
                new[] { "Larry Wheels", "Simeon Panda", "Mike O'Hearn", "Chris Bumstead" }, 0),
            new Question("Mekkora Kirill Sarychev hivatalos fekvenyom�si vil�grekordja?",
                new[] { "335 kg", "350 kg", "360 kg", "370 kg" }, 2),
            new Question("Ki nyerte a Classic Physique kateg�ri�t Mr. Olympia-n 4 alkalommal?",
                new[] { "Chris Bumstead", "Breon Ansley", "Terrence Ruffin", "Arash Rahbar" }, 0),
            new Question("Melyik test�p�t� ismert a 'Mass Monster' st�lusr�l?",
                new[] { "Ronnie Coleman", "Jay Cutler", "Markus Ruhl", "Branch Warren" }, 2),
            new Question("Ki nyerte a Mr. Olympia-t 4 alkalommal �s h�res a 'Quad Stomp'-r�l?",
                new[] { "Jay Cutler", "Ronnie Coleman", "Phil Heath", "Kai Greene" }, 0),
            new Question("Mennyi Eddie Hall hivatalos deadlift rekordja?",
                new[] { "500 kg", "501 kg", "490 kg", "495 kg" }, 0),
            new Question("Melyik test�p�t� ismert az 'Aesthetic Physique' st�lusr�l?",
                new[] { "Frank Zane", "Arnold Schwarzenegger", "Flex Wheeler", "Chris Bumstead" }, 0),
            new Question("Melyik �vben nyerte Kevin Levrone az els� IFBB Mr. Olympia verseny�t?",
                new[] { "1992", "1996", "1991", "1990" }, 1),
             new Question("Milyen s�llyal nyomott Kevin Levrone a h�res fekvenyom� rekordj�n�l?",
                new[] { "300font", "400font", "500font", "550font" }, 1),
             new Question("Mi volt Jay Cutler egyik legnagyobb er�ss�ge a versenyeken?",
                new[] { "Izomt�mege", "Kond�ci�ja", "Szimmetri�ja", "Er�nl�te" }, 0),
             new Question("Melyik test�p�t� volt a legnagyobb riv�lisa Kevin Levrone-nak a 90-es �vek v�g�n?",
                new[] { "Ronnie Coleman", "Flex Wheeler", "Jay Cutler", "Dorian Yates" }, 1),
             new Question("Mi volt Jay Cutler els� Mr. Olympia gy�zelme?",
                new[] { "2000", "1999", "2004", "2005" }, 2),
             new Question("Melyik test�p�t� volt h�res arr�l, hogy a \"Pecs\" napj�t mindig kemik�lisan is intenz�ven edzette?",
                new[] { "Kevin Levrone", "Ronnie Coleman", "Lee Haney", "Dorian Yates" }, 0),
             new Question(" Ki volt a legnagyobb riv�lisa Lee Haney-nek a 80-as �vek v�g�n �s a 90-es �vek elej�n?",
                new[] { "Arnold Schwarzenegger", "Ronnie Coleman", "Rich Gaspari", "Dorian Yates" }, 2),
             new Question("Ki volt a legnagyobb riv�lisa Flex Wheeler-nek az 1990-es �vekben?",
                new[] { "Arnold Schwarzenegger", "Ronnie Coleman", "Rich Gaspari", "Dorian Yates" }, 3),
             new Question("Milyen s�lyt nyomott Ronnie Coleman legnagyobb fekvenyom� rekordj�n�l?",
                new[] { "800font", "600font", "325font", "400font" }, 1),
             new Question("Melyik test�p�t� szerzett rekordot a legnagyobb versenys�ly�val a Mr. Olympia t�rt�net�ben?",
                new[] { "Arnold Schwarzenegger", "Ronnie Coleman", "Lee Haney", "Markus Ruhl" }, 1),
             new Question("Markus R�hl melyik edz�sm�dszert alkalmazta legink�bb, hogy n�velje izomt�meg�t?",
                new[] { "Alacsony ism�tl�ses, nagy s�lyos edz�s", "Magas ism�tl�ses, alacsony s�lyos edz�s", "Kombin�lt s�lyz�s �s kardi� edz�sek", "K�pess�gfejleszt� edz�sek" }, 0),
             new Question("Markus R�hl karrierje sor�n milyen rekordot �ll�tott fel a test�p�t� versenyeken?",
                new[] { "Legnagyobb testzs�r-ar�ny rekord", "Legnagyobb bicepsz rekord", "Legnagyobb l�bnap rekord", "Legnagyobb fej- �s nyakizom" }, 1),
             new Question("H�ny alkalommal nyerte meg Sergio Oliva a Mr. Olympia versenyt?",
                new[] { "2", "3", "1", "0" }, 1),
             new Question("Melyik �ven nyerte meg Sergio Oliva el�sz�r a Mr. Olympia c�met?",
                new[] { "1967", "1968", "2000", "1999" }, 0),
             new Question("Mi volt Sergio Oliva utols� Mr. Olympia gy�zelme?",
                new[] { "1967", "1968", "2000", "1972" }, 3),
             new Question("Milyen h�res mondatot mondott Sergio Oliva, amely a test�p�t�s egyik alapvet� filoz�fi�j�v� v�lt?",
                new[] { "A s�lyok nem f�jnak, csak a gyenges�g f�j", "Az izom a szellem erej�b�l sz�letik", "Ha a f�jdalmat legy�z�d, a gy�zelem lesz a jutalmad", "A test�p�t�s az �nbizalomr�l sz�l" }, 1),
             new Question("Frank Zane megnyerte a Mr. Olympia c�m�t h�romszor. Melyik �vben nyerte el utolj�ra a c�met?",
                new[] { "1982", "1994", "1983", "1981" }, 0),
             new Question("Frank Zane h�res volt az egyik legjobb szimmetri�j�r�l. Milyen m�s jellemz�je volt a test�p�t�s�nek, ami kiemelte �t a t�bbi versenyz� k�z�l?",
                new[] { "Izomt�meg", "Egyensuly �s form�k", "�ll�k�pess�ge", "Bidcepsz m�rete" }, 1),
             new Question("Melyik h�res test�p�t�vel versenyzett Frank Zane az 1970-es �vek elej�n, aki v�g�l a legnagyobb riv�lis�v� v�lt?",
                new[] { "Arnold Schwarzenegger", "Ronnie Coleman", "Lee Haney", "Sergio Olivia" }, 0),


        };

        private int currentQuestionIndex = 0;
        private int score = 0;

        public Form1()
        {
            InitializeComponent();

            if (questions.Count > 0)
                LoadQuestion();
            else
                MessageBox.Show("Nincsenek k�rd�sek a j�t�khoz!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                var currentQuestion = questions[currentQuestionIndex];
                lblQuestion.Text = $"K�rd�s {currentQuestionIndex + 1}: {currentQuestion.Text}";
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
                MessageBox.Show("Helyes v�lasz!", "Gratul�lok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Helytelen v�lasz! A helyes v�lasz: {currentQuestion.Answers[currentQuestion.CorrectAnswerIndex]}",
                    "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            currentQuestionIndex++;
            LoadQuestion();
        }

        private void ShowResults()
        {
            MessageBox.Show($"V�ge a j�t�knak! Pontsz�mod: {score}/{questions.Count}", "Eredm�nyek", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                throw new ArgumentException("Pontosan 4 v�laszlehet�s�g sz�ks�ges!");

            Text = text;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }
}
