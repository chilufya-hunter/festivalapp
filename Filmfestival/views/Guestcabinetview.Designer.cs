
namespace Filmfestival.views
{
    partial class guestcabinetview
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
            this.registertoattendbutton1 = new System.Windows.Forms.Button();
            this.seeguestlistbutton2 = new System.Windows.Forms.Button();
            this.seenominationsbutton3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registertoattendbutton1
            // 
            this.registertoattendbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registertoattendbutton1.Location = new System.Drawing.Point(144, 66);
            this.registertoattendbutton1.Name = "registertoattendbutton1";
            this.registertoattendbutton1.Size = new System.Drawing.Size(171, 62);
            this.registertoattendbutton1.TabIndex = 0;
            this.registertoattendbutton1.Text = "register\r\nto attend";
            this.registertoattendbutton1.UseVisualStyleBackColor = true;
            this.registertoattendbutton1.Click += new System.EventHandler(this.registertoattendbutton1_Click);
            // 
            // seeguestlistbutton2
            // 
            this.seeguestlistbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeguestlistbutton2.Location = new System.Drawing.Point(144, 165);
            this.seeguestlistbutton2.Name = "seeguestlistbutton2";
            this.seeguestlistbutton2.Size = new System.Drawing.Size(171, 69);
            this.seeguestlistbutton2.TabIndex = 1;
            this.seeguestlistbutton2.Text = " see guest \r\n list";
            this.seeguestlistbutton2.UseVisualStyleBackColor = true;
            // 
            // seenominationsbutton3
            // 
            this.seenominationsbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seenominationsbutton3.Location = new System.Drawing.Point(144, 277);
            this.seenominationsbutton3.Name = "seenominationsbutton3";
            this.seenominationsbutton3.Size = new System.Drawing.Size(171, 84);
            this.seenominationsbutton3.TabIndex = 2;
            this.seenominationsbutton3.Text = "see nominations";
            this.seenominationsbutton3.UseVisualStyleBackColor = true;
            this.seenominationsbutton3.Click += new System.EventHandler(this.seenominationsbutton3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(703, 414);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // guestcabinetview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.seenominationsbutton3);
            this.Controls.Add(this.seeguestlistbutton2);
            this.Controls.Add(this.registertoattendbutton1);
            this.Name = "guestcabinetview";
            this.Text = "guestcabinetviewmodels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button registertoattendbutton1;
        private System.Windows.Forms.Button seeguestlistbutton2;
        private System.Windows.Forms.Button seenominationsbutton3;
        private System.Windows.Forms.Button button4;
    }
}