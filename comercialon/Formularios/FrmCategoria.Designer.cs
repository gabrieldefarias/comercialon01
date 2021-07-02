namespace comercialon.Formularios
{
    partial class FrmCategoria
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEditarAlterar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSiglaCategoria = new System.Windows.Forms.TextBox();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.txtIdCategoria = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.btnEditarAlterar);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.txtSiglaCategoria);
            this.groupBox4.Controls.Add(this.txtNomeCategoria);
            this.groupBox4.Controls.Add(this.txtIdCategoria);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 153);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Categoria";
            // 
            // btnEditarAlterar
            // 
            this.btnEditarAlterar.Location = new System.Drawing.Point(106, 115);
            this.btnEditarAlterar.Name = "btnEditarAlterar";
            this.btnEditarAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAlterar.TabIndex = 8;
            this.btnEditarAlterar.Text = "Editar";
            this.btnEditarAlterar.UseVisualStyleBackColor = true;
            this.btnEditarAlterar.Click += new System.EventHandler(this.btnEditarAlterar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Inserir categoria";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSiglaCategoria
            // 
            this.txtSiglaCategoria.Location = new System.Drawing.Point(115, 89);
            this.txtSiglaCategoria.Name = "txtSiglaCategoria";
            this.txtSiglaCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtSiglaCategoria.TabIndex = 5;
            this.txtSiglaCategoria.TextChanged += new System.EventHandler(this.txtSiglaCategoria_TextChanged);
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Location = new System.Drawing.Point(9, 89);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(100, 20);
            this.txtNomeCategoria.TabIndex = 4;
            this.txtNomeCategoria.TextChanged += new System.EventHandler(this.txtNomeCategoria_TextChanged);
            // 
            // txtIdCategoria
            // 
            this.txtIdCategoria.Location = new System.Drawing.Point(9, 38);
            this.txtIdCategoria.Name = "txtIdCategoria";
            this.txtIdCategoria.ReadOnly = true;
            this.txtIdCategoria.Size = new System.Drawing.Size(76, 20);
            this.txtIdCategoria.TabIndex = 3;
            this.txtIdCategoria.TextChanged += new System.EventHandler(this.txtIdCategoria_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(112, 73);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Sigla:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(38, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "Nome:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "ID:";
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 175);
            this.Controls.Add(this.groupBox4);
            this.Name = "FrmCategoria";
            this.Text = "Formulario Categoria";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSiglaCategoria;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditarAlterar;
    }
}