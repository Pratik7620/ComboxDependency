
namespace DependentCombobox
{
    partial class Form1
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
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_State = new System.Windows.Forms.Label();
            this.lbl_District = new System.Windows.Forms.Label();
            this.lbl_Taluka = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.cmb_State = new System.Windows.Forms.ComboBox();
            this.cmb_District = new System.Windows.Forms.ComboBox();
            this.cmb_Taluka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Submit
            // 
            this.btn_Submit.Font = new System.Drawing.Font("Modern No. 20", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btn_Submit.Location = new System.Drawing.Point(363, 546);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(151, 44);
            this.btn_Submit.TabIndex = 0;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Practice Demo";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Name.Location = new System.Drawing.Point(160, 92);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(82, 29);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_State
            // 
            this.lbl_State.AutoSize = true;
            this.lbl_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_State.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_State.Location = new System.Drawing.Point(160, 211);
            this.lbl_State.Name = "lbl_State";
            this.lbl_State.Size = new System.Drawing.Size(73, 29);
            this.lbl_State.TabIndex = 3;
            this.lbl_State.Text = "State";
            // 
            // lbl_District
            // 
            this.lbl_District.AutoSize = true;
            this.lbl_District.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_District.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_District.Location = new System.Drawing.Point(160, 323);
            this.lbl_District.Name = "lbl_District";
            this.lbl_District.Size = new System.Drawing.Size(94, 29);
            this.lbl_District.TabIndex = 4;
            this.lbl_District.Text = "District";
            // 
            // lbl_Taluka
            // 
            this.lbl_Taluka.AutoSize = true;
            this.lbl_Taluka.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Taluka.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Taluka.Location = new System.Drawing.Point(160, 432);
            this.lbl_Taluka.Name = "lbl_Taluka";
            this.lbl_Taluka.Size = new System.Drawing.Size(92, 29);
            this.lbl_Taluka.TabIndex = 5;
            this.lbl_Taluka.Text = "Taluka";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(565, 91);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(257, 30);
            this.tb_Name.TabIndex = 6;
            // 
            // cmb_State
            // 
            this.cmb_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_State.FormattingEnabled = true;
            this.cmb_State.Location = new System.Drawing.Point(565, 207);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.Size = new System.Drawing.Size(257, 33);
            this.cmb_State.TabIndex = 10;
            this.cmb_State.SelectedIndexChanged += new System.EventHandler(this.cmb_State_SelectedIndexChanged);
            // 
            // cmb_District
            // 
            this.cmb_District.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_District.FormattingEnabled = true;
            this.cmb_District.Location = new System.Drawing.Point(565, 319);
            this.cmb_District.Name = "cmb_District";
            this.cmb_District.Size = new System.Drawing.Size(257, 33);
            this.cmb_District.TabIndex = 11;
            this.cmb_District.SelectedIndexChanged += new System.EventHandler(this.cmb_District_SelectedIndexChanged);
            // 
            // cmb_Taluka
            // 
            this.cmb_Taluka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Taluka.FormattingEnabled = true;
            this.cmb_Taluka.Location = new System.Drawing.Point(565, 428);
            this.cmb_Taluka.Name = "cmb_Taluka";
            this.cmb_Taluka.Size = new System.Drawing.Size(257, 33);
            this.cmb_Taluka.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 655);
            this.Controls.Add(this.cmb_Taluka);
            this.Controls.Add(this.cmb_District);
            this.Controls.Add(this.cmb_State);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Taluka);
            this.Controls.Add(this.lbl_District);
            this.Controls.Add(this.lbl_State);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_State;
        private System.Windows.Forms.Label lbl_District;
        private System.Windows.Forms.Label lbl_Taluka;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.ComboBox cmb_State;
        private System.Windows.Forms.ComboBox cmb_District;
        private System.Windows.Forms.ComboBox cmb_Taluka;
    }
}

