namespace MinijuegoMate
{
    partial class pregunta3
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
            buttonRE = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(634, 371);
            button1.Name = "button1";
            button1.Size = new Size(148, 58);
            button1.TabIndex = 0;
            button1.Text = "Siguiente pregunta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(150, 78);
            label1.Name = "label1";
            label1.Size = new Size(557, 92);
            label1.TabIndex = 1;
            label1.Text = "Si tienes 3 manzanas y tomas 2, ¿cuántas manzanas tienes ahora?";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // button2
            // 
            button2.Location = new Point(515, 184);
            button2.Name = "button2";
            button2.Size = new Size(141, 62);
            button2.TabIndex = 2;
            button2.Text = "3 manzanas";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonRE
            // 
            buttonRE.Location = new Point(150, 184);
            buttonRE.Name = "buttonRE";
            buttonRE.Size = new Size(141, 62);
            buttonRE.TabIndex = 3;
            buttonRE.Text = "2 manzanas";
            buttonRE.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(150, 289);
            button4.Name = "button4";
            button4.Size = new Size(141, 62);
            button4.TabIndex = 4;
            button4.Text = "Viernes";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(515, 289);
            button5.Name = "button5";
            button5.Size = new Size(141, 62);
            button5.TabIndex = 5;
            button5.Text = "No quedaron manzanas";
            button5.UseVisualStyleBackColor = true;
            // 
            // pregunta3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(buttonRE);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "pregunta3";
            Text = "pregunta3";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button buttonRE;
        private Button button4;
        private Button button5;
    }
}