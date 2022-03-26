﻿
namespace EncryText
{
    partial class Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.encryString = new MetroFramework.Controls.MetroTextBox();
            this.decryString = new MetroFramework.Controls.MetroTextBox();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.button2 = new MetroFramework.Controls.MetroButton();
            this.publicKey = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.privateKey = new MetroFramework.Controls.MetroTextBox();
            this.keyLength = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // encryString
            // 
            // 
            // 
            // 
            this.encryString.CustomButton.Image = null;
            this.encryString.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.encryString.CustomButton.Name = "";
            this.encryString.CustomButton.Size = new System.Drawing.Size(233, 233);
            this.encryString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.encryString.CustomButton.TabIndex = 1;
            this.encryString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.encryString.CustomButton.UseSelectable = true;
            this.encryString.CustomButton.Visible = false;
            this.encryString.Lines = new string[0];
            this.encryString.Location = new System.Drawing.Point(23, 124);
            this.encryString.MaxLength = 32767;
            this.encryString.Multiline = true;
            this.encryString.Name = "encryString";
            this.encryString.PasswordChar = '\0';
            this.encryString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.encryString.SelectedText = "";
            this.encryString.SelectionLength = 0;
            this.encryString.SelectionStart = 0;
            this.encryString.ShortcutsEnabled = true;
            this.encryString.Size = new System.Drawing.Size(441, 235);
            this.encryString.TabIndex = 0;
            this.encryString.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.encryString.UseSelectable = true;
            this.encryString.WaterMark = "加密的内容";
            this.encryString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.encryString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // decryString
            // 
            // 
            // 
            // 
            this.decryString.CustomButton.Image = null;
            this.decryString.CustomButton.Location = new System.Drawing.Point(207, 1);
            this.decryString.CustomButton.Name = "";
            this.decryString.CustomButton.Size = new System.Drawing.Size(233, 233);
            this.decryString.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.decryString.CustomButton.TabIndex = 1;
            this.decryString.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.decryString.CustomButton.UseSelectable = true;
            this.decryString.CustomButton.Visible = false;
            this.decryString.Lines = new string[0];
            this.decryString.Location = new System.Drawing.Point(23, 365);
            this.decryString.MaxLength = 32767;
            this.decryString.Multiline = true;
            this.decryString.Name = "decryString";
            this.decryString.PasswordChar = '\0';
            this.decryString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.decryString.SelectedText = "";
            this.decryString.SelectionLength = 0;
            this.decryString.SelectionStart = 0;
            this.decryString.ShortcutsEnabled = true;
            this.decryString.Size = new System.Drawing.Size(441, 235);
            this.decryString.TabIndex = 1;
            this.decryString.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.decryString.UseSelectable = true;
            this.decryString.WaterMark = "解密的内容";
            this.decryString.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.decryString.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // button1
            // 
            this.button1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.button1.Location = new System.Drawing.Point(355, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "加密";
            this.button1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.button2.Location = new System.Drawing.Point(412, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "解密";
            this.button2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.button2.UseSelectable = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // publicKey
            // 
            // 
            // 
            // 
            this.publicKey.CustomButton.Image = null;
            this.publicKey.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.publicKey.CustomButton.Name = "";
            this.publicKey.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.publicKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.publicKey.CustomButton.TabIndex = 1;
            this.publicKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.publicKey.CustomButton.UseSelectable = true;
            this.publicKey.CustomButton.Visible = false;
            this.publicKey.Lines = new string[0];
            this.publicKey.Location = new System.Drawing.Point(66, 93);
            this.publicKey.MaxLength = 32767;
            this.publicKey.Name = "publicKey";
            this.publicKey.PasswordChar = '\0';
            this.publicKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.publicKey.SelectedText = "";
            this.publicKey.SelectionLength = 0;
            this.publicKey.SelectionStart = 0;
            this.publicKey.ShortcutsEnabled = true;
            this.publicKey.Size = new System.Drawing.Size(174, 25);
            this.publicKey.TabIndex = 4;
            this.publicKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.publicKey.UseSelectable = true;
            this.publicKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.publicKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(279, 61);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(70, 25);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "生成密钥";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // privateKey
            // 
            // 
            // 
            // 
            this.privateKey.CustomButton.Image = null;
            this.privateKey.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.privateKey.CustomButton.Name = "";
            this.privateKey.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.privateKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.privateKey.CustomButton.TabIndex = 1;
            this.privateKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.privateKey.CustomButton.UseSelectable = true;
            this.privateKey.CustomButton.Visible = false;
            this.privateKey.Lines = new string[0];
            this.privateKey.Location = new System.Drawing.Point(289, 92);
            this.privateKey.MaxLength = 32767;
            this.privateKey.Name = "privateKey";
            this.privateKey.PasswordChar = '\0';
            this.privateKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.privateKey.SelectedText = "";
            this.privateKey.SelectionLength = 0;
            this.privateKey.SelectionStart = 0;
            this.privateKey.ShortcutsEnabled = true;
            this.privateKey.Size = new System.Drawing.Size(174, 25);
            this.privateKey.TabIndex = 6;
            this.privateKey.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.privateKey.UseSelectable = true;
            this.privateKey.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.privateKey.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // keyLength
            // 
            // 
            // 
            // 
            this.keyLength.CustomButton.Image = null;
            this.keyLength.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.keyLength.CustomButton.Name = "";
            this.keyLength.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.keyLength.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.keyLength.CustomButton.TabIndex = 1;
            this.keyLength.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.keyLength.CustomButton.UseSelectable = true;
            this.keyLength.CustomButton.Visible = false;
            this.keyLength.Lines = new string[] {
        "2048"};
            this.keyLength.Location = new System.Drawing.Point(23, 61);
            this.keyLength.MaxLength = 32767;
            this.keyLength.Name = "keyLength";
            this.keyLength.PasswordChar = '\0';
            this.keyLength.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyLength.SelectedText = "";
            this.keyLength.SelectionLength = 0;
            this.keyLength.SelectionStart = 0;
            this.keyLength.ShortcutsEnabled = true;
            this.keyLength.Size = new System.Drawing.Size(250, 25);
            this.keyLength.TabIndex = 7;
            this.keyLength.Text = "2048";
            this.keyLength.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.keyLength.UseSelectable = true;
            this.keyLength.WaterMark = "密钥长度（Key Mod 4 = 0）";
            this.keyLength.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.keyLength.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 22);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "公钥";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(246, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(37, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "私钥";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 623);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.keyLength);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.decryString);
            this.Controls.Add(this.encryString);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "RSA加密";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox encryString;
        private MetroFramework.Controls.MetroTextBox decryString;
        private MetroFramework.Controls.MetroButton button1;
        private MetroFramework.Controls.MetroButton button2;
        private MetroFramework.Controls.MetroTextBox publicKey;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox privateKey;
        private MetroFramework.Controls.MetroTextBox keyLength;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

