﻿using System.ComponentModel;

namespace Calendar
{
    partial class UserControlDays
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbdays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbdays
            // 
            this.lbdays.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lbdays.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdays.Location = new System.Drawing.Point(0, 0);
            this.lbdays.Name = "lbdays";
            this.lbdays.Size = new System.Drawing.Size(126, 64);
            this.lbdays.TabIndex = 0;
            this.lbdays.Text = "00";
            this.lbdays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbdays.Click += new System.EventHandler(this.lbdays_Click);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.Controls.Add(this.lbdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(126, 64);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbdays;

        #endregion
    }
}