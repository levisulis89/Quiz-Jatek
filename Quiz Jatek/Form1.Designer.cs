
namespace QuizApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblQuestion = new Label();
            btnAnswer1 = new Button();
            btnAnswer2 = new Button();
            btnAnswer3 = new Button();
            btnAnswer4 = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblQuestion.Location = new Point(30, 30);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(64, 19);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Kérdés";
            // 
            // btnAnswer1
            // 
            btnAnswer1.Location = new Point(30, 80);
            btnAnswer1.Name = "btnAnswer1";
            btnAnswer1.Size = new Size(350, 40);
            btnAnswer1.TabIndex = 1;
            btnAnswer1.Text = "Válasz 1";
            btnAnswer1.UseVisualStyleBackColor = true;
            btnAnswer1.Click += btnAnswer1_Click;
            // 
            // btnAnswer2
            // 
            btnAnswer2.Location = new Point(30, 130);
            btnAnswer2.Name = "btnAnswer2";
            btnAnswer2.Size = new Size(350, 40);
            btnAnswer2.TabIndex = 2;
            btnAnswer2.Text = "Válasz 2";
            btnAnswer2.UseVisualStyleBackColor = true;
            btnAnswer2.Click += btnAnswer2_Click;
            // 
            // btnAnswer3
            // 
            btnAnswer3.Location = new Point(30, 180);
            btnAnswer3.Name = "btnAnswer3";
            btnAnswer3.Size = new Size(350, 40);
            btnAnswer3.TabIndex = 3;
            btnAnswer3.Text = "Válasz 3";
            btnAnswer3.UseVisualStyleBackColor = true;
            btnAnswer3.Click += btnAnswer3_Click;
            // 
            // btnAnswer4
            // 
            btnAnswer4.Location = new Point(30, 230);
            btnAnswer4.Name = "btnAnswer4";
            btnAnswer4.Size = new Size(350, 40);
            btnAnswer4.TabIndex = 4;
            btnAnswer4.Text = "Válasz 4";
            btnAnswer4.UseVisualStyleBackColor = true;
            btnAnswer4.Click += btnAnswer4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 326);
            Controls.Add(lblQuestion);
            Controls.Add(btnAnswer1);
            Controls.Add(btnAnswer2);
            Controls.Add(btnAnswer3);
            Controls.Add(btnAnswer4);
            Name = "Form1";
            Text = "Quiz Játék";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
