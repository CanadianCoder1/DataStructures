namespace Binary_Trees_and_Linked_Lists
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
            button1 = new Button();
            txtInsert = new TextBox();
            txtDisplay = new TextBox();
            txtLinkedListDisplay = new TextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnParenthesisCheck = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(69, 300);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtInsert
            // 
            txtInsert.Location = new Point(12, 117);
            txtInsert.Multiline = true;
            txtInsert.Name = "txtInsert";
            txtInsert.Size = new Size(197, 177);
            txtInsert.TabIndex = 1;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(12, 329);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(197, 177);
            txtDisplay.TabIndex = 2;
            // 
            // txtLinkedListDisplay
            // 
            txtLinkedListDisplay.Location = new Point(265, 116);
            txtLinkedListDisplay.Multiline = true;
            txtLinkedListDisplay.Name = "txtLinkedListDisplay";
            txtLinkedListDisplay.Size = new Size(197, 177);
            txtLinkedListDisplay.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(269, 317);
            button2.Name = "button2";
            button2.Size = new Size(91, 23);
            button2.TabIndex = 4;
            button2.Text = "Add To Front";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(366, 317);
            button3.Name = "button3";
            button3.Size = new Size(91, 23);
            button3.TabIndex = 6;
            button3.Text = "Add To Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 296);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 7;
            label1.Text = "Data: 5,7,1,5,10,15,4";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(34, 82);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 8;
            label2.Text = "Binary Tree";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(294, 81);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 9;
            label3.Text = "Linked List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(567, 81);
            label4.Name = "label4";
            label4.Size = new Size(241, 32);
            label4.TabIndex = 10;
            label4.Text = "Parenthesis Checker";
            // 
            // btnParenthesisCheck
            // 
            btnParenthesisCheck.Location = new Point(632, 144);
            btnParenthesisCheck.Name = "btnParenthesisCheck";
            btnParenthesisCheck.Size = new Size(91, 23);
            btnParenthesisCheck.TabIndex = 11;
            btnParenthesisCheck.Text = "Check";
            btnParenthesisCheck.UseVisualStyleBackColor = true;
            btnParenthesisCheck.Click += btnParenthesisCheck_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 734);
            Controls.Add(btnParenthesisCheck);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtLinkedListDisplay);
            Controls.Add(txtDisplay);
            Controls.Add(txtInsert);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtInsert;
        private TextBox txtDisplay;
        private TextBox txtLinkedListDisplay;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnParenthesisCheck;
    }
}
