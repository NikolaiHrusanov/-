namespace Laboratory_of_profesor_Kondenstain
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_Add_Ingreadance = new System.Windows.Forms.Button();
            this.Btn_boil_a_potion = new System.Windows.Forms.Button();
            this.Txb_enter_Ingredients = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(251, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Лаборатория за експерименти";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_result.Location = new System.Drawing.Point(26, 475);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(106, 25);
            this.lbl_result.TabIndex = 9;
            this.lbl_result.Text = "резултат:";
            this.lbl_result.Click += new System.EventHandler(this.label2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(31, 161);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 268);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Btn_Add_Ingreadance
            // 
            this.Btn_Add_Ingreadance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Add_Ingreadance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Add_Ingreadance.Location = new System.Drawing.Point(360, 189);
            this.Btn_Add_Ingreadance.Name = "Btn_Add_Ingreadance";
            this.Btn_Add_Ingreadance.Size = new System.Drawing.Size(212, 71);
            this.Btn_Add_Ingreadance.TabIndex = 11;
            this.Btn_Add_Ingreadance.Text = "Добави съставка";
            this.Btn_Add_Ingreadance.UseVisualStyleBackColor = true;
            this.Btn_Add_Ingreadance.Click += new System.EventHandler(this.Btn_Add_Ingreadance_Click);
            // 
            // Btn_boil_a_potion
            // 
            this.Btn_boil_a_potion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_boil_a_potion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_boil_a_potion.Location = new System.Drawing.Point(360, 327);
            this.Btn_boil_a_potion.Name = "Btn_boil_a_potion";
            this.Btn_boil_a_potion.Size = new System.Drawing.Size(212, 71);
            this.Btn_boil_a_potion.TabIndex = 12;
            this.Btn_boil_a_potion.Text = "Свари отварата!";
            this.Btn_boil_a_potion.UseVisualStyleBackColor = true;
            this.Btn_boil_a_potion.Click += new System.EventHandler(this.Btn_boil_a_potion_Click);
            // 
            // Txb_enter_Ingredients
            // 
            this.Txb_enter_Ingredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Txb_enter_Ingredients.Location = new System.Drawing.Point(31, 102);
            this.Txb_enter_Ingredients.Name = "Txb_enter_Ingredients";
            this.Txb_enter_Ingredients.Size = new System.Drawing.Size(288, 38);
            this.Txb_enter_Ingredients.TabIndex = 13;
            this.Txb_enter_Ingredients.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 536);
            this.Controls.Add(this.Txb_enter_Ingredients);
            this.Controls.Add(this.Btn_boil_a_potion);
            this.Controls.Add(this.Btn_Add_Ingreadance);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лаборатория на Проф. Коденщаин";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_Add_Ingreadance;
        private System.Windows.Forms.Button Btn_boil_a_potion;
        private System.Windows.Forms.TextBox Txb_enter_Ingredients;
    }
}

