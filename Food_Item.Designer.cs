namespace FoodHub_System
{
    partial class Food_Item
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
            this.Item_NumbertextBox = new System.Windows.Forms.TextBox();
            this.DashboardBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.Food_ItemdataGridView = new System.Windows.Forms.DataGridView();
            this.PricetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Item_NametextBox = new System.Windows.Forms.TextBox();
            this.Item_CategorytextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Food_ItemdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Item_NumbertextBox
            // 
            this.Item_NumbertextBox.Location = new System.Drawing.Point(218, 262);
            this.Item_NumbertextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Item_NumbertextBox.Name = "Item_NumbertextBox";
            this.Item_NumbertextBox.ReadOnly = true;
            this.Item_NumbertextBox.Size = new System.Drawing.Size(298, 26);
            this.Item_NumbertextBox.TabIndex = 140;
            // 
            // DashboardBtn
            // 
            this.DashboardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardBtn.Location = new System.Drawing.Point(573, 602);
            this.DashboardBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DashboardBtn.Name = "DashboardBtn";
            this.DashboardBtn.Size = new System.Drawing.Size(159, 55);
            this.DashboardBtn.TabIndex = 139;
            this.DashboardBtn.Text = "Dashboard";
            this.DashboardBtn.UseVisualStyleBackColor = true;
            this.DashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(573, 510);
            this.ClearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(159, 55);
            this.ClearBtn.TabIndex = 138;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(573, 412);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(159, 55);
            this.DeleteBtn.TabIndex = 137;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(573, 312);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(159, 55);
            this.UpdateBtn.TabIndex = 136;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(573, 216);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(159, 55);
            this.SaveBtn.TabIndex = 135;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(763, 9);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(43, 46);
            this.closeBtn.TabIndex = 134;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Food_ItemdataGridView
            // 
            this.Food_ItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Food_ItemdataGridView.Location = new System.Drawing.Point(40, 688);
            this.Food_ItemdataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Food_ItemdataGridView.Name = "Food_ItemdataGridView";
            this.Food_ItemdataGridView.RowHeadersWidth = 51;
            this.Food_ItemdataGridView.RowTemplate.Height = 24;
            this.Food_ItemdataGridView.Size = new System.Drawing.Size(691, 212);
            this.Food_ItemdataGridView.TabIndex = 133;
            // 
            // PricetextBox
            // 
            this.PricetextBox.Location = new System.Drawing.Point(218, 545);
            this.PricetextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PricetextBox.Name = "PricetextBox";
            this.PricetextBox.Size = new System.Drawing.Size(298, 26);
            this.PricetextBox.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 546);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 26);
            this.label5.TabIndex = 126;
            this.label5.Text = "Price";
            // 
            // Item_NametextBox
            // 
            this.Item_NametextBox.Location = new System.Drawing.Point(218, 348);
            this.Item_NametextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Item_NametextBox.Name = "Item_NametextBox";
            this.Item_NametextBox.Size = new System.Drawing.Size(298, 26);
            this.Item_NametextBox.TabIndex = 131;
            // 
            // Item_CategorytextBox
            // 
            this.Item_CategorytextBox.Location = new System.Drawing.Point(218, 439);
            this.Item_CategorytextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Item_CategorytextBox.Name = "Item_CategorytextBox";
            this.Item_CategorytextBox.Size = new System.Drawing.Size(298, 26);
            this.Item_CategorytextBox.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 127;
            this.label3.Text = "Item_Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 26);
            this.label4.TabIndex = 128;
            this.label4.Text = "Item_Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 129;
            this.label2.Text = "Item_Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 38);
            this.label1.TabIndex = 124;
            this.label1.Text = "Food_Item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodHub_System.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(260, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 141;
            this.pictureBox1.TabStop = false;
            // 
            // Food_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FoodHub_System.Properties.Resources.BG;
            this.ClientSize = new System.Drawing.Size(820, 916);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Item_NumbertextBox);
            this.Controls.Add(this.DashboardBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.Food_ItemdataGridView);
            this.Controls.Add(this.PricetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Item_NametextBox);
            this.Controls.Add(this.Item_CategorytextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Food_Item";
            this.Text = "Food_Item";
            this.Load += new System.EventHandler(this.Food_Item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Food_ItemdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Item_NumbertextBox;
        private System.Windows.Forms.Button DashboardBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.DataGridView Food_ItemdataGridView;
        private System.Windows.Forms.TextBox PricetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Item_NametextBox;
        private System.Windows.Forms.TextBox Item_CategorytextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}