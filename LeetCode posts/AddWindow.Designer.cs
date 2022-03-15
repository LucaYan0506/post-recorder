
namespace LeetCode_posts
{
    partial class AddWindow
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
            this.SubmitCmd = new System.Windows.Forms.Button();
            this.ProbNameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UrlText = new System.Windows.Forms.TextBox();
            this.CancelCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubmitCmd
            // 
            this.SubmitCmd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SubmitCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitCmd.Location = new System.Drawing.Point(520, 117);
            this.SubmitCmd.Name = "SubmitCmd";
            this.SubmitCmd.Size = new System.Drawing.Size(130, 36);
            this.SubmitCmd.TabIndex = 0;
            this.SubmitCmd.Text = "Submit";
            this.SubmitCmd.UseVisualStyleBackColor = false;
            this.SubmitCmd.Click += new System.EventHandler(this.SubmitCmd_Click);
            // 
            // ProbNameText
            // 
            this.ProbNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProbNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProbNameText.Location = new System.Drawing.Point(12, 32);
            this.ProbNameText.Name = "ProbNameText";
            this.ProbNameText.Size = new System.Drawing.Size(638, 24);
            this.ProbNameText.TabIndex = 1;
            this.ProbNameText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Esc_Submit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of the problem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Url";
            // 
            // UrlText
            // 
            this.UrlText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrlText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlText.Location = new System.Drawing.Point(12, 87);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(638, 24);
            this.UrlText.TabIndex = 3;
            this.UrlText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Esc_Submit);
            // 
            // CancelCmd
            // 
            this.CancelCmd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelCmd.Location = new System.Drawing.Point(12, 117);
            this.CancelCmd.Name = "CancelCmd";
            this.CancelCmd.Size = new System.Drawing.Size(114, 36);
            this.CancelCmd.TabIndex = 0;
            this.CancelCmd.Text = "Cancel";
            this.CancelCmd.UseVisualStyleBackColor = false;
            this.CancelCmd.Click += new System.EventHandler(this.CancelCmd_Click);
            // 
            // AddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(662, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrlText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProbNameText);
            this.Controls.Add(this.CancelCmd);
            this.Controls.Add(this.SubmitCmd);
            this.Name = "AddWindow";
            this.Text = "AddWindow";
            this.Load += new System.EventHandler(this.AddWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SubmitCmd;
        private System.Windows.Forms.TextBox ProbNameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.Button CancelCmd;
    }
}