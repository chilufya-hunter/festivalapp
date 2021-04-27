
namespace Filmfestival.views
{
    partial class Jurycabinetview
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
            this.jurypanelbutton1 = new System.Windows.Forms.Button();
            this.seeguestlistbutton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.winnerslistbutton5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jurypanelbutton1
            // 
            this.jurypanelbutton1.BackColor = System.Drawing.Color.Orange;
            this.jurypanelbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurypanelbutton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.jurypanelbutton1.Location = new System.Drawing.Point(122, 71);
            this.jurypanelbutton1.Name = "jurypanelbutton1";
            this.jurypanelbutton1.Size = new System.Drawing.Size(138, 71);
            this.jurypanelbutton1.TabIndex = 0;
            this.jurypanelbutton1.Text = "jury panel";
            this.jurypanelbutton1.UseVisualStyleBackColor = false;
            this.jurypanelbutton1.Click += new System.EventHandler(this.jurypanelbutton1_Click);
            // 
            // seeguestlistbutton2
            // 
            this.seeguestlistbutton2.BackColor = System.Drawing.Color.Orange;
            this.seeguestlistbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeguestlistbutton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.seeguestlistbutton2.Location = new System.Drawing.Point(122, 211);
            this.seeguestlistbutton2.Name = "seeguestlistbutton2";
            this.seeguestlistbutton2.Size = new System.Drawing.Size(138, 81);
            this.seeguestlistbutton2.TabIndex = 1;
            this.seeguestlistbutton2.Text = "see guest list";
            this.seeguestlistbutton2.UseVisualStyleBackColor = false;
            this.seeguestlistbutton2.Click += new System.EventHandler(this.seeguestlistbutton2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(436, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "see participants";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Orange;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(697, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 37);
            this.button4.TabIndex = 3;
            this.button4.Text = "home";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // winnerslistbutton5
            // 
            this.winnerslistbutton5.BackColor = System.Drawing.Color.Orange;
            this.winnerslistbutton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerslistbutton5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winnerslistbutton5.Location = new System.Drawing.Point(436, 71);
            this.winnerslistbutton5.Name = "winnerslistbutton5";
            this.winnerslistbutton5.Size = new System.Drawing.Size(136, 71);
            this.winnerslistbutton5.TabIndex = 4;
            this.winnerslistbutton5.Text = "winners list";
            this.winnerslistbutton5.UseVisualStyleBackColor = false;
            this.winnerslistbutton5.Click += new System.EventHandler(this.winnerslistbutton5_Click);
            // 
            // Jurycabinetview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.winnerslistbutton5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.seeguestlistbutton2);
            this.Controls.Add(this.jurypanelbutton1);
            this.Name = "Jurycabinetview";
            this.Text = "jurycabinetview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jurypanelbutton1;
        private System.Windows.Forms.Button seeguestlistbutton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button winnerslistbutton5;
    }
}