namespace SQLApp
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
            dataGridView1 = new DataGridView();
            emailField = new TextBox();
            loginField = new TextBox();
            login = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(667, 413);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 0;
            button1.Text = "Добавить запись";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 373);
            dataGridView1.TabIndex = 1;
            // 
            // emailField
            // 
            emailField.Location = new Point(537, 413);
            emailField.Name = "emailField";
            emailField.Size = new Size(103, 23);
            emailField.TabIndex = 2;
            // 
            // loginField
            // 
            loginField.Location = new Point(376, 414);
            loginField.Name = "loginField";
            loginField.Size = new Size(103, 23);
            loginField.TabIndex = 3;
            // 
            // login
            // 
            login.AutoSize = true;
            login.Location = new Point(336, 417);
            login.Name = "login";
            login.Size = new Size(34, 15);
            login.TabIndex = 4;
            login.Text = "login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 416);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 5;
            label1.Text = "email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(login);
            Controls.Add(loginField);
            Controls.Add(emailField);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox emailField;
        private TextBox loginField;
        private Label login;
        private Label label1;
    }
}