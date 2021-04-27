
namespace Filmfestival.views
{
    partial class Guestsigninview
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guestpasswordtextBox2 = new System.Windows.Forms.TextBox();
            this.guestusernametextBox1 = new System.Windows.Forms.TextBox();
            this.guestcancelbutton2 = new System.Windows.Forms.Button();
            this.guestsigninbutton1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "username";
            // 
            // guestpasswordtextBox2
            // 
            this.guestpasswordtextBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guestpasswordtextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestpasswordtextBox2.Location = new System.Drawing.Point(366, 187);
            this.guestpasswordtextBox2.Name = "guestpasswordtextBox2";
            this.guestpasswordtextBox2.Size = new System.Drawing.Size(100, 24);
            this.guestpasswordtextBox2.TabIndex = 10;
            this.guestpasswordtextBox2.TextChanged += new System.EventHandler(this.guestpasswordtextBox2_TextChanged);
            // 
            // guestusernametextBox1
            // 
            this.guestusernametextBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.guestusernametextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestusernametextBox1.Location = new System.Drawing.Point(366, 110);
            this.guestusernametextBox1.Name = "guestusernametextBox1";
            this.guestusernametextBox1.Size = new System.Drawing.Size(100, 24);
            this.guestusernametextBox1.TabIndex = 9;
            // 
            // guestcancelbutton2
            // 
            this.guestcancelbutton2.BackColor = System.Drawing.Color.Orange;
            this.guestcancelbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestcancelbutton2.Location = new System.Drawing.Point(424, 298);
            this.guestcancelbutton2.Name = "guestcancelbutton2";
            this.guestcancelbutton2.Size = new System.Drawing.Size(113, 43);
            this.guestcancelbutton2.TabIndex = 8;
            this.guestcancelbutton2.Text = "cancel";
            this.guestcancelbutton2.UseVisualStyleBackColor = false;
            // 
            // guestsigninbutton1
            // 
            this.guestsigninbutton1.BackColor = System.Drawing.Color.Orange;
            this.guestsigninbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestsigninbutton1.Location = new System.Drawing.Point(267, 298);
            this.guestsigninbutton1.Name = "guestsigninbutton1";
            this.guestsigninbutton1.Size = new System.Drawing.Size(102, 43);
            this.guestsigninbutton1.TabIndex = 7;
            this.guestsigninbutton1.Text = "signin";
            this.guestsigninbutton1.UseVisualStyleBackColor = false;
            this.guestsigninbutton1.Click += new System.EventHandler(this.jurysigninbutton1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(712, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Guestsigninview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(799, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestpasswordtextBox2);
            this.Controls.Add(this.guestusernametextBox1);
            this.Controls.Add(this.guestcancelbutton2);
            this.Controls.Add(this.guestsigninbutton1);
            this.Name = "Guestsigninview";
            this.Text = "guestsignin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox guestpasswordtextBox2;
        private System.Windows.Forms.TextBox guestusernametextBox1;
        private System.Windows.Forms.Button guestcancelbutton2;
        private System.Windows.Forms.Button guestsigninbutton1;
        private System.Windows.Forms.Button button1;
    }
}