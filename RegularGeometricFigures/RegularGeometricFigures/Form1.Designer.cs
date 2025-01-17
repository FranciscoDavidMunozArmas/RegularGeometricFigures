﻿
namespace RegularGeometricFigures
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
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.grbNSides = new System.Windows.Forms.GroupBox();
            this.tkbSides = new System.Windows.Forms.TrackBar();
            this.grbSolution = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbInput.SuspendLayout();
            this.grbNSides.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSides)).BeginInit();
            this.grbSolution.SuspendLayout();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.txtSize);
            this.grbInput.Controls.Add(this.lblSize);
            this.grbInput.Location = new System.Drawing.Point(13, 13);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(178, 53);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Input";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(41, 20);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(100, 20);
            this.txtSize.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(7, 20);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(27, 13);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Size";
            // 
            // grbNSides
            // 
            this.grbNSides.Controls.Add(this.tkbSides);
            this.grbNSides.Location = new System.Drawing.Point(13, 73);
            this.grbNSides.Name = "grbNSides";
            this.grbNSides.Size = new System.Drawing.Size(178, 71);
            this.grbNSides.TabIndex = 1;
            this.grbNSides.TabStop = false;
            this.grbNSides.Text = "Number of Sides";
            // 
            // tkbSides
            // 
            this.tkbSides.Location = new System.Drawing.Point(7, 20);
            this.tkbSides.Maximum = 12;
            this.tkbSides.Minimum = 3;
            this.tkbSides.Name = "tkbSides";
            this.tkbSides.Size = new System.Drawing.Size(165, 45);
            this.tkbSides.TabIndex = 0;
            this.tkbSides.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tkbSides.Value = 3;
            this.tkbSides.ValueChanged += new System.EventHandler(this.tkbSides_ValueChanged);
            // 
            // grbSolution
            // 
            this.grbSolution.Controls.Add(this.txtArea);
            this.grbSolution.Controls.Add(this.txtPerimeter);
            this.grbSolution.Controls.Add(this.lblPerimeter);
            this.grbSolution.Controls.Add(this.lblArea);
            this.grbSolution.Location = new System.Drawing.Point(13, 151);
            this.grbSolution.Name = "grbSolution";
            this.grbSolution.Size = new System.Drawing.Size(178, 75);
            this.grbSolution.TabIndex = 2;
            this.grbSolution.TabStop = false;
            this.grbSolution.Text = "Solution";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(72, 16);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 5;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(72, 42);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 20);
            this.txtPerimeter.TabIndex = 4;
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(8, 42);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(57, 13);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "Perimeter :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(7, 16);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area :";
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Location = new System.Drawing.Point(198, 13);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(315, 219);
            this.grbCanvas.TabIndex = 3;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Canvas";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(6, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(303, 194);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(65, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnExit);
            this.grbButtons.Controls.Add(this.btnRestart);
            this.grbButtons.Controls.Add(this.btnCalculate);
            this.grbButtons.Location = new System.Drawing.Point(520, 13);
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.Size = new System.Drawing.Size(80, 219);
            this.grbButtons.TabIndex = 5;
            this.grbButtons.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(6, 98);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(65, 23);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 190);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 240);
            this.Controls.Add(this.grbButtons);
            this.Controls.Add(this.grbCanvas);
            this.Controls.Add(this.grbSolution);
            this.Controls.Add(this.grbNSides);
            this.Controls.Add(this.grbInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbInput.ResumeLayout(false);
            this.grbInput.PerformLayout();
            this.grbNSides.ResumeLayout(false);
            this.grbNSides.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSides)).EndInit();
            this.grbSolution.ResumeLayout(false);
            this.grbSolution.PerformLayout();
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.GroupBox grbNSides;
        private System.Windows.Forms.TrackBar tkbSides;
        private System.Windows.Forms.GroupBox grbSolution;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRestart;
    }
}

