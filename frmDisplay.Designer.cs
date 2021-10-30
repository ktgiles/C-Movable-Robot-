
namespace GilesLab4
{
    partial class frmDisplay
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
            this.lblCoord = new System.Windows.Forms.Label();
            this.pnlField = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlField.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCoord
            // 
            this.lblCoord.AutoSize = true;
            this.lblCoord.Location = new System.Drawing.Point(146, 9);
            this.lblCoord.Name = "lblCoord";
            this.lblCoord.Size = new System.Drawing.Size(42, 13);
            this.lblCoord.TabIndex = 0;
            this.lblCoord.Text = "{ 0 , 0 }";
            // 
            // pnlField
            // 
            this.pnlField.Controls.Add(this.lblRobot);
            this.pnlField.Location = new System.Drawing.Point(19, 42);
            this.pnlField.Name = "pnlField";
            this.pnlField.Size = new System.Drawing.Size(300, 300);
            this.pnlField.TabIndex = 1;
            // 
            // lblRobot
            // 
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 8.25F);
            this.lblRobot.Location = new System.Drawing.Point(142, 142);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(16, 16);
            this.lblRobot.TabIndex = 8;
            this.lblRobot.Text = "v";
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(46, 377);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(50, 23);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "Go 1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(224, 377);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(50, 23);
            this.btnTen.TabIndex = 2;
            this.btnTen.Text = "Go 10";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(149, 348);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(28, 23);
            this.btnN.TabIndex = 3;
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(149, 408);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(28, 23);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(124, 377);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(28, 23);
            this.btnW.TabIndex = 5;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(175, 377);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(28, 23);
            this.btnE.TabIndex = 6;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(254, 425);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 472);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnN);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.pnlField);
            this.Controls.Add(this.lblCoord);
            this.Name = "frmDisplay";
            this.Text = "Robot";
            this.pnlField.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoord;
        private System.Windows.Forms.Panel pnlField;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnN;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRobot;
    }
}

