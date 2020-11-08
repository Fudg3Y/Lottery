namespace LotteryFormsApp
{
    partial class frmTicket
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtBall1 = new System.Windows.Forms.TextBox();
            this.txtBonus = new System.Windows.Forms.TextBox();
            this.txtBall2 = new System.Windows.Forms.TextBox();
            this.txtBall3 = new System.Windows.Forms.TextBox();
            this.txtBall4 = new System.Windows.Forms.TextBox();
            this.txtBall5 = new System.Windows.Forms.TextBox();
            this.txtBall6 = new System.Windows.Forms.TextBox();
            this.pan = new System.Windows.Forms.Panel();
            this.lblBonusBall = new System.Windows.Forms.Label();
            this.lblBalls = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvTickets = new System.Windows.Forms.ListView();
            this.btnListTickets = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.pan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ball Numbers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bonus Ball";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(126, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(126, 50);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtBall1
            // 
            this.txtBall1.Location = new System.Drawing.Point(126, 75);
            this.txtBall1.Name = "txtBall1";
            this.txtBall1.Size = new System.Drawing.Size(31, 20);
            this.txtBall1.TabIndex = 6;
            // 
            // txtBonus
            // 
            this.txtBonus.Location = new System.Drawing.Point(126, 103);
            this.txtBonus.Name = "txtBonus";
            this.txtBonus.Size = new System.Drawing.Size(100, 20);
            this.txtBonus.TabIndex = 7;
            // 
            // txtBall2
            // 
            this.txtBall2.Location = new System.Drawing.Point(163, 75);
            this.txtBall2.Name = "txtBall2";
            this.txtBall2.Size = new System.Drawing.Size(31, 20);
            this.txtBall2.TabIndex = 8;
            // 
            // txtBall3
            // 
            this.txtBall3.Location = new System.Drawing.Point(200, 75);
            this.txtBall3.Name = "txtBall3";
            this.txtBall3.Size = new System.Drawing.Size(31, 20);
            this.txtBall3.TabIndex = 9;
            // 
            // txtBall4
            // 
            this.txtBall4.Location = new System.Drawing.Point(237, 75);
            this.txtBall4.Name = "txtBall4";
            this.txtBall4.Size = new System.Drawing.Size(31, 20);
            this.txtBall4.TabIndex = 10;
            // 
            // txtBall5
            // 
            this.txtBall5.Location = new System.Drawing.Point(274, 75);
            this.txtBall5.Name = "txtBall5";
            this.txtBall5.Size = new System.Drawing.Size(31, 20);
            this.txtBall5.TabIndex = 11;
            // 
            // txtBall6
            // 
            this.txtBall6.Location = new System.Drawing.Point(311, 75);
            this.txtBall6.Name = "txtBall6";
            this.txtBall6.Size = new System.Drawing.Size(31, 20);
            this.txtBall6.TabIndex = 12;
            // 
            // pan
            // 
            this.pan.Controls.Add(this.day);
            this.pan.Controls.Add(this.date);
            this.pan.Controls.Add(this.lblBonusBall);
            this.pan.Controls.Add(this.lblBalls);
            this.pan.Controls.Add(this.lblPhone);
            this.pan.Controls.Add(this.lblName);
            this.pan.Location = new System.Drawing.Point(59, 255);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(283, 139);
            this.pan.TabIndex = 13;
            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTicket_Paint);
            // 
            // lblBonusBall
            // 
            this.lblBonusBall.AutoSize = true;
            this.lblBonusBall.Location = new System.Drawing.Point(50, 78);
            this.lblBonusBall.Name = "lblBonusBall";
            this.lblBonusBall.Size = new System.Drawing.Size(57, 13);
            this.lblBonusBall.TabIndex = 3;
            this.lblBonusBall.Text = "Bonus Ball";
            this.lblBonusBall.Click += new System.EventHandler(this.lblBonusBall_Click);
            // 
            // lblBalls
            // 
            this.lblBalls.AutoSize = true;
            this.lblBalls.Location = new System.Drawing.Point(51, 65);
            this.lblBalls.Name = "lblBalls";
            this.lblBalls.Size = new System.Drawing.Size(29, 13);
            this.lblBalls.TabIndex = 2;
            this.lblBalls.Text = "Balls";
            this.lblBalls.Click += new System.EventHandler(this.lblBalls_Click_1);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(51, 52);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(61, 162);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(105, 52);
            this.btnCreateTicket.TabIndex = 14;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(627, 310);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(161, 84);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvTickets);
            this.groupBox1.Location = new System.Drawing.Point(445, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 234);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "All Tickets";
            // 
            // lvTickets
            // 
            this.lvTickets.HideSelection = false;
            this.lvTickets.Location = new System.Drawing.Point(6, 19);
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(331, 209);
            this.lvTickets.TabIndex = 0;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.SelectedIndexChanged += new System.EventHandler(this.lvTickets_SelectedIndexChanged);
            // 
            // btnListTickets
            // 
            this.btnListTickets.Location = new System.Drawing.Point(445, 310);
            this.btnListTickets.Name = "btnListTickets";
            this.btnListTickets.Size = new System.Drawing.Size(161, 84);
            this.btnListTickets.TabIndex = 17;
            this.btnListTickets.Text = "List All Tickets";
            this.btnListTickets.UseVisualStyleBackColor = true;
            this.btnListTickets.Click += new System.EventHandler(this.button1_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(50, 91);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(30, 13);
            this.date.TabIndex = 4;
            this.date.Text = "Date";
            // 
            // day
            // 
            this.day.AutoSize = true;
            this.day.Location = new System.Drawing.Point(50, 104);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(26, 13);
            this.day.TabIndex = 5;
            this.day.Text = "Day";
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(228, 162);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(105, 52);
            this.btnRandom.TabIndex = 18;
            this.btnRandom.Text = "Lucky Dip";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnListTickets);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnCreateTicket);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.txtBall6);
            this.Controls.Add(this.txtBall5);
            this.Controls.Add(this.txtBall4);
            this.Controls.Add(this.txtBall3);
            this.Controls.Add(this.txtBall2);
            this.Controls.Add(this.txtBonus);
            this.Controls.Add(this.txtBall1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTicket";
            this.Text = "Form1";
            this.pan.ResumeLayout(false);
            this.pan.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtBall1;
        private System.Windows.Forms.TextBox txtBonus;
        private System.Windows.Forms.TextBox txtBall2;
        private System.Windows.Forms.TextBox txtBall3;
        private System.Windows.Forms.TextBox txtBall4;
        private System.Windows.Forms.TextBox txtBall5;
        private System.Windows.Forms.TextBox txtBall6;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblBalls;
        private System.Windows.Forms.Label lblBonusBall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvTickets;
        private System.Windows.Forms.Button btnListTickets;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button btnRandom;
    }
}

