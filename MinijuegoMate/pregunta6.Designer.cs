namespace MinijuegoMate
{
    partial class pregunta6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            buttonRE = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(653, 370);
            button1.Name = "button1";
            button1.Size = new Size(132, 54);
            button1.TabIndex = 0;
            button1.Text = "Resultados";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(124, 50);
            label1.Name = "label1";
            label1.Size = new Size(552, 125);
            label1.TabIndex = 1;
            label1.Text = "Un granjero tiene 17 ovejas. Todas menos 9 mueren. ¿Cuántas ovejas le quedan?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(144, 198);
            button2.Name = "button2";
            button2.Size = new Size(129, 56);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(492, 198);
            button3.Name = "button3";
            button3.Size = new Size(129, 56);
            button3.TabIndex = 3;
            button3.Text = "17";
            button3.UseVisualStyleBackColor = true;
            // 
            // buttonRE
            // 
            buttonRE.Location = new Point(492, 316);
            buttonRE.Name = "buttonRE";
            buttonRE.Size = new Size(129, 56);
            buttonRE.TabIndex = 4;
            buttonRE.Text = "9";
            buttonRE.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(144, 316);
            button5.Name = "button5";
            button5.Size = new Size(129, 56);
            button5.TabIndex = 5;
            button5.Text = "así es";
            button5.UseVisualStyleBackColor = true;
            // 
            // pregunta6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(buttonRE);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "pregunta6";
            Text = "pregunta6";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button button3;
        private Button buttonRE;
        private Button button5;
    }
}