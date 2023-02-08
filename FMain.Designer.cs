namespace OneDriveSuspender
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.btnSelectAppToActivate = new System.Windows.Forms.Button();
            this.tBoxAppToActivate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectAppToActivate
            // 
            this.btnSelectAppToActivate.Location = new System.Drawing.Point(505, 13);
            this.btnSelectAppToActivate.Name = "btnSelectAppToActivate";
            this.btnSelectAppToActivate.Size = new System.Drawing.Size(24, 23);
            this.btnSelectAppToActivate.TabIndex = 0;
            this.btnSelectAppToActivate.Text = "...";
            this.btnSelectAppToActivate.UseVisualStyleBackColor = true;
            this.btnSelectAppToActivate.Click += new System.EventHandler(this.btnSelectAppToActivate_Click);
            // 
            // tBoxAppToActivate
            // 
            this.tBoxAppToActivate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.tBoxAppToActivate.Location = new System.Drawing.Point(204, 13);
            this.tBoxAppToActivate.Name = "tBoxAppToActivate";
            this.tBoxAppToActivate.ReadOnly = true;
            this.tBoxAppToActivate.Size = new System.Drawing.Size(295, 23);
            this.tBoxAppToActivate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Application to Suspend OneDrive:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(454, 70);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(373, 70);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create .bat";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblConfirm
            // 
            this.lblConfirm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(373, 52);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConfirm.Size = new System.Drawing.Size(73, 15);
            this.lblConfirm.TabIndex = 5;
            this.lblConfirm.Text = ".bat Created!";
            this.lblConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(540, 105);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxAppToActivate);
            this.Controls.Add(this.btnSelectAppToActivate);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneDrive Suspender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSelectAppToActivate;
        private TextBox tBoxAppToActivate;
        private Label label1;
        private Button btnExit;
        private Button btnCreate;
        private Label lblConfirm;
    }
}