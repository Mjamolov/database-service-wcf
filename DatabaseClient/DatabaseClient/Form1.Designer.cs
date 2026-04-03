namespace DatabaseClient
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnGetVersion = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(200, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 20);
            this.lblTitle.Text = "Работа с SQL Server через WCF";

            // BtnConnect
            this.BtnConnect.Location = new System.Drawing.Point(50, 70);
            this.BtnConnect.Size = new System.Drawing.Size(180, 40);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Text = "Подключиться";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);

            // BtnGetVersion
            this.BtnGetVersion.Location = new System.Drawing.Point(250, 70);
            this.BtnGetVersion.Size = new System.Drawing.Size(180, 40);
            this.BtnGetVersion.Name = "BtnGetVersion";
            this.BtnGetVersion.Text = "Получить версию";
            this.BtnGetVersion.UseVisualStyleBackColor = true;
            this.BtnGetVersion.Click += new System.EventHandler(this.BtnGetVersion_Click);

            // BtnDisconnect
            this.BtnDisconnect.Location = new System.Drawing.Point(450, 70);
            this.BtnDisconnect.Size = new System.Drawing.Size(180, 40);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Text = "Отключиться";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);

            // txtOutput
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtOutput.Multiline = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Height = 180;
            this.txtOutput.Name = "txtOutput";

            // Form1
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnConnect);
            this.Controls.Add(this.BtnGetVersion);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.txtOutput);
            this.Name = "Form1";
            this.Text = "SQL Service Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnGetVersion;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblTitle;
    }
}

