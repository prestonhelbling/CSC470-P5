namespace P5_Code
{
    partial class RemoveProject
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
            this.RemoveIt = new System.Windows.Forms.Button();
            this.DontRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RemoveIt
            // 
            this.RemoveIt.Location = new System.Drawing.Point(229, 95);
            this.RemoveIt.Name = "RemoveIt";
            this.RemoveIt.Size = new System.Drawing.Size(116, 36);
            this.RemoveIt.TabIndex = 0;
            this.RemoveIt.Text = "Remove";
            this.RemoveIt.UseVisualStyleBackColor = true;
            this.RemoveIt.Click += new System.EventHandler(this.RemoveIt_Click);
            // 
            // DontRemove
            // 
            this.DontRemove.Location = new System.Drawing.Point(55, 95);
            this.DontRemove.Name = "DontRemove";
            this.DontRemove.Size = new System.Drawing.Size(116, 36);
            this.DontRemove.TabIndex = 1;
            this.DontRemove.Text = "Cancel";
            this.DontRemove.UseVisualStyleBackColor = true;
            this.DontRemove.Click += new System.EventHandler(this.DontRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure you would like to remove this project?";
            // 
            // RemoveProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DontRemove);
            this.Controls.Add(this.RemoveIt);
            this.Name = "RemoveProject";
            this.Text = "Remove Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveIt;
        private System.Windows.Forms.Button DontRemove;
        private System.Windows.Forms.Label label1;
    }
}