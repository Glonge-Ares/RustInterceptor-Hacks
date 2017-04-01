using System;
using System.Threading;
using System.Windows.Forms;

namespace Box {
    partial class Overlay {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overlay));
            this.SuspendLayout();
            // 
            // OverLay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(0, 0);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverLay";
            this.Text = "Box";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.LoadForm);
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(KDOWN);
            //this.MouseDown += new System.Windows.Forms.MouseEventHandler(MDOWN);
            //this.MouseUp += new System.Windows.Forms.MouseEventHandler(MUP);
            //this.KeyUp += new System.Windows.Forms.KeyEventHandler(KUP);
            this.ResumeLayout(false);

        }
        /*
        private bool ctrl = false;
        private bool mouse = false;

        private void MUP(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                mouse = true;
            }
        }

        private void KDOWN(object sender, KeyEventArgs e) {
            if (e.Control) {
                ctrl = true;
            }
        }

        private void MDOWN(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                mouse = false;
            }
        }

        private void KUP(object sender, KeyEventArgs e) {
            if (e.Control) {
                ctrl = false;
            }
        }

        private void move() {
            while (true) {
                if (ctrl && mouse) {
                    Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y - 4);
                    Thread.Sleep(1);
                    Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y - 5);
                    Thread.Sleep(23);
                    Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y - 6);
                    Thread.Sleep(30);
                    Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y - 8);
                    Thread.Sleep(42);
                    Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y - 12);
                }
            }
        }
        */

        #endregion
    }
}

