namespace Consorcios
{
    partial class frmAgregarUF
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtPiso = new System.Windows.Forms.TextBox();
            this.txtOcup = new System.Windows.Forms.TextBox();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.rdbExpB = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbConsorcios = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Controls.Add(this.txtPiso);
            this.groupBox1.Controls.Add(this.txtOcup);
            this.groupBox1.Controls.Add(this.txtProp);
            this.groupBox1.Controls.Add(this.txtAlias);
            this.groupBox1.Controls.Add(this.rdbExpB);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la unidad";
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(203, 150);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(43, 20);
            this.txtUnidad.TabIndex = 16;
            // 
            // txtPiso
            // 
            this.txtPiso.Location = new System.Drawing.Point(92, 150);
            this.txtPiso.Name = "txtPiso";
            this.txtPiso.Size = new System.Drawing.Size(26, 20);
            this.txtPiso.TabIndex = 15;
            // 
            // txtOcup
            // 
            this.txtOcup.Location = new System.Drawing.Point(146, 111);
            this.txtOcup.Name = "txtOcup";
            this.txtOcup.Size = new System.Drawing.Size(125, 20);
            this.txtOcup.TabIndex = 14;
            // 
            // txtProp
            // 
            this.txtProp.Location = new System.Drawing.Point(146, 68);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(125, 20);
            this.txtProp.TabIndex = 13;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(146, 33);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(125, 20);
            this.txtAlias.TabIndex = 12;
            // 
            // rdbExpB
            // 
            this.rdbExpB.AutoSize = true;
            this.rdbExpB.Location = new System.Drawing.Point(37, 204);
            this.rdbExpB.Name = "rdbExpB";
            this.rdbExpB.Size = new System.Drawing.Size(81, 17);
            this.rdbExpB.TabIndex = 11;
            this.rdbExpB.TabStop = true;
            this.rdbExpB.Text = "Expensas B";
            this.rdbExpB.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(162, 240);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 26);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Piso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ocupante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propietario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alias:";
            // 
            // cmbConsorcios
            // 
            this.cmbConsorcios.FormattingEnabled = true;
            this.cmbConsorcios.Location = new System.Drawing.Point(188, 31);
            this.cmbConsorcios.Name = "cmbConsorcios";
            this.cmbConsorcios.Size = new System.Drawing.Size(121, 21);
            this.cmbConsorcios.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Consorcio:";
            // 
            // frmAgregarUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 360);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbConsorcios);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAgregarUF";
            this.Text = "Agregar nueva Unidad Funcional";
            this.Load += new System.EventHandler(this.frmAgregarUF_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtPiso;
        private System.Windows.Forms.TextBox txtOcup;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.RadioButton rdbExpB;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbConsorcios;
        private System.Windows.Forms.Label label6;
    }
}