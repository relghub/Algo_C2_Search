namespace Algo_C2_Search
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            button1 = new Button();
            tabPage2 = new TabPage();
            textToAnalyze = new TextBox();
            textResult = new TextBox();
            button2 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ефективність методів пошуку";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 6);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(656, 381);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(668, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Обчислити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textResult);
            tabPage2.Controls.Add(textToAnalyze);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 393);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Символьний аналіз";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textToAnalyze
            // 
            textToAnalyze.Location = new Point(61, 48);
            textToAnalyze.Name = "textToAnalyze";
            textToAnalyze.Size = new Size(231, 27);
            textToAnalyze.TabIndex = 0;
            // 
            // textResult
            // 
            textResult.Location = new Point(60, 111);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(232, 245);
            textResult.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(338, 47);
            button2.Name = "button2";
            button2.Size = new Size(111, 29);
            button2.TabIndex = 2;
            button2.Text = "Аналізувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private Button button1;
        private TextBox textResult;
        private TextBox textToAnalyze;
        private Button button2;
    }
}
