namespace MinijuegoMate
{
    partial class pregunta5
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(597, 349);
            button1.Name = "button1";
            button1.Size = new Size(148, 59);
            button1.TabIndex = 0;
            button1.Text = "Siguiente pregunta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(60, 51);
            label1.Name = "label1";
            label1.Size = new Size(685, 120);
            label1.TabIndex = 1;
            label1.Text = "Tienes 30 calcetines en un cajón. 60% de ellos son negros, el resto son blancos. ¿Cuántos calcetines blancos tienes?";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.Location = new Point(86, 236);
            button2.Name = "button2";
            button2.Size = new Size(149, 70);
            button2.TabIndex = 2;
            button2.Text = "12, creo";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonRE
            // 
            buttonRE.Location = new Point(330, 236);
            buttonRE.Name = "buttonRE";
            buttonRE.Size = new Size(149, 70);
            buttonRE.TabIndex = 3;
            buttonRE.Text = "No sé";
            buttonRE.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(587, 236);
            button4.Name = "button4";
            button4.Size = new Size(149, 70);
            button4.TabIndex = 4;
            button4.Text = "Un niño de primaria no podría contestar esto, menos yo *se bugea*";
            button4.UseVisualStyleBackColor = true;
            // 
            // pregunta5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(buttonRE);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "pregunta5";
            Text = "pregunta5";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button2;
        private Button buttonRE;
        private Button button4;
    }
}