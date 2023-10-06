namespace MinijuegoMate
{
    partial class quizmatesusi
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(635, 360);
            button1.Name = "button1";
            button1.Size = new Size(134, 54);
            button1.TabIndex = 0;
            button1.Text = "Siguiente pregunta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(110, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 170);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(221, 49);
            label1.Name = "label1";
            label1.Size = new Size(110, 65);
            label1.TabIndex = 0;
            label1.Text = "3+9";
            label1.Click += label1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Firebrick;
            button2.Location = new Point(121, 239);
            button2.Name = "button2";
            button2.Size = new Size(108, 63);
            button2.TabIndex = 2;
            button2.Text = "12";
            button2.UseVisualStyleBackColor = false;
            // 
            // quizmatesusi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Coral;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Name = "quizmatesusi";
            Text = "quizmatesusi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label1;
        private Button button2;
    }
}