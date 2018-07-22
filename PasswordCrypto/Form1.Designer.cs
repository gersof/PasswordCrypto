namespace PasswordCrypto
{
    partial class PasswordCryptoForm
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
            this.encriptarBtn = new System.Windows.Forms.Button();
            this.txtPasswordSEIn = new System.Windows.Forms.TextBox();
            this.txtPasswordCEOut = new System.Windows.Forms.TextBox();
            this.txtPasswordCEIn = new System.Windows.Forms.TextBox();
            this.DesencriptarBtn = new System.Windows.Forms.Button();
            this.txtPasswordSEOut = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.notificacionLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // encriptarBtn
            // 
            this.encriptarBtn.Location = new System.Drawing.Point(260, 34);
            this.encriptarBtn.Name = "encriptarBtn";
            this.encriptarBtn.Size = new System.Drawing.Size(91, 23);
            this.encriptarBtn.TabIndex = 0;
            this.encriptarBtn.Text = "Encriptar >>";
            this.encriptarBtn.UseVisualStyleBackColor = true;
            this.encriptarBtn.Click += new System.EventHandler(this.encriptarBtn_Click);
            // 
            // txtPasswordSEIn
            // 
            this.txtPasswordSEIn.Location = new System.Drawing.Point(22, 37);
            this.txtPasswordSEIn.Name = "txtPasswordSEIn";
            this.txtPasswordSEIn.Size = new System.Drawing.Size(217, 20);
            this.txtPasswordSEIn.TabIndex = 1;
            // 
            // txtPasswordCEOut
            // 
            this.txtPasswordCEOut.Location = new System.Drawing.Point(371, 34);
            this.txtPasswordCEOut.Name = "txtPasswordCEOut";
            this.txtPasswordCEOut.Size = new System.Drawing.Size(217, 20);
            this.txtPasswordCEOut.TabIndex = 2;
            // 
            // txtPasswordCEIn
            // 
            this.txtPasswordCEIn.Location = new System.Drawing.Point(22, 90);
            this.txtPasswordCEIn.Name = "txtPasswordCEIn";
            this.txtPasswordCEIn.Size = new System.Drawing.Size(217, 20);
            this.txtPasswordCEIn.TabIndex = 3;
            // 
            // DesencriptarBtn
            // 
            this.DesencriptarBtn.Location = new System.Drawing.Point(260, 88);
            this.DesencriptarBtn.Name = "DesencriptarBtn";
            this.DesencriptarBtn.Size = new System.Drawing.Size(91, 23);
            this.DesencriptarBtn.TabIndex = 4;
            this.DesencriptarBtn.Text = "Desencriptar >>";
            this.DesencriptarBtn.UseVisualStyleBackColor = true;
            this.DesencriptarBtn.Click += new System.EventHandler(this.DesencriptarBtn_Click);
            // 
            // txtPasswordSEOut
            // 
            this.txtPasswordSEOut.Location = new System.Drawing.Point(371, 88);
            this.txtPasswordSEOut.Name = "txtPasswordSEOut";
            this.txtPasswordSEOut.Size = new System.Drawing.Size(217, 20);
            this.txtPasswordSEOut.TabIndex = 5;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(260, 140);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(91, 23);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Limpiar";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // notificacionLbl
            // 
            this.notificacionLbl.AutoSize = true;
            this.notificacionLbl.Location = new System.Drawing.Point(386, 145);
            this.notificacionLbl.Name = "notificacionLbl";
            this.notificacionLbl.Size = new System.Drawing.Size(0, 13);
            this.notificacionLbl.TabIndex = 7;
            this.notificacionLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordCryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 187);
            this.Controls.Add(this.notificacionLbl);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.txtPasswordSEOut);
            this.Controls.Add(this.DesencriptarBtn);
            this.Controls.Add(this.txtPasswordCEIn);
            this.Controls.Add(this.txtPasswordCEOut);
            this.Controls.Add(this.txtPasswordSEIn);
            this.Controls.Add(this.encriptarBtn);
            this.Name = "PasswordCryptoForm";
            this.Text = "PasswordCrypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encriptarBtn;
        private System.Windows.Forms.TextBox txtPasswordSEIn;
        private System.Windows.Forms.TextBox txtPasswordCEOut;
        private System.Windows.Forms.TextBox txtPasswordCEIn;
        private System.Windows.Forms.Button DesencriptarBtn;
        private System.Windows.Forms.TextBox txtPasswordSEOut;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label notificacionLbl;
    }
}

