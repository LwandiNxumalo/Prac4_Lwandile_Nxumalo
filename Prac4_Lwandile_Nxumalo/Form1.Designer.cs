
namespace Prac4_Lwandile_Nxumalo
{
    partial class frmCalculator
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
            this.gbxInput = new System.Windows.Forms.GroupBox();
            this.txtRadiusInput = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCircumfOutput = new System.Windows.Forms.Label();
            this.lblAreaOutput = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCircumf = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblVolumeOutput = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxInput.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxInput
            // 
            this.gbxInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxInput.Controls.Add(this.txtRadiusInput);
            this.gbxInput.Controls.Add(this.lblRadius);
            this.gbxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxInput.Location = new System.Drawing.Point(89, 40);
            this.gbxInput.Name = "gbxInput";
            this.gbxInput.Size = new System.Drawing.Size(489, 124);
            this.gbxInput.TabIndex = 0;
            this.gbxInput.TabStop = false;
            this.gbxInput.Text = "Input";
            // 
            // txtRadiusInput
            // 
            this.txtRadiusInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRadiusInput.Location = new System.Drawing.Point(196, 49);
            this.txtRadiusInput.Name = "txtRadiusInput";
            this.txtRadiusInput.Size = new System.Drawing.Size(100, 24);
            this.txtRadiusInput.TabIndex = 1;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(129, 57);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(51, 16);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.lblCircumfOutput);
            this.groupBox2.Controls.Add(this.lblAreaOutput);
            this.groupBox2.Controls.Add(this.lblArea);
            this.groupBox2.Controls.Add(this.lblCircumf);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(89, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 118);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Circle Calculations";
            // 
            // lblCircumfOutput
            // 
            this.lblCircumfOutput.AutoSize = true;
            this.lblCircumfOutput.Location = new System.Drawing.Point(137, 71);
            this.lblCircumfOutput.Name = "lblCircumfOutput";
            this.lblCircumfOutput.Size = new System.Drawing.Size(0, 18);
            this.lblCircumfOutput.TabIndex = 2;
            // 
            // lblAreaOutput
            // 
            this.lblAreaOutput.AutoSize = true;
            this.lblAreaOutput.Location = new System.Drawing.Point(68, 34);
            this.lblAreaOutput.Name = "lblAreaOutput";
            this.lblAreaOutput.Size = new System.Drawing.Size(0, 18);
            this.lblAreaOutput.TabIndex = 1;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(20, 34);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(42, 18);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Area:";
            // 
            // lblCircumf
            // 
            this.lblCircumf.AutoSize = true;
            this.lblCircumf.Location = new System.Drawing.Point(20, 71);
            this.lblCircumf.Name = "lblCircumf";
            this.lblCircumf.Size = new System.Drawing.Size(109, 18);
            this.lblCircumf.TabIndex = 0;
            this.lblCircumf.Text = "Circumference:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox3.Controls.Add(this.lblVolumeOutput);
            this.groupBox3.Controls.Add(this.lblVolume);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(371, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 118);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sphere Calculations";
            // 
            // lblVolumeOutput
            // 
            this.lblVolumeOutput.AutoSize = true;
            this.lblVolumeOutput.Location = new System.Drawing.Point(92, 34);
            this.lblVolumeOutput.Name = "lblVolumeOutput";
            this.lblVolumeOutput.Size = new System.Drawing.Size(0, 18);
            this.lblVolumeOutput.TabIndex = 2;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(24, 34);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(62, 18);
            this.lblVolume.TabIndex = 1;
            this.lblVolume.Text = "Volume:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(89, 385);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 39);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(273, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(112, 39);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(466, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxInput);
            this.Name = "frmCalculator";
            this.Text = "Form1";
            this.gbxInput.ResumeLayout(false);
            this.gbxInput.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRadiusInput;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblCircumfOutput;
        private System.Windows.Forms.Label lblAreaOutput;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCircumf;
        private System.Windows.Forms.Label lblVolumeOutput;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

