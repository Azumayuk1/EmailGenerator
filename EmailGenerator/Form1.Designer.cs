namespace EmailGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainConsole = new System.Windows.Forms.RichTextBox();
            this.Default_SecondLevelDomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.default_FirstLeveldomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Checkbox_defaultdomain = new System.Windows.Forms.CheckBox();
            this.EmailsNumText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GenerateEmails = new System.Windows.Forms.Button();
            this.Password_Length = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainConsole
            // 
            this.MainConsole.Location = new System.Drawing.Point(60, 34);
            this.MainConsole.Name = "MainConsole";
            this.MainConsole.ReadOnly = true;
            this.MainConsole.Size = new System.Drawing.Size(268, 445);
            this.MainConsole.TabIndex = 0;
            this.MainConsole.Text = "";
            // 
            // Default_SecondLevelDomain
            // 
            this.Default_SecondLevelDomain.Location = new System.Drawing.Point(362, 114);
            this.Default_SecondLevelDomain.Name = "Default_SecondLevelDomain";
            this.Default_SecondLevelDomain.Size = new System.Drawing.Size(131, 22);
            this.Default_SecondLevelDomain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Домен второго уровня";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = ".";
            // 
            // default_FirstLeveldomain
            // 
            this.default_FirstLeveldomain.Location = new System.Drawing.Point(539, 114);
            this.default_FirstLeveldomain.Name = "default_FirstLeveldomain";
            this.default_FirstLeveldomain.Size = new System.Drawing.Size(100, 22);
            this.default_FirstLeveldomain.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Домен первого уровня";
            // 
            // Checkbox_defaultdomain
            // 
            this.Checkbox_defaultdomain.AutoSize = true;
            this.Checkbox_defaultdomain.Location = new System.Drawing.Point(362, 34);
            this.Checkbox_defaultdomain.Name = "Checkbox_defaultdomain";
            this.Checkbox_defaultdomain.Size = new System.Drawing.Size(224, 21);
            this.Checkbox_defaultdomain.TabIndex = 6;
            this.Checkbox_defaultdomain.Text = "Задать определенный домен";
            this.Checkbox_defaultdomain.UseVisualStyleBackColor = true;
            // 
            // EmailsNumText
            // 
            this.EmailsNumText.Location = new System.Drawing.Point(539, 173);
            this.EmailsNumText.Name = "EmailsNumText";
            this.EmailsNumText.Size = new System.Drawing.Size(100, 22);
            this.EmailsNumText.TabIndex = 7;
            this.EmailsNumText.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Количество адресов:";
            // 
            // btn_GenerateEmails
            // 
            this.btn_GenerateEmails.Location = new System.Drawing.Point(60, 497);
            this.btn_GenerateEmails.Name = "btn_GenerateEmails";
            this.btn_GenerateEmails.Size = new System.Drawing.Size(268, 67);
            this.btn_GenerateEmails.TabIndex = 9;
            this.btn_GenerateEmails.Text = "Сгенерировать адреса";
            this.btn_GenerateEmails.UseVisualStyleBackColor = true;
            this.btn_GenerateEmails.Click += new System.EventHandler(this.btn_GenerateEmails_Click);
            // 
            // Password_Length
            // 
            this.Password_Length.Location = new System.Drawing.Point(539, 229);
            this.Password_Length.Name = "Password_Length";
            this.Password_Length.Size = new System.Drawing.Size(100, 22);
            this.Password_Length.TabIndex = 10;
            this.Password_Length.Text = "8";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(359, 232);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(113, 17);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Размер пароля:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(726, 588);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.Password_Length);
            this.Controls.Add(this.btn_GenerateEmails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EmailsNumText);
            this.Controls.Add(this.Checkbox_defaultdomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.default_FirstLeveldomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Default_SecondLevelDomain);
            this.Controls.Add(this.MainConsole);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Email Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainConsole;
        private System.Windows.Forms.TextBox Default_SecondLevelDomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox default_FirstLeveldomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailsNumText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GenerateEmails;
        public System.Windows.Forms.CheckBox Checkbox_defaultdomain;
        private System.Windows.Forms.Label password_label;
        public System.Windows.Forms.TextBox Password_Length;
    }
}

