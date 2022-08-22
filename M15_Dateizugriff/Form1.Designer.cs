namespace Dateizugriff
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
            this.Tbx_Input = new System.Windows.Forms.TextBox();
            this.Btn_Speichern = new System.Windows.Forms.Button();
            this.Btn_Laden = new System.Windows.Forms.Button();
            this.Btn_Serialisiere = new System.Windows.Forms.Button();
            this.Btn_Deserialisiere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tbx_Input
            // 
            this.Tbx_Input.Location = new System.Drawing.Point(36, 21);
            this.Tbx_Input.Multiline = true;
            this.Tbx_Input.Name = "Tbx_Input";
            this.Tbx_Input.Size = new System.Drawing.Size(309, 365);
            this.Tbx_Input.TabIndex = 0;
            // 
            // Btn_Speichern
            // 
            this.Btn_Speichern.Location = new System.Drawing.Point(360, 21);
            this.Btn_Speichern.Name = "Btn_Speichern";
            this.Btn_Speichern.Size = new System.Drawing.Size(150, 46);
            this.Btn_Speichern.TabIndex = 1;
            this.Btn_Speichern.Text = "Speichern";
            this.Btn_Speichern.UseVisualStyleBackColor = true;
            this.Btn_Speichern.Click += new System.EventHandler(this.Btn_Speichern_Click);
            // 
            // Btn_Laden
            // 
            this.Btn_Laden.Location = new System.Drawing.Point(360, 73);
            this.Btn_Laden.Name = "Btn_Laden";
            this.Btn_Laden.Size = new System.Drawing.Size(150, 46);
            this.Btn_Laden.TabIndex = 2;
            this.Btn_Laden.Text = "Laden";
            this.Btn_Laden.UseVisualStyleBackColor = true;
            this.Btn_Laden.Click += new System.EventHandler(this.Btn_Laden_Click);
            // 
            // Btn_Serialisiere
            // 
            this.Btn_Serialisiere.Location = new System.Drawing.Point(452, 185);
            this.Btn_Serialisiere.Name = "Btn_Serialisiere";
            this.Btn_Serialisiere.Size = new System.Drawing.Size(212, 46);
            this.Btn_Serialisiere.TabIndex = 3;
            this.Btn_Serialisiere.Text = "Serialisiere";
            this.Btn_Serialisiere.UseVisualStyleBackColor = true;
            this.Btn_Serialisiere.Click += new System.EventHandler(this.Btn_Serialisiere_Click);
            // 
            // Btn_Deserialisiere
            // 
            this.Btn_Deserialisiere.Location = new System.Drawing.Point(452, 237);
            this.Btn_Deserialisiere.Name = "Btn_Deserialisiere";
            this.Btn_Deserialisiere.Size = new System.Drawing.Size(212, 46);
            this.Btn_Deserialisiere.TabIndex = 4;
            this.Btn_Deserialisiere.Text = "Deserialisiere";
            this.Btn_Deserialisiere.UseVisualStyleBackColor = true;
            this.Btn_Deserialisiere.Click += new System.EventHandler(this.Btn_Deserialisiere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Deserialisiere);
            this.Controls.Add(this.Btn_Serialisiere);
            this.Controls.Add(this.Btn_Laden);
            this.Controls.Add(this.Btn_Speichern);
            this.Controls.Add(this.Tbx_Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Tbx_Input;
        private Button Btn_Speichern;
        private Button Btn_Laden;
        private Button Btn_Serialisiere;
        private Button Btn_Deserialisiere;
    }
}