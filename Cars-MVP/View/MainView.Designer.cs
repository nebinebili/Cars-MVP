
namespace Cars_MVP.View
{
    partial class MainView
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
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_brand = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox_color = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox_model = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBox_year = new Guna.UI2.WinForms.Guna2ComboBox();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.btn_AddCar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_LoadCar = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_transmission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_deleteCar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Transmission";
            // 
            // comboBox_brand
            // 
            this.comboBox_brand.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_brand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_brand.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_brand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_brand.FocusedState.Parent = this.comboBox_brand;
            this.comboBox_brand.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBox_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_brand.HoverState.Parent = this.comboBox_brand;
            this.comboBox_brand.IntegralHeight = false;
            this.comboBox_brand.ItemHeight = 30;
            this.comboBox_brand.ItemsAppearance.Parent = this.comboBox_brand;
            this.comboBox_brand.Location = new System.Drawing.Point(221, 46);
            this.comboBox_brand.Name = "comboBox_brand";
            this.comboBox_brand.ShadowDecoration.Parent = this.comboBox_brand;
            this.comboBox_brand.Size = new System.Drawing.Size(182, 36);
            this.comboBox_brand.TabIndex = 6;
            this.comboBox_brand.SelectedIndexChanged += new System.EventHandler(this.comboBox_brand_SelectedIndexChanged);
            // 
            // comboBox_color
            // 
            this.comboBox_color.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_color.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_color.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_color.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_color.FocusedState.Parent = this.comboBox_color;
            this.comboBox_color.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBox_color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_color.HoverState.Parent = this.comboBox_color;
            this.comboBox_color.IntegralHeight = false;
            this.comboBox_color.ItemHeight = 30;
            this.comboBox_color.ItemsAppearance.Parent = this.comboBox_color;
            this.comboBox_color.Location = new System.Drawing.Point(221, 192);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.ShadowDecoration.Parent = this.comboBox_color;
            this.comboBox_color.Size = new System.Drawing.Size(182, 36);
            this.comboBox_color.TabIndex = 7;
            // 
            // comboBox_model
            // 
            this.comboBox_model.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_model.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_model.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_model.FocusedState.Parent = this.comboBox_model;
            this.comboBox_model.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBox_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_model.HoverState.Parent = this.comboBox_model;
            this.comboBox_model.IntegralHeight = false;
            this.comboBox_model.ItemHeight = 30;
            this.comboBox_model.Items.AddRange(new object[] {
            "Salam",
            "necesen"});
            this.comboBox_model.ItemsAppearance.Parent = this.comboBox_model;
            this.comboBox_model.Location = new System.Drawing.Point(221, 120);
            this.comboBox_model.Name = "comboBox_model";
            this.comboBox_model.ShadowDecoration.Parent = this.comboBox_model;
            this.comboBox_model.Size = new System.Drawing.Size(182, 36);
            this.comboBox_model.TabIndex = 8;
            // 
            // comboBox_year
            // 
            this.comboBox_year.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_year.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_year.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_year.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_year.FocusedState.Parent = this.comboBox_year;
            this.comboBox_year.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBox_year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_year.HoverState.Parent = this.comboBox_year;
            this.comboBox_year.IntegralHeight = false;
            this.comboBox_year.ItemHeight = 30;
            this.comboBox_year.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.comboBox_year.ItemsAppearance.Parent = this.comboBox_year;
            this.comboBox_year.Location = new System.Drawing.Point(221, 263);
            this.comboBox_year.Name = "comboBox_year";
            this.comboBox_year.ShadowDecoration.Parent = this.comboBox_year;
            this.comboBox_year.Size = new System.Drawing.Size(182, 36);
            this.comboBox_year.StartIndex = 0;
            this.comboBox_year.TabIndex = 9;
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.Location = new System.Drawing.Point(553, 46);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(254, 355);
            this.listBoxCar.TabIndex = 12;
            // 
            // btn_AddCar
            // 
            this.btn_AddCar.Animated = true;
            this.btn_AddCar.AutoRoundedCorners = true;
            this.btn_AddCar.BorderRadius = 19;
            this.btn_AddCar.CheckedState.Parent = this.btn_AddCar;
            this.btn_AddCar.CustomImages.Parent = this.btn_AddCar;
            this.btn_AddCar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddCar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AddCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AddCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AddCar.DisabledState.Parent = this.btn_AddCar;
            this.btn_AddCar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btn_AddCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_AddCar.ForeColor = System.Drawing.Color.White;
            this.btn_AddCar.HoverState.Parent = this.btn_AddCar;
            this.btn_AddCar.Location = new System.Drawing.Point(352, 392);
            this.btn_AddCar.Name = "btn_AddCar";
            this.btn_AddCar.ShadowDecoration.Parent = this.btn_AddCar;
            this.btn_AddCar.Size = new System.Drawing.Size(128, 40);
            this.btn_AddCar.TabIndex = 13;
            this.btn_AddCar.Text = "Add Car";
            this.btn_AddCar.Click += new System.EventHandler(this.btn_AddCar_Click);
            // 
            // btn_LoadCar
            // 
            this.btn_LoadCar.Animated = true;
            this.btn_LoadCar.AutoRoundedCorners = true;
            this.btn_LoadCar.BorderRadius = 19;
            this.btn_LoadCar.CheckedState.Parent = this.btn_LoadCar;
            this.btn_LoadCar.CustomImages.Parent = this.btn_LoadCar;
            this.btn_LoadCar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_LoadCar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_LoadCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_LoadCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_LoadCar.DisabledState.Parent = this.btn_LoadCar;
            this.btn_LoadCar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btn_LoadCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LoadCar.ForeColor = System.Drawing.Color.White;
            this.btn_LoadCar.HoverState.Parent = this.btn_LoadCar;
            this.btn_LoadCar.Location = new System.Drawing.Point(690, 407);
            this.btn_LoadCar.Name = "btn_LoadCar";
            this.btn_LoadCar.ShadowDecoration.Parent = this.btn_LoadCar;
            this.btn_LoadCar.Size = new System.Drawing.Size(117, 40);
            this.btn_LoadCar.TabIndex = 14;
            this.btn_LoadCar.Text = "Load Car";
            this.btn_LoadCar.Click += new System.EventHandler(this.btn_LoadCar_Click);
            // 
            // comboBox_transmission
            // 
            this.comboBox_transmission.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_transmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_transmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_transmission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_transmission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox_transmission.FocusedState.Parent = this.comboBox_transmission;
            this.comboBox_transmission.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboBox_transmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_transmission.HoverState.Parent = this.comboBox_transmission;
            this.comboBox_transmission.IntegralHeight = false;
            this.comboBox_transmission.ItemHeight = 30;
            this.comboBox_transmission.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021"});
            this.comboBox_transmission.ItemsAppearance.Parent = this.comboBox_transmission;
            this.comboBox_transmission.Location = new System.Drawing.Point(221, 321);
            this.comboBox_transmission.Name = "comboBox_transmission";
            this.comboBox_transmission.ShadowDecoration.Parent = this.comboBox_transmission;
            this.comboBox_transmission.Size = new System.Drawing.Size(182, 36);
            this.comboBox_transmission.TabIndex = 15;
            // 
            // btn_deleteCar
            // 
            this.btn_deleteCar.Animated = true;
            this.btn_deleteCar.AutoRoundedCorners = true;
            this.btn_deleteCar.BorderRadius = 19;
            this.btn_deleteCar.CheckedState.Parent = this.btn_deleteCar;
            this.btn_deleteCar.CustomImages.Parent = this.btn_deleteCar;
            this.btn_deleteCar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteCar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deleteCar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deleteCar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deleteCar.DisabledState.Parent = this.btn_deleteCar;
            this.btn_deleteCar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(54)))), ((int)(((byte)(67)))));
            this.btn_deleteCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_deleteCar.ForeColor = System.Drawing.Color.White;
            this.btn_deleteCar.HoverState.Parent = this.btn_deleteCar;
            this.btn_deleteCar.Location = new System.Drawing.Point(553, 407);
            this.btn_deleteCar.Name = "btn_deleteCar";
            this.btn_deleteCar.ShadowDecoration.Parent = this.btn_deleteCar;
            this.btn_deleteCar.Size = new System.Drawing.Size(117, 40);
            this.btn_deleteCar.TabIndex = 16;
            this.btn_deleteCar.Text = "Delete Car";
            this.btn_deleteCar.Click += new System.EventHandler(this.btn_deleteCar_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 471);
            this.Controls.Add(this.btn_deleteCar);
            this.Controls.Add(this.comboBox_transmission);
            this.Controls.Add(this.btn_LoadCar);
            this.Controls.Add(this.btn_AddCar);
            this.Controls.Add(this.listBoxCar);
            this.Controls.Add(this.comboBox_year);
            this.Controls.Add(this.comboBox_model);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.comboBox_brand);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_brand;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_color;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_model;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_year;
        private System.Windows.Forms.ListBox listBoxCar;
        private Guna.UI2.WinForms.Guna2Button btn_AddCar;
        private Guna.UI2.WinForms.Guna2Button btn_LoadCar;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_transmission;
        private Guna.UI2.WinForms.Guna2Button btn_deleteCar;
    }
}