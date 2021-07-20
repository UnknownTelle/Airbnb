namespace Airbnb
{
    partial class AirBnb
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
            this.lstDistrict = new System.Windows.Forms.ListBox();
            this.lstNeighbourhood = new System.Windows.Forms.ListBox();
            this.lstProperty = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Neighbourhood = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddD = new System.Windows.Forms.Button();
            this.btnClearD = new System.Windows.Forms.Button();
            this.txtNNunber = new System.Windows.Forms.TextBox();
            this.txtDisNmae = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bntClearN = new System.Windows.Forms.Button();
            this.bntAddN = new System.Windows.Forms.Button();
            this.txtPNumber = new System.Windows.Forms.TextBox();
            this.txtNName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bntEditN = new System.Windows.Forms.Button();
            this.bntClearP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.txtN360 = new System.Windows.Forms.TextBox();
            this.txtMinNN = new System.Windows.Forms.TextBox();
            this.txtRPrice = new System.Windows.Forms.TextBox();
            this.txtRType = new System.Windows.Forms.TextBox();
            this.txtLong = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtNOP = new System.Windows.Forms.TextBox();
            this.txtHName = new System.Windows.Forms.TextBox();
            this.txtHID = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntEditD = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Neighbourhood.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDistrict
            // 
            this.lstDistrict.FormattingEnabled = true;
            this.lstDistrict.ItemHeight = 20;
            this.lstDistrict.Location = new System.Drawing.Point(7, 36);
            this.lstDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.lstDistrict.Name = "lstDistrict";
            this.lstDistrict.Size = new System.Drawing.Size(455, 84);
            this.lstDistrict.TabIndex = 0;
            this.lstDistrict.SelectedIndexChanged += new System.EventHandler(this.lstDistrict_SelectedIndexChanged);
            // 
            // lstNeighbourhood
            // 
            this.lstNeighbourhood.FormattingEnabled = true;
            this.lstNeighbourhood.ItemHeight = 20;
            this.lstNeighbourhood.Location = new System.Drawing.Point(7, 38);
            this.lstNeighbourhood.Margin = new System.Windows.Forms.Padding(4);
            this.lstNeighbourhood.Name = "lstNeighbourhood";
            this.lstNeighbourhood.Size = new System.Drawing.Size(455, 104);
            this.lstNeighbourhood.TabIndex = 1;
            this.lstNeighbourhood.SelectedIndexChanged += new System.EventHandler(this.lstNeighbourhood_SelectedIndexChanged);
            // 
            // lstProperty
            // 
            this.lstProperty.FormattingEnabled = true;
            this.lstProperty.ItemHeight = 20;
            this.lstProperty.Location = new System.Drawing.Point(7, 38);
            this.lstProperty.Name = "lstProperty";
            this.lstProperty.Size = new System.Drawing.Size(455, 404);
            this.lstProperty.TabIndex = 2;
            this.lstProperty.SelectedIndexChanged += new System.EventHandler(this.lstProperty_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDistrict);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 131);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "District";
            // 
            // Neighbourhood
            // 
            this.Neighbourhood.Controls.Add(this.lstNeighbourhood);
            this.Neighbourhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neighbourhood.Location = new System.Drawing.Point(26, 168);
            this.Neighbourhood.Name = "Neighbourhood";
            this.Neighbourhood.Size = new System.Drawing.Size(493, 149);
            this.Neighbourhood.TabIndex = 4;
            this.Neighbourhood.TabStop = false;
            this.Neighbourhood.Text = "Neighbourhood";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstProperty);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 454);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Property";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntEditD);
            this.groupBox2.Controls.Add(this.btnAddD);
            this.groupBox2.Controls.Add(this.btnClearD);
            this.groupBox2.Controls.Add(this.txtNNunber);
            this.groupBox2.Controls.Add(this.txtDisNmae);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(541, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(669, 131);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "District Details";
            // 
            // btnAddD
            // 
            this.btnAddD.Location = new System.Drawing.Point(475, 16);
            this.btnAddD.Name = "btnAddD";
            this.btnAddD.Size = new System.Drawing.Size(188, 29);
            this.btnAddD.TabIndex = 7;
            this.btnAddD.Text = "Add District";
            this.btnAddD.UseVisualStyleBackColor = true;
            this.btnAddD.Click += new System.EventHandler(this.btnAddD_Click_1);
            // 
            // btnClearD
            // 
            this.btnClearD.Location = new System.Drawing.Point(475, 51);
            this.btnClearD.Name = "btnClearD";
            this.btnClearD.Size = new System.Drawing.Size(188, 29);
            this.btnClearD.TabIndex = 4;
            this.btnClearD.Text = "Clear District";
            this.btnClearD.UseVisualStyleBackColor = true;
            this.btnClearD.Click += new System.EventHandler(this.btnClearD_Click);
            // 
            // txtNNunber
            // 
            this.txtNNunber.Location = new System.Drawing.Point(253, 78);
            this.txtNNunber.Name = "txtNNunber";
            this.txtNNunber.Size = new System.Drawing.Size(163, 26);
            this.txtNNunber.TabIndex = 3;
            // 
            // txtDisNmae
            // 
            this.txtDisNmae.Location = new System.Drawing.Point(253, 36);
            this.txtDisNmae.Name = "txtDisNmae";
            this.txtDisNmae.Size = new System.Drawing.Size(163, 26);
            this.txtDisNmae.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numer of Neighbouthoods:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "District Name:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bntEditN);
            this.groupBox4.Controls.Add(this.bntClearN);
            this.groupBox4.Controls.Add(this.bntAddN);
            this.groupBox4.Controls.Add(this.txtPNumber);
            this.groupBox4.Controls.Add(this.txtNName);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(541, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(669, 148);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Neighbourhood Details";
            // 
            // bntClearN
            // 
            this.bntClearN.Location = new System.Drawing.Point(475, 60);
            this.bntClearN.Name = "bntClearN";
            this.bntClearN.Size = new System.Drawing.Size(188, 29);
            this.bntClearN.TabIndex = 7;
            this.bntClearN.Text = "Clear Neighbourhood";
            this.bntClearN.UseVisualStyleBackColor = true;
            this.bntClearN.Click += new System.EventHandler(this.bntClearN_Click);
            // 
            // bntAddN
            // 
            this.bntAddN.Location = new System.Drawing.Point(475, 25);
            this.bntAddN.Name = "bntAddN";
            this.bntAddN.Size = new System.Drawing.Size(188, 29);
            this.bntAddN.TabIndex = 6;
            this.bntAddN.Text = "Add Neighbourhood";
            this.bntAddN.UseVisualStyleBackColor = true;
            this.bntAddN.Click += new System.EventHandler(this.bntAddN_Click);
            // 
            // txtPNumber
            // 
            this.txtPNumber.Location = new System.Drawing.Point(253, 80);
            this.txtPNumber.Name = "txtPNumber";
            this.txtPNumber.Size = new System.Drawing.Size(163, 26);
            this.txtPNumber.TabIndex = 5;
            // 
            // txtNName
            // 
            this.txtNName.Location = new System.Drawing.Point(253, 38);
            this.txtNName.Name = "txtNName";
            this.txtNName.Size = new System.Drawing.Size(163, 26);
            this.txtNName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Number of Propertys:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Neighbourhood Name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bntClearP);
            this.groupBox5.Controls.Add(this.btnAddP);
            this.groupBox5.Controls.Add(this.txtN360);
            this.groupBox5.Controls.Add(this.txtMinNN);
            this.groupBox5.Controls.Add(this.txtRPrice);
            this.groupBox5.Controls.Add(this.txtRType);
            this.groupBox5.Controls.Add(this.txtLong);
            this.groupBox5.Controls.Add(this.txtLat);
            this.groupBox5.Controls.Add(this.txtNOP);
            this.groupBox5.Controls.Add(this.txtHName);
            this.groupBox5.Controls.Add(this.txtHID);
            this.groupBox5.Controls.Add(this.txtPName);
            this.groupBox5.Controls.Add(this.txtPID);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(541, 332);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(669, 454);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Property Details";
            // 
            // bntEditN
            // 
            this.bntEditN.Location = new System.Drawing.Point(475, 95);
            this.bntEditN.Name = "bntEditN";
            this.bntEditN.Size = new System.Drawing.Size(188, 29);
            this.bntEditN.TabIndex = 22;
            this.bntEditN.Text = "Edit Neighbourhood";
            this.bntEditN.UseVisualStyleBackColor = true;
            this.bntEditN.Click += new System.EventHandler(this.bntEditN_Click);
            // 
            // bntClearP
            // 
            this.bntClearP.Location = new System.Drawing.Point(475, 74);
            this.bntClearP.Name = "bntClearP";
            this.bntClearP.Size = new System.Drawing.Size(188, 29);
            this.bntClearP.TabIndex = 21;
            this.bntClearP.Text = "Clear Property";
            this.bntClearP.UseVisualStyleBackColor = true;
            this.bntClearP.Click += new System.EventHandler(this.bntClearP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.Location = new System.Drawing.Point(475, 34);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(188, 29);
            this.btnAddP.TabIndex = 8;
            this.btnAddP.Text = "Add Property";
            this.btnAddP.UseVisualStyleBackColor = true;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // txtN360
            // 
            this.txtN360.Location = new System.Drawing.Point(253, 411);
            this.txtN360.Name = "txtN360";
            this.txtN360.Size = new System.Drawing.Size(163, 26);
            this.txtN360.TabIndex = 20;
            // 
            // txtMinNN
            // 
            this.txtMinNN.Location = new System.Drawing.Point(253, 372);
            this.txtMinNN.Name = "txtMinNN";
            this.txtMinNN.Size = new System.Drawing.Size(163, 26);
            this.txtMinNN.TabIndex = 19;
            // 
            // txtRPrice
            // 
            this.txtRPrice.Location = new System.Drawing.Point(253, 333);
            this.txtRPrice.Name = "txtRPrice";
            this.txtRPrice.Size = new System.Drawing.Size(163, 26);
            this.txtRPrice.TabIndex = 18;
            // 
            // txtRType
            // 
            this.txtRType.Location = new System.Drawing.Point(171, 295);
            this.txtRType.Name = "txtRType";
            this.txtRType.Size = new System.Drawing.Size(245, 26);
            this.txtRType.TabIndex = 17;
            // 
            // txtLong
            // 
            this.txtLong.Location = new System.Drawing.Point(253, 256);
            this.txtLong.Name = "txtLong";
            this.txtLong.Size = new System.Drawing.Size(163, 26);
            this.txtLong.TabIndex = 16;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(253, 218);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(163, 26);
            this.txtLat.TabIndex = 15;
            // 
            // txtNOP
            // 
            this.txtNOP.Location = new System.Drawing.Point(253, 180);
            this.txtNOP.Name = "txtNOP";
            this.txtNOP.Size = new System.Drawing.Size(163, 26);
            this.txtNOP.TabIndex = 14;
            // 
            // txtHName
            // 
            this.txtHName.Location = new System.Drawing.Point(171, 144);
            this.txtHName.Name = "txtHName";
            this.txtHName.Size = new System.Drawing.Size(245, 26);
            this.txtHName.TabIndex = 13;
            // 
            // txtHID
            // 
            this.txtHID.Location = new System.Drawing.Point(253, 109);
            this.txtHID.Name = "txtHID";
            this.txtHID.Size = new System.Drawing.Size(163, 26);
            this.txtHID.TabIndex = 12;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(171, 74);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(245, 26);
            this.txtPName.TabIndex = 11;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(253, 38);
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(163, 26);
            this.txtPID.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 411);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Days Available within Year:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 372);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(177, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Min Number of Nights:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Room Price:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Room Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 256);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Longitude:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Latitude:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Number of Properties:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Host Nmae:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Host ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Property Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Property ID:";
            // 
            // bntEditD
            // 
            this.bntEditD.Location = new System.Drawing.Point(475, 86);
            this.bntEditD.Name = "bntEditD";
            this.bntEditD.Size = new System.Drawing.Size(188, 29);
            this.bntEditD.TabIndex = 23;
            this.bntEditD.Text = "Edit District";
            this.bntEditD.UseVisualStyleBackColor = true;
            this.bntEditD.Click += new System.EventHandler(this.bntEditD_Click);
            // 
            // AirBnb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 807);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Neighbourhood);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AirBnb";
            this.Text = "AirBnB";
            this.groupBox1.ResumeLayout(false);
            this.Neighbourhood.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDistrict;
        private System.Windows.Forms.ListBox lstNeighbourhood;
        private System.Windows.Forms.ListBox lstProperty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Neighbourhood;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNNunber;
        private System.Windows.Forms.TextBox txtDisNmae;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPNumber;
        private System.Windows.Forms.TextBox txtNName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN360;
        private System.Windows.Forms.TextBox txtMinNN;
        private System.Windows.Forms.TextBox txtRPrice;
        private System.Windows.Forms.TextBox txtRType;
        private System.Windows.Forms.TextBox txtLong;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtNOP;
        private System.Windows.Forms.TextBox txtHName;
        private System.Windows.Forms.TextBox txtHID;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClearD;
        private System.Windows.Forms.Button btnAddD;
        private System.Windows.Forms.Button bntClearN;
        private System.Windows.Forms.Button bntAddN;
        private System.Windows.Forms.Button bntEditN;
        private System.Windows.Forms.Button bntClearP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.Button bntEditD;
    }
}

