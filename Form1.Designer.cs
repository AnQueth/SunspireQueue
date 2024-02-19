
namespace SunspireQueue
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            lbPeopleInQueue = new ListBox();
            lblCurrentTombPerson = new Label();
            txtName = new TextBox();
            btnAddToQueue = new Button();
            lbPeopleDead = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtSeconds = new TextBox();
            timerCheckWhenGo = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lbPeopleInQueue
            // 
            lbPeopleInQueue.DrawMode = DrawMode.OwnerDrawFixed;
            lbPeopleInQueue.FormattingEnabled = true;
            lbPeopleInQueue.Location = new Point(49, 149);
            lbPeopleInQueue.Name = "lbPeopleInQueue";
            lbPeopleInQueue.Size = new Size(529, 244);
            lbPeopleInQueue.TabIndex = 0;
            lbPeopleInQueue.DrawItem += lbPeopleInQueue_DrawItem;
            lbPeopleInQueue.KeyDown += lbPeopleInQueue_KeyDown;
            // 
            // lblCurrentTombPerson
            // 
            lblCurrentTombPerson.AutoSize = true;
            lblCurrentTombPerson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentTombPerson.Location = new Point(191, 18);
            lblCurrentTombPerson.Name = "lblCurrentTombPerson";
            lblCurrentTombPerson.Size = new Size(194, 28);
            lblCurrentTombPerson.TabIndex = 1;
            lblCurrentTombPerson.Text = "Current Tomb Person";
            // 
            // txtName
            // 
            txtName.Location = new Point(49, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(188, 27);
            txtName.TabIndex = 2;
            txtName.KeyUp += txtName_KeyUp;
            // 
            // btnAddToQueue
            // 
            btnAddToQueue.Location = new Point(243, 69);
            btnAddToQueue.Name = "btnAddToQueue";
            btnAddToQueue.Size = new Size(94, 29);
            btnAddToQueue.TabIndex = 3;
            btnAddToQueue.Text = "Add";
            btnAddToQueue.UseVisualStyleBackColor = true;
            btnAddToQueue.Click += btnAddToQueue_Click;
            // 
            // lbPeopleDead
            // 
            lbPeopleDead.FormattingEnabled = true;
            lbPeopleDead.Location = new Point(602, 149);
            lbPeopleDead.Name = "lbPeopleDead";
            lbPeopleDead.Size = new Size(319, 244);
            lbPeopleDead.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 109);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 6;
            label1.Text = "Tomb Queue";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(602, 109);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 7;
            label2.Text = "Dead People";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 25);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 8;
            label3.Text = "Current Person:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 22);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 9;
            label4.Text = "ctrl-n rotate queue";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 55);
            label5.Name = "label5";
            label5.Size = new Size(220, 20);
            label5.TabIndex = 10;
            label5.Text = "ctrl-number mark dead or resed";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 111);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 11;
            label6.Text = "Time Between Go";
            // 
            // txtSeconds
            // 
            txtSeconds.Location = new Point(419, 108);
            txtSeconds.Name = "txtSeconds";
            txtSeconds.Size = new Size(125, 27);
            txtSeconds.TabIndex = 12;
            txtSeconds.Text = "30";
            // 
            // timerCheckWhenGo
            // 
            timerCheckWhenGo.Enabled = true;
            timerCheckWhenGo.Interval = 500;
            timerCheckWhenGo.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 450);
            Controls.Add(txtSeconds);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbPeopleDead);
            Controls.Add(btnAddToQueue);
            Controls.Add(txtName);
            Controls.Add(lblCurrentTombPerson);
            Controls.Add(lbPeopleInQueue);
            Name = "Form1";
            Text = "Queue";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ListBox lbPeopleInQueue;
        private Label lblCurrentTombPerson;
        private TextBox txtName;
        private Button btnAddToQueue;
        private ListBox lbPeopleDead;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtSeconds;
        private System.Windows.Forms.Timer timerCheckWhenGo;
    }
}
