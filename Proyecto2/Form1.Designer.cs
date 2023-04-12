namespace Proyecto2
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
            panel_container = new Panel();
            panel_der = new Panel();
            label2 = new Label();
            txt_output = new TextBox();
            panel_izq = new Panel();
            button1 = new Button();
            txt_input = new TextBox();
            label1 = new Label();
            panel_container.SuspendLayout();
            panel_der.SuspendLayout();
            panel_izq.SuspendLayout();
            SuspendLayout();
            // 
            // panel_container
            // 
            panel_container.Controls.Add(panel_der);
            panel_container.Controls.Add(panel_izq);
            panel_container.Dock = DockStyle.Fill;
            panel_container.Location = new Point(0, 0);
            panel_container.Name = "panel_container";
            panel_container.Size = new Size(901, 492);
            panel_container.TabIndex = 0;
            // 
            // panel_der
            // 
            panel_der.BackColor = Color.FromArgb(253, 253, 253);
            panel_der.Controls.Add(label2);
            panel_der.Controls.Add(txt_output);
            panel_der.Dock = DockStyle.Fill;
            panel_der.Location = new Point(452, 0);
            panel_der.Name = "panel_der";
            panel_der.Size = new Size(449, 492);
            panel_der.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(10, 30, 81);
            label2.Location = new Point(85, 65);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 1;
            label2.Text = "Resultado";
            // 
            // txt_output
            // 
            txt_output.BorderStyle = BorderStyle.FixedSingle;
            txt_output.Location = new Point(85, 93);
            txt_output.Multiline = true;
            txt_output.Name = "txt_output";
            txt_output.Size = new Size(312, 320);
            txt_output.TabIndex = 0;
            // 
            // panel_izq
            // 
            panel_izq.BackColor = Color.FromArgb(10, 30, 81);
            panel_izq.Controls.Add(button1);
            panel_izq.Controls.Add(txt_input);
            panel_izq.Controls.Add(label1);
            panel_izq.Dock = DockStyle.Left;
            panel_izq.Location = new Point(0, 0);
            panel_izq.Name = "panel_izq";
            panel_izq.Size = new Size(452, 492);
            panel_izq.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(83, 111, 227);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(10, 30, 81);
            button1.Location = new Point(125, 372);
            button1.Name = "button1";
            button1.Size = new Size(213, 41);
            button1.TabIndex = 2;
            button1.Text = "Analizar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // txt_input
            // 
            txt_input.BackColor = Color.FromArgb(216, 223, 248);
            txt_input.BorderStyle = BorderStyle.FixedSingle;
            txt_input.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_input.Location = new Point(56, 151);
            txt_input.Multiline = true;
            txt_input.Name = "txt_input";
            txt_input.Size = new Size(341, 199);
            txt_input.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(216, 223, 248);
            label1.Location = new Point(147, 65);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingrese una Cadena";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 36, 57);
            ClientSize = new Size(901, 492);
            Controls.Add(panel_container);
            Name = "Form1";
            Text = "Form1";
            panel_container.ResumeLayout(false);
            panel_der.ResumeLayout(false);
            panel_der.PerformLayout();
            panel_izq.ResumeLayout(false);
            panel_izq.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_container;
        private Panel panel_izq;
        private Panel panel_der;
        private Button button1;
        private TextBox txt_input;
        private Label label1;
        private TextBox txt_output;
        private Label label2;
    }
}