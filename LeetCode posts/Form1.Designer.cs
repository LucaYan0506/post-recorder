
namespace LeetCode_posts
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
            this.ListPanel = new System.Windows.Forms.Panel();
            this.AddCmd = new System.Windows.Forms.Button();
            this.SaveCmd = new System.Windows.Forms.Button();
            this.ResetCmd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.AutoScroll = true;
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(800, 462);
            this.ListPanel.TabIndex = 0;
            // 
            // AddCmd
            // 
            this.AddCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCmd.Location = new System.Drawing.Point(659, 418);
            this.AddCmd.Name = "AddCmd";
            this.AddCmd.Size = new System.Drawing.Size(118, 32);
            this.AddCmd.TabIndex = 0;
            this.AddCmd.Text = "Add";
            this.AddCmd.UseVisualStyleBackColor = true;
            this.AddCmd.Click += new System.EventHandler(this.AddCmd_Click);
            // 
            // SaveCmd
            // 
            this.SaveCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCmd.Location = new System.Drawing.Point(659, 380);
            this.SaveCmd.Name = "SaveCmd";
            this.SaveCmd.Size = new System.Drawing.Size(118, 32);
            this.SaveCmd.TabIndex = 1;
            this.SaveCmd.Text = "Save";
            this.SaveCmd.UseVisualStyleBackColor = true;
            this.SaveCmd.Click += new System.EventHandler(this.SaveCmd_Click);
            // 
            // ResetCmd
            // 
            this.ResetCmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetCmd.Location = new System.Drawing.Point(659, 342);
            this.ResetCmd.Name = "ResetCmd";
            this.ResetCmd.Size = new System.Drawing.Size(118, 32);
            this.ResetCmd.TabIndex = 1;
            this.ResetCmd.Text = "Reset";
            this.ResetCmd.UseVisualStyleBackColor = true;
            this.ResetCmd.Click += new System.EventHandler(this.ResetCmd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.AddCmd);
            this.Controls.Add(this.SaveCmd);
            this.Controls.Add(this.ResetCmd);
            this.Controls.Add(this.ListPanel);
            this.MinimumSize = new System.Drawing.Size(161, 171);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Button AddCmd;
        private System.Windows.Forms.Button SaveCmd;
        private System.Windows.Forms.Button ResetCmd;
    }
}

