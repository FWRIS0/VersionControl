﻿
namespace week06
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
            this.components = new System.ComponentModel.Container();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btncar = new System.Windows.Forms.Button();
            this.btnball = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnpresent = new System.Windows.Forms.Button();
            this.btnpresentribbon = new System.Windows.Forms.Button();
            this.btnpresentbox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainpanel.Location = new System.Drawing.Point(12, 156);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(776, 282);
            this.mainpanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btncar
            // 
            this.btncar.Location = new System.Drawing.Point(12, 12);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(105, 42);
            this.btncar.TabIndex = 1;
            this.btncar.Text = "CAR";
            this.btncar.UseVisualStyleBackColor = true;
            this.btncar.Click += new System.EventHandler(this.btncar_Click);
            // 
            // btnball
            // 
            this.btnball.Location = new System.Drawing.Point(123, 12);
            this.btnball.Name = "btnball";
            this.btnball.Size = new System.Drawing.Size(100, 42);
            this.btnball.TabIndex = 2;
            this.btnball.Text = "BALL";
            this.btnball.UseVisualStyleBackColor = true;
            this.btnball.Click += new System.EventHandler(this.btnball_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming next:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncolor
            // 
            this.btncolor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btncolor.Location = new System.Drawing.Point(123, 60);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(100, 42);
            this.btncolor.TabIndex = 4;
            this.btncolor.UseVisualStyleBackColor = false;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnpresent
            // 
            this.btnpresent.Location = new System.Drawing.Point(229, 12);
            this.btnpresent.Name = "btnpresent";
            this.btnpresent.Size = new System.Drawing.Size(100, 42);
            this.btnpresent.TabIndex = 5;
            this.btnpresent.Text = "PRESENT";
            this.btnpresent.UseVisualStyleBackColor = true;
            this.btnpresent.Click += new System.EventHandler(this.btnpresent_Click);
            // 
            // btnpresentribbon
            // 
            this.btnpresentribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnpresentribbon.Location = new System.Drawing.Point(229, 60);
            this.btnpresentribbon.Name = "btnpresentribbon";
            this.btnpresentribbon.Size = new System.Drawing.Size(100, 42);
            this.btnpresentribbon.TabIndex = 6;
            this.btnpresentribbon.UseVisualStyleBackColor = false;
            this.btnpresentribbon.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnpresentbox
            // 
            this.btnpresentbox.BackColor = System.Drawing.Color.Yellow;
            this.btnpresentbox.Location = new System.Drawing.Point(229, 108);
            this.btnpresentbox.Name = "btnpresentbox";
            this.btnpresentbox.Size = new System.Drawing.Size(100, 42);
            this.btnpresentbox.TabIndex = 7;
            this.btnpresentbox.UseVisualStyleBackColor = false;
            this.btnpresentbox.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnpresentbox);
            this.Controls.Add(this.btnpresentribbon);
            this.Controls.Add(this.btnpresent);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnball);
            this.Controls.Add(this.btncar);
            this.Controls.Add(this.mainpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btncar;
        private System.Windows.Forms.Button btnball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Button btnpresent;
        private System.Windows.Forms.Button btnpresentribbon;
        private System.Windows.Forms.Button btnpresentbox;
    }
}

