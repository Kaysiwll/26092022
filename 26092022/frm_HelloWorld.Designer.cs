
namespace _26092022
{
    partial class frm_HelloWorld
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btt_Close = new System.Windows.Forms.Button();
            this.btt_ModificaLabel = new System.Windows.Forms.Button();
            this.txtConteudoLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 23);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(206, 19);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Visual Studio. Net Version";
            // 
            // btt_Close
            // 
            this.btt_Close.BackColor = System.Drawing.Color.Yellow;
            this.btt_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_Close.ForeColor = System.Drawing.Color.Red;
            this.btt_Close.Location = new System.Drawing.Point(224, 12);
            this.btt_Close.Name = "btt_Close";
            this.btt_Close.Size = new System.Drawing.Size(564, 37);
            this.btt_Close.TabIndex = 1;
            this.btt_Close.Text = "Fechar aplicação";
            this.btt_Close.UseVisualStyleBackColor = false;
            this.btt_Close.Click += new System.EventHandler(this.btt_Close_Click);
            // 
            // btt_ModificaLabel
            // 
            this.btt_ModificaLabel.BackColor = System.Drawing.Color.Red;
            this.btt_ModificaLabel.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btt_ModificaLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.btt_ModificaLabel.Location = new System.Drawing.Point(16, 81);
            this.btt_ModificaLabel.Name = "btt_ModificaLabel";
            this.btt_ModificaLabel.Size = new System.Drawing.Size(772, 357);
            this.btt_ModificaLabel.TabIndex = 2;
            this.btt_ModificaLabel.Text = "Modifica texto da label";
            this.btt_ModificaLabel.UseVisualStyleBackColor = false;
            this.btt_ModificaLabel.Click += new System.EventHandler(this.btt_ModificaLabel_Click);
            // 
            // txtConteudoLabel
            // 
            this.txtConteudoLabel.Location = new System.Drawing.Point(16, 55);
            this.txtConteudoLabel.Name = "txtConteudoLabel";
            this.txtConteudoLabel.Size = new System.Drawing.Size(772, 20);
            this.txtConteudoLabel.TabIndex = 3;
            this.txtConteudoLabel.TextChanged += new System.EventHandler(this.txtConteudoLabel_TextChanged);
            // 
            // frm_HelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtConteudoLabel);
            this.Controls.Add(this.btt_ModificaLabel);
            this.Controls.Add(this.btt_Close);
            this.Controls.Add(this.lbl_Titulo);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "frm_HelloWorld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_HelloWorld_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btt_Close;
        private System.Windows.Forms.Button btt_ModificaLabel;
        private System.Windows.Forms.TextBox txtConteudoLabel;
    }
}