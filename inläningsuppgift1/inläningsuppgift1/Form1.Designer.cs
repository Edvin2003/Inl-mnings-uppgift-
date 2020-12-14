
namespace inläningsuppgift1
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
            this.Gissa = new System.Windows.Forms.Button();
            this.gissningBox = new System.Windows.Forms.TextBox();
            this.Meddelande = new System.Windows.Forms.Label();
            this.Meddelande2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Gissa
            // 
            this.Gissa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gissa.Location = new System.Drawing.Point(342, 176);
            this.Gissa.Name = "Gissa";
            this.Gissa.Size = new System.Drawing.Size(75, 28);
            this.Gissa.TabIndex = 0;
            this.Gissa.Text = "Gissa!";
            this.Gissa.UseVisualStyleBackColor = true;
            this.Gissa.Click += new System.EventHandler(this.Gissa_Click);
            // 
            // gissningBox
            // 
            this.gissningBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gissningBox.Location = new System.Drawing.Point(313, 112);
            this.gissningBox.Name = "gissningBox";
            this.gissningBox.Size = new System.Drawing.Size(149, 23);
            this.gissningBox.TabIndex = 1;
            this.gissningBox.Text = "Skriv ett tal mellan 1-100";
            // 
            // Meddelande
            // 
            this.Meddelande.AutoSize = true;
            this.Meddelande.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meddelande.Location = new System.Drawing.Point(339, 245);
            this.Meddelande.Name = "Meddelande";
            this.Meddelande.Size = new System.Drawing.Size(178, 17);
            this.Meddelande.TabIndex = 2;
            this.Meddelande.Text = "Meddelande                       ";
            // 
            // Meddelande2
            // 
            this.Meddelande2.AutoSize = true;
            this.Meddelande2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meddelande2.Location = new System.Drawing.Point(339, 278);
            this.Meddelande2.Name = "Meddelande2";
            this.Meddelande2.Size = new System.Drawing.Size(94, 17);
            this.Meddelande2.TabIndex = 3;
            this.Meddelande2.Text = "Meddalande2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Meddelande2);
            this.Controls.Add(this.Meddelande);
            this.Controls.Add(this.gissningBox);
            this.Controls.Add(this.Gissa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Gissa;
        private System.Windows.Forms.TextBox gissningBox;
        private System.Windows.Forms.Label Meddelande;
        private System.Windows.Forms.Label Meddelande2;
    }
}

