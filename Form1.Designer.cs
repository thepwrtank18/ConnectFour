using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectFour
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.X2Y5 = new System.Windows.Forms.PictureBox();
            this.X3Y5 = new System.Windows.Forms.PictureBox();
            this.X4Y5 = new System.Windows.Forms.PictureBox();
            this.X5Y5 = new System.Windows.Forms.PictureBox();
            this.X5Y4 = new System.Windows.Forms.PictureBox();
            this.X4Y4 = new System.Windows.Forms.PictureBox();
            this.X3Y4 = new System.Windows.Forms.PictureBox();
            this.X2Y4 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.X5Y3 = new System.Windows.Forms.PictureBox();
            this.X4Y3 = new System.Windows.Forms.PictureBox();
            this.X3Y3 = new System.Windows.Forms.PictureBox();
            this.X2Y3 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.X5Y2 = new System.Windows.Forms.PictureBox();
            this.X4Y2 = new System.Windows.Forms.PictureBox();
            this.X3Y2 = new System.Windows.Forms.PictureBox();
            this.X2Y2 = new System.Windows.Forms.PictureBox();
            this.X1Y2 = new System.Windows.Forms.PictureBox();
            this.X5Y1 = new System.Windows.Forms.PictureBox();
            this.X4Y1 = new System.Windows.Forms.PictureBox();
            this.X3Y1 = new System.Windows.Forms.PictureBox();
            this.X2Y1 = new System.Windows.Forms.PictureBox();
            this.X1Y1 = new System.Windows.Forms.PictureBox();
            this.ButtonX1 = new System.Windows.Forms.Button();
            this.ButtonX2 = new System.Windows.Forms.Button();
            this.ButtonX3 = new System.Windows.Forms.Button();
            this.ButtonX4 = new System.Windows.Forms.Button();
            this.ButtonX5 = new System.Windows.Forms.Button();
            this.X1Y5 = new System.Windows.Forms.PictureBox();
            this.X1Y4 = new System.Windows.Forms.PictureBox();
            this.X1Y3 = new System.Windows.Forms.PictureBox();
            this.CurrentUserLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // X2Y5
            // 
            this.X2Y5.BackColor = System.Drawing.Color.Transparent;
            this.X2Y5.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X2Y5.Location = new System.Drawing.Point(118, 50);
            this.X2Y5.Name = "X2Y5";
            this.X2Y5.Size = new System.Drawing.Size(100, 100);
            this.X2Y5.TabIndex = 1;
            this.X2Y5.TabStop = false;
            // 
            // X3Y5
            // 
            this.X3Y5.BackColor = System.Drawing.Color.Transparent;
            this.X3Y5.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X3Y5.Location = new System.Drawing.Point(224, 50);
            this.X3Y5.Name = "X3Y5";
            this.X3Y5.Size = new System.Drawing.Size(100, 100);
            this.X3Y5.TabIndex = 2;
            this.X3Y5.TabStop = false;
            // 
            // X4Y5
            // 
            this.X4Y5.BackColor = System.Drawing.Color.Transparent;
            this.X4Y5.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X4Y5.Location = new System.Drawing.Point(330, 50);
            this.X4Y5.Name = "X4Y5";
            this.X4Y5.Size = new System.Drawing.Size(100, 100);
            this.X4Y5.TabIndex = 3;
            this.X4Y5.TabStop = false;
            // 
            // X5Y5
            // 
            this.X5Y5.BackColor = System.Drawing.Color.Transparent;
            this.X5Y5.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X5Y5.Location = new System.Drawing.Point(436, 50);
            this.X5Y5.Name = "X5Y5";
            this.X5Y5.Size = new System.Drawing.Size(100, 100);
            this.X5Y5.TabIndex = 4;
            this.X5Y5.TabStop = false;
            // 
            // X5Y4
            // 
            this.X5Y4.BackColor = System.Drawing.Color.Transparent;
            this.X5Y4.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X5Y4.Location = new System.Drawing.Point(436, 156);
            this.X5Y4.Name = "X5Y4";
            this.X5Y4.Size = new System.Drawing.Size(100, 100);
            this.X5Y4.TabIndex = 9;
            this.X5Y4.TabStop = false;
            // 
            // X4Y4
            // 
            this.X4Y4.BackColor = System.Drawing.Color.Transparent;
            this.X4Y4.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X4Y4.Location = new System.Drawing.Point(330, 156);
            this.X4Y4.Name = "X4Y4";
            this.X4Y4.Size = new System.Drawing.Size(100, 100);
            this.X4Y4.TabIndex = 8;
            this.X4Y4.TabStop = false;
            // 
            // X3Y4
            // 
            this.X3Y4.BackColor = System.Drawing.Color.Transparent;
            this.X3Y4.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X3Y4.Location = new System.Drawing.Point(224, 156);
            this.X3Y4.Name = "X3Y4";
            this.X3Y4.Size = new System.Drawing.Size(100, 100);
            this.X3Y4.TabIndex = 7;
            this.X3Y4.TabStop = false;
            // 
            // X2Y4
            // 
            this.X2Y4.BackColor = System.Drawing.Color.Transparent;
            this.X2Y4.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X2Y4.Location = new System.Drawing.Point(118, 156);
            this.X2Y4.Name = "X2Y4";
            this.X2Y4.Size = new System.Drawing.Size(100, 100);
            this.X2Y4.TabIndex = 6;
            this.X2Y4.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Location = new System.Drawing.Point(12, 156);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(100, 100);
            this.pictureBox10.TabIndex = 5;
            this.pictureBox10.TabStop = false;
            // 
            // X5Y3
            // 
            this.X5Y3.BackColor = System.Drawing.Color.Transparent;
            this.X5Y3.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X5Y3.Location = new System.Drawing.Point(436, 262);
            this.X5Y3.Name = "X5Y3";
            this.X5Y3.Size = new System.Drawing.Size(100, 100);
            this.X5Y3.TabIndex = 14;
            this.X5Y3.TabStop = false;
            // 
            // X4Y3
            // 
            this.X4Y3.BackColor = System.Drawing.Color.Transparent;
            this.X4Y3.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X4Y3.Location = new System.Drawing.Point(330, 262);
            this.X4Y3.Name = "X4Y3";
            this.X4Y3.Size = new System.Drawing.Size(100, 100);
            this.X4Y3.TabIndex = 13;
            this.X4Y3.TabStop = false;
            // 
            // X3Y3
            // 
            this.X3Y3.BackColor = System.Drawing.Color.Transparent;
            this.X3Y3.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X3Y3.Location = new System.Drawing.Point(224, 262);
            this.X3Y3.Name = "X3Y3";
            this.X3Y3.Size = new System.Drawing.Size(100, 100);
            this.X3Y3.TabIndex = 12;
            this.X3Y3.TabStop = false;
            // 
            // X2Y3
            // 
            this.X2Y3.BackColor = System.Drawing.Color.Transparent;
            this.X2Y3.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X2Y3.Location = new System.Drawing.Point(118, 262);
            this.X2Y3.Name = "X2Y3";
            this.X2Y3.Size = new System.Drawing.Size(100, 100);
            this.X2Y3.TabIndex = 11;
            this.X2Y3.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Location = new System.Drawing.Point(12, 262);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(100, 100);
            this.pictureBox15.TabIndex = 10;
            this.pictureBox15.TabStop = false;
            // 
            // X5Y2
            // 
            this.X5Y2.BackColor = System.Drawing.Color.Transparent;
            this.X5Y2.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X5Y2.Location = new System.Drawing.Point(436, 368);
            this.X5Y2.Name = "X5Y2";
            this.X5Y2.Size = new System.Drawing.Size(100, 100);
            this.X5Y2.TabIndex = 19;
            this.X5Y2.TabStop = false;
            // 
            // X4Y2
            // 
            this.X4Y2.BackColor = System.Drawing.Color.Transparent;
            this.X4Y2.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X4Y2.Location = new System.Drawing.Point(330, 368);
            this.X4Y2.Name = "X4Y2";
            this.X4Y2.Size = new System.Drawing.Size(100, 100);
            this.X4Y2.TabIndex = 18;
            this.X4Y2.TabStop = false;
            // 
            // X3Y2
            // 
            this.X3Y2.BackColor = System.Drawing.Color.Transparent;
            this.X3Y2.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X3Y2.Location = new System.Drawing.Point(224, 368);
            this.X3Y2.Name = "X3Y2";
            this.X3Y2.Size = new System.Drawing.Size(100, 100);
            this.X3Y2.TabIndex = 17;
            this.X3Y2.TabStop = false;
            // 
            // X2Y2
            // 
            this.X2Y2.BackColor = System.Drawing.Color.Transparent;
            this.X2Y2.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X2Y2.Location = new System.Drawing.Point(118, 368);
            this.X2Y2.Name = "X2Y2";
            this.X2Y2.Size = new System.Drawing.Size(100, 100);
            this.X2Y2.TabIndex = 16;
            this.X2Y2.TabStop = false;
            // 
            // X1Y2
            // 
            this.X1Y2.BackColor = System.Drawing.Color.Transparent;
            this.X1Y2.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X1Y2.Location = new System.Drawing.Point(12, 368);
            this.X1Y2.Name = "X1Y2";
            this.X1Y2.Size = new System.Drawing.Size(100, 100);
            this.X1Y2.TabIndex = 15;
            this.X1Y2.TabStop = false;
            // 
            // X5Y1
            // 
            this.X5Y1.BackColor = System.Drawing.Color.Transparent;
            this.X5Y1.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X5Y1.Location = new System.Drawing.Point(436, 474);
            this.X5Y1.Name = "X5Y1";
            this.X5Y1.Size = new System.Drawing.Size(100, 100);
            this.X5Y1.TabIndex = 24;
            this.X5Y1.TabStop = false;
            // 
            // X4Y1
            // 
            this.X4Y1.BackColor = System.Drawing.Color.Transparent;
            this.X4Y1.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X4Y1.Location = new System.Drawing.Point(330, 474);
            this.X4Y1.Name = "X4Y1";
            this.X4Y1.Size = new System.Drawing.Size(100, 100);
            this.X4Y1.TabIndex = 23;
            this.X4Y1.TabStop = false;
            // 
            // X3Y1
            // 
            this.X3Y1.BackColor = System.Drawing.Color.Transparent;
            this.X3Y1.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X3Y1.Location = new System.Drawing.Point(224, 474);
            this.X3Y1.Name = "X3Y1";
            this.X3Y1.Size = new System.Drawing.Size(100, 100);
            this.X3Y1.TabIndex = 22;
            this.X3Y1.TabStop = false;
            // 
            // X2Y1
            // 
            this.X2Y1.BackColor = System.Drawing.Color.Transparent;
            this.X2Y1.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X2Y1.Location = new System.Drawing.Point(118, 474);
            this.X2Y1.Name = "X2Y1";
            this.X2Y1.Size = new System.Drawing.Size(100, 100);
            this.X2Y1.TabIndex = 21;
            this.X2Y1.TabStop = false;
            // 
            // X1Y1
            // 
            this.X1Y1.BackColor = System.Drawing.Color.Transparent;
            this.X1Y1.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X1Y1.Location = new System.Drawing.Point(12, 474);
            this.X1Y1.Name = "X1Y1";
            this.X1Y1.Size = new System.Drawing.Size(100, 100);
            this.X1Y1.TabIndex = 20;
            this.X1Y1.TabStop = false;
            // 
            // ButtonX1
            // 
            this.ButtonX1.Location = new System.Drawing.Point(12, 21);
            this.ButtonX1.Name = "ButtonX1";
            this.ButtonX1.Size = new System.Drawing.Size(100, 23);
            this.ButtonX1.TabIndex = 25;
            this.ButtonX1.Text = "Add coin";
            this.ButtonX1.UseVisualStyleBackColor = true;
            this.ButtonX1.Click += new System.EventHandler(this.ButtonX1_Click);
            // 
            // ButtonX2
            // 
            this.ButtonX2.Location = new System.Drawing.Point(118, 21);
            this.ButtonX2.Name = "ButtonX2";
            this.ButtonX2.Size = new System.Drawing.Size(100, 23);
            this.ButtonX2.TabIndex = 26;
            this.ButtonX2.Text = "Add coin";
            this.ButtonX2.UseVisualStyleBackColor = true;
            this.ButtonX2.Click += new System.EventHandler(this.ButtonX2_Click);
            // 
            // ButtonX3
            // 
            this.ButtonX3.Location = new System.Drawing.Point(224, 21);
            this.ButtonX3.Name = "ButtonX3";
            this.ButtonX3.Size = new System.Drawing.Size(100, 23);
            this.ButtonX3.TabIndex = 27;
            this.ButtonX3.Text = "Add coin";
            this.ButtonX3.UseVisualStyleBackColor = true;
            this.ButtonX3.Click += new System.EventHandler(this.ButtonX3_Click);
            // 
            // ButtonX4
            // 
            this.ButtonX4.Location = new System.Drawing.Point(330, 21);
            this.ButtonX4.Name = "ButtonX4";
            this.ButtonX4.Size = new System.Drawing.Size(100, 23);
            this.ButtonX4.TabIndex = 28;
            this.ButtonX4.Text = "Add coin";
            this.ButtonX4.UseVisualStyleBackColor = true;
            this.ButtonX4.Click += new System.EventHandler(this.ButtonX4_Click);
            // 
            // ButtonX5
            // 
            this.ButtonX5.Location = new System.Drawing.Point(434, 21);
            this.ButtonX5.Name = "ButtonX5";
            this.ButtonX5.Size = new System.Drawing.Size(100, 23);
            this.ButtonX5.TabIndex = 29;
            this.ButtonX5.Text = "Add coin";
            this.ButtonX5.UseVisualStyleBackColor = true;
            this.ButtonX5.Click += new System.EventHandler(this.ButtonX5_Click);
            // 
            // X1Y5
            // 
            this.X1Y5.BackColor = System.Drawing.Color.Transparent;
            this.X1Y5.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X1Y5.Location = new System.Drawing.Point(12, 51);
            this.X1Y5.Name = "X1Y5";
            this.X1Y5.Size = new System.Drawing.Size(100, 100);
            this.X1Y5.TabIndex = 0;
            this.X1Y5.TabStop = false;
            // 
            // X1Y4
            // 
            this.X1Y4.BackColor = System.Drawing.Color.Transparent;
            this.X1Y4.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X1Y4.Location = new System.Drawing.Point(12, 156);
            this.X1Y4.Name = "X1Y4";
            this.X1Y4.Size = new System.Drawing.Size(100, 100);
            this.X1Y4.TabIndex = 5;
            this.X1Y4.TabStop = false;
            // 
            // X1Y3
            // 
            this.X1Y3.BackColor = System.Drawing.Color.Transparent;
            this.X1Y3.Image = global::ConnectFour.Properties.Resources.image_blank;
            this.X1Y3.Location = new System.Drawing.Point(12, 262);
            this.X1Y3.Name = "X1Y3";
            this.X1Y3.Size = new System.Drawing.Size(100, 100);
            this.X1Y3.TabIndex = 10;
            this.X1Y3.TabStop = false;
            // 
            // CurrentUserLabel
            // 
            this.CurrentUserLabel.AutoSize = true;
            this.CurrentUserLabel.Location = new System.Drawing.Point(12, 587);
            this.CurrentUserLabel.Name = "CurrentUserLabel";
            this.CurrentUserLabel.Size = new System.Drawing.Size(59, 15);
            this.CurrentUserLabel.TabIndex = 30;
            this.CurrentUserLabel.Text = "Loading...";
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(12, 21);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(522, 23);
            this.RestartButton.TabIndex = 31;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Visible = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 611);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.CurrentUserLabel);
            this.Controls.Add(this.ButtonX5);
            this.Controls.Add(this.ButtonX4);
            this.Controls.Add(this.ButtonX3);
            this.Controls.Add(this.ButtonX2);
            this.Controls.Add(this.ButtonX1);
            this.Controls.Add(this.X5Y1);
            this.Controls.Add(this.X4Y1);
            this.Controls.Add(this.X3Y1);
            this.Controls.Add(this.X2Y1);
            this.Controls.Add(this.X1Y1);
            this.Controls.Add(this.X5Y2);
            this.Controls.Add(this.X4Y2);
            this.Controls.Add(this.X3Y2);
            this.Controls.Add(this.X2Y2);
            this.Controls.Add(this.X1Y2);
            this.Controls.Add(this.X5Y3);
            this.Controls.Add(this.X4Y3);
            this.Controls.Add(this.X3Y3);
            this.Controls.Add(this.X2Y3);
            this.Controls.Add(this.X1Y3);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.X5Y4);
            this.Controls.Add(this.X4Y4);
            this.Controls.Add(this.X3Y4);
            this.Controls.Add(this.X2Y4);
            this.Controls.Add(this.X1Y4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.X5Y5);
            this.Controls.Add(this.X4Y5);
            this.Controls.Add(this.X3Y5);
            this.Controls.Add(this.X2Y5);
            this.Controls.Add(this.X1Y5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Connect Four";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X5Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X4Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X3Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X2Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Y3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox X2Y5;
        private PictureBox X3Y5;
        private PictureBox X4Y5;
        private PictureBox X5Y5;
        private PictureBox X5Y4;
        private PictureBox X4Y4;
        private PictureBox X3Y4;
        private PictureBox X2Y4;
        private PictureBox pictureBox10;
        private PictureBox X5Y3;
        private PictureBox X4Y3;
        private PictureBox X3Y3;
        private PictureBox X2Y3;
        private PictureBox pictureBox15;
        private PictureBox X5Y2;
        private PictureBox X4Y2;
        private PictureBox X3Y2;
        private PictureBox X2Y2;
        private PictureBox X1Y2;
        private PictureBox X5Y1;
        private PictureBox X4Y1;
        private PictureBox X3Y1;
        private PictureBox X2Y1;
        private PictureBox X1Y1;
        private Button ButtonX1;
        private Button ButtonX2;
        private Button ButtonX3;
        private Button ButtonX4;
        private Button ButtonX5;
        private PictureBox X1Y5;
        private PictureBox X1Y4;
        private PictureBox X1Y3;
        private Label CurrentUserLabel;
        private Button RestartButton;
    }
}