namespace MinijuegoMate
{
    partial class Pregunta2
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
            label1 = new Label();
            button2 = new Button();
            buttonRE = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(144, 81);
            label1.Name = "label1";
            label1.Size = new Size(534, 83);
            label1.TabIndex = 0;
            label1.Text = "La suma de dos números da 30 y su diferencia es 6. ¿Cuáles son esos números?";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(658, 392);
            button2.Name = "button2";
            button2.Size = new Size(119, 46);
            button2.TabIndex = 2;
            button2.Text = "Siguiente pregunta";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonRE
            // 
            buttonRE.Location = new Point(480, 187);
            buttonRE.Name = "buttonRE";
            buttonRE.Size = new Size(142, 73);
            buttonRE.TabIndex = 1;
            buttonRE.Text = "18 y 12";
            buttonRE.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(480, 307);
            button1.Name = "button1";
            button1.Size = new Size(142, 73);
            button1.TabIndex = 3;
            button1.Text = "6 y 30";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(199, 187);
            button3.Name = "button3";
            button3.Size = new Size(142, 73);
            button3.TabIndex = 4;
            button3.Text = "12 y 7";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(199, 307);
            button4.Name = "button4";
            button4.Size = new Size(142, 73);
            button4.TabIndex = 5;
            button4.Text = "5 y 5";
            button4.UseVisualStyleBackColor = true;
            // 
            // Pregunta2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(buttonRE);
            Controls.Add(label1);
            Name = "Pregunta2";
            Text = "Pregunta2";
            ResumeLayout(false);
        }

        #endregion

        protected Label label1;
        private Button button2;
        private Button buttonRE;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}