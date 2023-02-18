namespace GeneradorDeContrasenia
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtContraseniaGenerada = new System.Windows.Forms.TextBox();
            this.txtLongitudContrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkIncluMayusculas = new System.Windows.Forms.CheckBox();
            this.chkIncluMinusculas = new System.Windows.Forms.CheckBox();
            this.chkIncluNumeros = new System.Windows.Forms.CheckBox();
            this.chkIncluSimbolos = new System.Windows.Forms.CheckBox();
            this.btnGenerarContrasenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(622, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERADOR DE CONTRASEÑA";
            // 
            // txtContraseniaGenerada
            // 
            this.txtContraseniaGenerada.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContraseniaGenerada.Location = new System.Drawing.Point(54, 77);
            this.txtContraseniaGenerada.Multiline = true;
            this.txtContraseniaGenerada.Name = "txtContraseniaGenerada";
            this.txtContraseniaGenerada.Size = new System.Drawing.Size(581, 177);
            this.txtContraseniaGenerada.TabIndex = 1;
            // 
            // txtLongitudContrasenia
            // 
            this.txtLongitudContrasenia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLongitudContrasenia.Location = new System.Drawing.Point(360, 274);
            this.txtLongitudContrasenia.Name = "txtLongitudContrasenia";
            this.txtLongitudContrasenia.Size = new System.Drawing.Size(125, 29);
            this.txtLongitudContrasenia.TabIndex = 2;
            this.txtLongitudContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongitudContrasenia_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(147, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitud de Contraseña";
            // 
            // chkIncluMayusculas
            // 
            this.chkIncluMayusculas.AutoSize = true;
            this.chkIncluMayusculas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIncluMayusculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIncluMayusculas.Location = new System.Drawing.Point(147, 340);
            this.chkIncluMayusculas.Name = "chkIncluMayusculas";
            this.chkIncluMayusculas.Size = new System.Drawing.Size(221, 25);
            this.chkIncluMayusculas.TabIndex = 5;
            this.chkIncluMayusculas.Text = "Incluir Mayúsculas                ";
            this.chkIncluMayusculas.UseVisualStyleBackColor = true;
            // 
            // chkIncluMinusculas
            // 
            this.chkIncluMinusculas.AutoSize = true;
            this.chkIncluMinusculas.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIncluMinusculas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIncluMinusculas.Location = new System.Drawing.Point(147, 383);
            this.chkIncluMinusculas.Name = "chkIncluMinusculas";
            this.chkIncluMinusculas.Size = new System.Drawing.Size(222, 25);
            this.chkIncluMinusculas.TabIndex = 6;
            this.chkIncluMinusculas.Text = "Incluir Minúsculas                 ";
            this.chkIncluMinusculas.UseVisualStyleBackColor = true;
            // 
            // chkIncluNumeros
            // 
            this.chkIncluNumeros.AutoSize = true;
            this.chkIncluNumeros.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIncluNumeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIncluNumeros.Location = new System.Drawing.Point(147, 425);
            this.chkIncluNumeros.Name = "chkIncluNumeros";
            this.chkIncluNumeros.Size = new System.Drawing.Size(221, 25);
            this.chkIncluNumeros.TabIndex = 7;
            this.chkIncluNumeros.Text = "Incluir Números                    ";
            this.chkIncluNumeros.UseVisualStyleBackColor = true;
            // 
            // chkIncluSimbolos
            // 
            this.chkIncluSimbolos.AutoSize = true;
            this.chkIncluSimbolos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIncluSimbolos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkIncluSimbolos.Location = new System.Drawing.Point(151, 469);
            this.chkIncluSimbolos.Name = "chkIncluSimbolos";
            this.chkIncluSimbolos.Size = new System.Drawing.Size(217, 25);
            this.chkIncluSimbolos.TabIndex = 8;
            this.chkIncluSimbolos.Text = "Incluir Simbolos                   ";
            this.chkIncluSimbolos.UseVisualStyleBackColor = true;
            // 
            // btnGenerarContrasenia
            // 
            this.btnGenerarContrasenia.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGenerarContrasenia.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarContrasenia.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerarContrasenia.Location = new System.Drawing.Point(301, 529);
            this.btnGenerarContrasenia.Name = "btnGenerarContrasenia";
            this.btnGenerarContrasenia.Size = new System.Drawing.Size(111, 37);
            this.btnGenerarContrasenia.TabIndex = 9;
            this.btnGenerarContrasenia.Text = "Generar";
            this.btnGenerarContrasenia.UseVisualStyleBackColor = false;
            this.btnGenerarContrasenia.Click += new System.EventHandler(this.btnGenerarContrasenia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(685, 668);
            this.Controls.Add(this.btnGenerarContrasenia);
            this.Controls.Add(this.chkIncluSimbolos);
            this.Controls.Add(this.chkIncluNumeros);
            this.Controls.Add(this.chkIncluMinusculas);
            this.Controls.Add(this.chkIncluMayusculas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLongitudContrasenia);
            this.Controls.Add(this.txtContraseniaGenerada);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Generador de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtContraseniaGenerada;
        private TextBox txtLongitudContrasenia;
        private Label label2;
        private CheckBox chkIncluMayusculas;
        private CheckBox chkIncluMinusculas;
        private CheckBox chkIncluNumeros;
        private CheckBox chkIncluSimbolos;
        private Button btnGenerarContrasenia;
    }
}