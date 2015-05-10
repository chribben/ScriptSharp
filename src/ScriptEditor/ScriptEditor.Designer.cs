namespace ScriptSharp.ScriptEditor
{
    partial class ScriptEditor
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
            this.CodeEdit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CodeEdit
            // 
            this.CodeEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEdit.Location = new System.Drawing.Point(0, 0);
            this.CodeEdit.Multiline = true;
            this.CodeEdit.Name = "CodeEdit";
            this.CodeEdit.Size = new System.Drawing.Size(839, 626);
            this.CodeEdit.TabIndex = 0;
            this.CodeEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeEdit_KeyDown);
            // 
            // ScriptEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 626);
            this.Controls.Add(this.CodeEdit);
            this.Name = "ScriptEditor";
            this.Text = "Script Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodeEdit;
    }
}

