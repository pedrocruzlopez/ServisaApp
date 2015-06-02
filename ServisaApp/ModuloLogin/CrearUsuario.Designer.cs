namespace ServisaApp
{
    partial class CrearUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usuarioBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.confpassText = new System.Windows.Forms.TextBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar contraseña:";
            // 
            // usuarioBox
            // 
            this.usuarioBox.Location = new System.Drawing.Point(141, 62);
            this.usuarioBox.Name = "usuarioBox";
            this.usuarioBox.Size = new System.Drawing.Size(291, 20);
            this.usuarioBox.TabIndex = 4;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(141, 134);
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.Size = new System.Drawing.Size(291, 20);
            this.passBox.TabIndex = 5;
            // 
            // confpassText
            // 
            this.confpassText.Location = new System.Drawing.Point(141, 176);
            this.confpassText.Name = "confpassText";
            this.confpassText.PasswordChar = '*';
            this.confpassText.Size = new System.Drawing.Size(291, 20);
            this.confpassText.TabIndex = 6;
            // 
            // rolComboBox
            // 
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "administrador",
            "operador"});
            this.rolComboBox.Location = new System.Drawing.Point(141, 98);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(291, 21);
            this.rolComboBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crear Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Crear Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "(Máx. ocho caractéres)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "(Máx. ocho caractéres)";
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 273);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.confpassText);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usuarioBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Usuario Nuevo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usuarioBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox confpassText;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}