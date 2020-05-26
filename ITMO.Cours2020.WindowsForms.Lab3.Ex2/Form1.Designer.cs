namespace ITMO.Cours2020.WindowsForms.Lab3.Ex2
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
            this.userControTimer21 = new ITMO.Cours2020.WindowsForms.Lab3.Ex2.UserControTimer2();
            this.SuspendLayout();
            // 
            // userControTimer21
            // 
            this.userControTimer21.Location = new System.Drawing.Point(69, 51);
            this.userControTimer21.Name = "userControTimer21";
            this.userControTimer21.Size = new System.Drawing.Size(75, 23);
            this.userControTimer21.TabIndex = 0;
            this.userControTimer21.Text = "userControTimer21";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControTimer21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControTimer2 userControTimer21;
    }
}

