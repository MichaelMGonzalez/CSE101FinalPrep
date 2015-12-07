namespace CSE101_Final_Prep
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.calculate1Button = new System.Windows.Forms.Button();
            this.problem3Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.stringBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stringBox2 = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dcLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 174);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.resultValueLabel);
            this.tabPage1.Controls.Add(this.resultLabel);
            this.tabPage1.Controls.Add(this.stringBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.stringBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.problem3Label);
            this.tabPage1.Controls.Add(this.calculate1Button);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 148);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Window";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Controls.Add(this.dcLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 148);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Study List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // calculate1Button
            // 
            this.calculate1Button.Location = new System.Drawing.Point(342, 119);
            this.calculate1Button.Name = "calculate1Button";
            this.calculate1Button.Size = new System.Drawing.Size(75, 23);
            this.calculate1Button.TabIndex = 0;
            this.calculate1Button.Text = "Calculate";
            this.calculate1Button.UseVisualStyleBackColor = true;
            this.calculate1Button.Click += new System.EventHandler(this.calculate1Button_Click);
            // 
            // problem3Label
            // 
            this.problem3Label.AutoSize = true;
            this.problem3Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.problem3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problem3Label.Location = new System.Drawing.Point(3, 3);
            this.problem3Label.Name = "problem3Label";
            this.problem3Label.Size = new System.Drawing.Size(321, 13);
            this.problem3Label.TabIndex = 1;
            this.problem3Label.Text = "Find the greatest subsequence between the two strings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "String 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // stringBox1
            // 
            this.stringBox1.Location = new System.Drawing.Point(3, 49);
            this.stringBox1.Name = "stringBox1";
            this.stringBox1.Size = new System.Drawing.Size(147, 20);
            this.stringBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "String 2";
            // 
            // stringBox2
            // 
            this.stringBox2.Location = new System.Drawing.Point(3, 88);
            this.stringBox2.Name = "stringBox2";
            this.stringBox2.Size = new System.Drawing.Size(147, 20);
            this.stringBox2.TabIndex = 5;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(6, 117);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(119, 13);
            this.resultLabel.TabIndex = 6;
            this.resultLabel.Text = "Greatest Subsequence:";
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Location = new System.Drawing.Point(131, 117);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(0, 13);
            this.resultValueLabel.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Greatest Subsequence",
            "Edit Distance",
            "Selection",
            "Quick Sort"});
            this.comboBox1.Location = new System.Drawing.Point(296, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dcLabel
            // 
            this.dcLabel.AutoSize = true;
            this.dcLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dcLabel.Location = new System.Drawing.Point(3, 3);
            this.dcLabel.Name = "dcLabel";
            this.dcLabel.Size = new System.Drawing.Size(111, 13);
            this.dcLabel.TabIndex = 0;
            this.dcLabel.Text = "We need to study:";
            this.dcLabel.Click += new System.EventHandler(this.dcLabel_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Dynamic Programming",
            "Divide and Conquer",
            "Greedy Algorithms"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 21);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(160, 124);
            this.checkedListBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 174);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "CSE 101 Prep";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox stringBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label problem3Label;
        private System.Windows.Forms.Button calculate1Button;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox stringBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label resultValueLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label dcLabel;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}

