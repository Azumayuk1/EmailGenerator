﻿namespace EmailGenerator
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
            this.MainConsole = new System.Windows.Forms.RichTextBox();
            this.default_Secondleveldomain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.default_FirstLeveldomain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Checkbox_defaultdomain = new System.Windows.Forms.CheckBox();
            this.Numberof_emails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_GenerateEmails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainConsole
            // 
            this.MainConsole.Location = new System.Drawing.Point(60, 34);
            this.MainConsole.Name = "MainConsole";
            this.MainConsole.Size = new System.Drawing.Size(268, 445);
            this.MainConsole.TabIndex = 0;
            this.MainConsole.Text = "";
            // 
            // default_Secondleveldomain
            // 
            this.default_Secondleveldomain.Location = new System.Drawing.Point(362, 114);
            this.default_Secondleveldomain.Name = "default_Secondleveldomain";
            this.default_Secondleveldomain.Size = new System.Drawing.Size(131, 22);
            this.default_Secondleveldomain.TabIndex = 1;
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
            // Numberof_emails
            // 
            this.Numberof_emails.Location = new System.Drawing.Point(539, 173);
            this.Numberof_emails.Name = "Numberof_emails";
            this.Numberof_emails.Size = new System.Drawing.Size(100, 22);
            this.Numberof_emails.TabIndex = 7;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 588);
            this.Controls.Add(this.btn_GenerateEmails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Numberof_emails);
            this.Controls.Add(this.Checkbox_defaultdomain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.default_FirstLeveldomain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.default_Secondleveldomain);
            this.Controls.Add(this.MainConsole);
            this.Name = "Form1";
            this.Text = "Email Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox MainConsole;
        private System.Windows.Forms.TextBox default_Secondleveldomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox default_FirstLeveldomain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Checkbox_defaultdomain;
        private System.Windows.Forms.TextBox Numberof_emails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_GenerateEmails;
    }
}

