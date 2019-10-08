namespace NorrisWinForms
{
    partial class frmNorrisJokes
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
            this.btnGetJoke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGetJoke
            // 
            this.btnGetJoke.Location = new System.Drawing.Point(123, 204);
            this.btnGetJoke.Name = "btnGetJoke";
            this.btnGetJoke.Size = new System.Drawing.Size(160, 63);
            this.btnGetJoke.TabIndex = 0;
            this.btnGetJoke.Text = "Gimme a Joke!";
            this.btnGetJoke.UseVisualStyleBackColor = true;
            this.btnGetJoke.Click += new System.EventHandler(this.BtnGetJoke_ClickAsync);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categories: ";
            // 
            // cboCategories
            // 
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(162, 87);
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(121, 24);
            this.cboCategories.TabIndex = 2;
            // 
            // frmNorrisJokes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 336);
            this.Controls.Add(this.cboCategories);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGetJoke);
            this.Name = "frmNorrisJokes";
            this.Text = "Chuck Norris Joke Generator";
            this.Load += new System.EventHandler(this.FrmNorrisJokes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetJoke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCategories;
    }
}

