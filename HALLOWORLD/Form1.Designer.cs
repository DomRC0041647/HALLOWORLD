namespace HALLOWORLD
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
            this.OmegaButtonOfDoom = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OmegaButtonOfDoom
            // 
            this.OmegaButtonOfDoom.BackColor = System.Drawing.Color.Red;
            this.OmegaButtonOfDoom.Font = new System.Drawing.Font("Swis721 BlkEx BT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OmegaButtonOfDoom.ForeColor = System.Drawing.Color.Yellow;
            this.OmegaButtonOfDoom.Location = new System.Drawing.Point(314, 187);
            this.OmegaButtonOfDoom.Name = "OmegaButtonOfDoom";
            this.OmegaButtonOfDoom.Size = new System.Drawing.Size(762, 295);
            this.OmegaButtonOfDoom.TabIndex = 0;
            this.OmegaButtonOfDoom.Text = "OMEGA BUTTON OF DOOM";
            this.OmegaButtonOfDoom.UseVisualStyleBackColor = false;
            this.OmegaButtonOfDoom.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Oh what an unexpecting big red button lets press it";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 658);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OmegaButtonOfDoom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OmegaButtonOfDoom;
        private System.Windows.Forms.TextBox textBox1;
    }
}

