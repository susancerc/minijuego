namespace MinijuegoMate
{
    partial class pregunta4
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
            buttonRE = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(615, 373);
            button1.Name = "button1";
            button1.Size = new Size(162, 51);
            button1.TabIndex = 0;
            button1.Text = "Siguiente pregunta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(58, 67);
            label1.Name = "label1";
            label1.Size = new Size(663, 119);
            label1.TabIndex = 1;
            label1.Text = "Si tienes un cubo de hielo y lo dejas afuera, ¿qué le sucederá a su volumen?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonRE
            // 
            buttonRE.Location = new Point(424, 177);
            buttonRE.Name = "buttonRE";
            buttonRE.Size = new Size(141, 70);
            buttonRE.TabIndex = 2;
            buttonRE.Text = "Disminuirá";
            buttonRE.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(178, 177);
            button3.Name = "button3";
            button3.Size = new Size(141, 70);
            button3.TabIndex = 3;
            button3.Text = "Se queda igual";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(424, 301);
            button4.Name = "button4";
            button4.Size = new Size(141, 70);
            button4.TabIndex = 4;
            button4.Text = "No le pasa nada";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(178, 301);
            button5.Name = "button5";
            button5.Size = new Size(141, 70);
            button5.TabIndex = 5;
            button5.Text = "Se derrite pero queda igual";
            button5.UseVisualStyleBackColor = true;
            // 
            // pregunta4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(buttonRE);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "pregunta4";
            Text = "pregunta4";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button buttonRE;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}