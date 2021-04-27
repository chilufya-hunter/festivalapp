
using System;

namespace Filmfestival.views
{
    partial class Jurysignin
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
            this.signinbutton1 = new System.Windows.Forms.Button();
            this.cancelbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametextBox1 = new System.Windows.Forms.TextBox();
            this.passwordtextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signinbutton1
            // 
            this.signinbutton1.BackColor = System.Drawing.Color.Transparent;
            this.signinbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbutton1.Location = new System.Drawing.Point(315, 240);
            this.signinbutton1.Name = "signinbutton1";
            this.signinbutton1.Size = new System.Drawing.Size(90, 39);
            this.signinbutton1.TabIndex = 0;
            this.signinbutton1.Text = "sign in";
            this.signinbutton1.UseVisualStyleBackColor = false;
            this.signinbutton1.Click += new System.EventHandler(this.signinbutton1_Click);
            // 
            // cancelbutton2
            // 
            this.cancelbutton2.BackColor = System.Drawing.Color.Transparent;
            this.cancelbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton2.Location = new System.Drawing.Point(425, 240);
            this.cancelbutton2.Name = "cancelbutton2";
            this.cancelbutton2.Size = new System.Drawing.Size(104, 39);
            this.cancelbutton2.TabIndex = 1;
            this.cancelbutton2.Text = "cancel";
            this.cancelbutton2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "password";
            // 
            // usernametextBox1
            // 
            this.usernametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox1.Location = new System.Drawing.Point(350, 110);
            this.usernametextBox1.Name = "usernametextBox1";
            this.usernametextBox1.Size = new System.Drawing.Size(150, 26);
            this.usernametextBox1.TabIndex = 4;
            // 
            // passwordtextBox2
            // 
            this.passwordtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox2.Location = new System.Drawing.Point(350, 165);
            this.passwordtextBox2.Name = "passwordtextBox2";
            this.passwordtextBox2.Size = new System.Drawing.Size(150, 26);
            this.passwordtextBox2.TabIndex = 5;
            this.passwordtextBox2.TextChanged += new System.EventHandler(this.passwordtextBox2_TextChanged);
            // 
            // Jurysignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordtextBox2);
            this.Controls.Add(this.usernametextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbutton2);
            this.Controls.Add(this.signinbutton1);
            this.Name = "Jurysignin";
            this.Text = "test1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Jurysignin_Load(object sender, EventArgs e)
        {
            this.Hide();
            Jurysignin jurysignin = new Jurysignin();
            jurysignin.ShowDialog();
        }

        #endregion

        private System.Windows.Forms.Button signinbutton1;
        private System.Windows.Forms.Button cancelbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametextBox1;
        private System.Windows.Forms.TextBox passwordtextBox2;
    }
}