
namespace _26092022
{
    partial class frmDemonstracaoKey
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.bttReset = new System.Windows.Forms.Button();
            this.bttMinus = new System.Windows.Forms.Button();
            this.lblMiles = new System.Windows.Forms.Button();
            this.lblLower = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(8, 8);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 0;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(8, 40);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(305, 233);
            this.txtMsg.TabIndex = 1;
            this.txtMsg.TabStop = false;
            // 
            // bttReset
            // 
            this.bttReset.Location = new System.Drawing.Point(328, 8);
            this.bttReset.Name = "bttReset";
            this.bttReset.Size = new System.Drawing.Size(75, 28);
            this.bttReset.TabIndex = 2;
            this.bttReset.Text = "Limpa";
            this.bttReset.UseVisualStyleBackColor = true;
            // 
            // bttMinus
            // 
            this.bttMinus.Location = new System.Drawing.Point(328, 52);
            this.bttMinus.Name = "bttMinus";
            this.bttMinus.Size = new System.Drawing.Size(40, 13);
            this.bttMinus.TabIndex = 3;
            this.bttMinus.Text = "Minus.";
            this.bttMinus.UseVisualStyleBackColor = true;
            // 
            // lblMiles
            // 
            this.lblMiles.Location = new System.Drawing.Point(328, 87);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(40, 13);
            this.lblMiles.TabIndex = 4;
            this.lblMiles.Text = "Miles.";
            this.lblMiles.UseVisualStyleBackColor = true;
            // 
            // lblLower
            // 
            this.lblLower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLower.Location = new System.Drawing.Point(374, 87);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(32, 23);
            this.lblLower.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(374, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 5;
            // 
            // frmDemonstracaoKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.bttMinus);
            this.Controls.Add(this.bttReset);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtInput);
            this.Location = new System.Drawing.Point(8, 8);
            this.Name = "frmDemonstracaoKey";
            this.Text = "frmDemonstracaoKey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button bttReset;
        private System.Windows.Forms.Button bttMinus;
        private System.Windows.Forms.Button lblMiles;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.Label label1;
    }
}