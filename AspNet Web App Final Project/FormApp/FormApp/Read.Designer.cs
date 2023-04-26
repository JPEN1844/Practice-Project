
namespace FormApp
{
    partial class Read
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
            this.txttablename = new System.Windows.Forms.TextBox();
            this.Productlist = new System.Windows.Forms.ListBox();
            this.btnmenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbprice = new System.Windows.Forms.Label();
            this.lbquantity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbsumstar = new System.Windows.Forms.Label();
            this.lbnumstar = new System.Windows.Forms.Label();
            this.lbreviewstar = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(523, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Read Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Table name";
            // 
            // txttablename
            // 
            this.txttablename.Location = new System.Drawing.Point(31, 82);
            this.txttablename.Name = "txttablename";
            this.txttablename.Size = new System.Drawing.Size(153, 22);
            this.txttablename.TabIndex = 2;
            // 
            // Productlist
            // 
            this.Productlist.FormattingEnabled = true;
            this.Productlist.ItemHeight = 16;
            this.Productlist.Location = new System.Drawing.Point(31, 142);
            this.Productlist.Name = "Productlist";
            this.Productlist.Size = new System.Drawing.Size(209, 260);
            this.Productlist.TabIndex = 3;
            this.Productlist.SelectedIndexChanged += new System.EventHandler(this.Productlist_SelectedIndexChanged);
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(963, 406);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(146, 23);
            this.btnmenu.TabIndex = 4;
            this.btnmenu.Text = "Go back to menu";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Product Name";
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(281, 159);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(13, 17);
            this.lbid.TabIndex = 7;
            this.lbid.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(281, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(454, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Sum of star reviews";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(281, 221);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(13, 17);
            this.lbname.TabIndex = 11;
            this.lbname.Text = "-";
            // 
            // lbprice
            // 
            this.lbprice.AutoSize = true;
            this.lbprice.Location = new System.Drawing.Point(284, 284);
            this.lbprice.Name = "lbprice";
            this.lbprice.Size = new System.Drawing.Size(13, 17);
            this.lbprice.TabIndex = 12;
            this.lbprice.Text = "-";
            // 
            // lbquantity
            // 
            this.lbquantity.AutoSize = true;
            this.lbquantity.Location = new System.Drawing.Point(287, 341);
            this.lbquantity.Name = "lbquantity";
            this.lbquantity.Size = new System.Drawing.Size(13, 17);
            this.lbquantity.TabIndex = 13;
            this.lbquantity.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(454, 204);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Number of reviwers";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(457, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Review Star";
            // 
            // lbsumstar
            // 
            this.lbsumstar.AutoSize = true;
            this.lbsumstar.Location = new System.Drawing.Point(457, 163);
            this.lbsumstar.Name = "lbsumstar";
            this.lbsumstar.Size = new System.Drawing.Size(13, 17);
            this.lbsumstar.TabIndex = 16;
            this.lbsumstar.Text = "-";
            // 
            // lbnumstar
            // 
            this.lbnumstar.AutoSize = true;
            this.lbnumstar.Location = new System.Drawing.Point(457, 225);
            this.lbnumstar.Name = "lbnumstar";
            this.lbnumstar.Size = new System.Drawing.Size(13, 17);
            this.lbnumstar.TabIndex = 17;
            this.lbnumstar.Text = "-";
            // 
            // lbreviewstar
            // 
            this.lbreviewstar.AutoSize = true;
            this.lbreviewstar.Location = new System.Drawing.Point(457, 284);
            this.lbreviewstar.Name = "lbreviewstar";
            this.lbreviewstar.Size = new System.Drawing.Size(13, 17);
            this.lbreviewstar.TabIndex = 18;
            this.lbreviewstar.Text = "-";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(679, 163);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(302, 229);
            this.txtdescription.TabIndex = 19;
            this.txtdescription.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(676, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Description";
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(234, 81);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 21;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Read
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.lbreviewstar);
            this.Controls.Add(this.lbnumstar);
            this.Controls.Add(this.lbsumstar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbquantity);
            this.Controls.Add(this.lbprice);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnmenu);
            this.Controls.Add(this.Productlist);
            this.Controls.Add(this.txttablename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Read";
            this.Text = "Read";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttablename;
        private System.Windows.Forms.ListBox Productlist;
        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbprice;
        private System.Windows.Forms.Label lbquantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbsumstar;
        private System.Windows.Forms.Label lbnumstar;
        private System.Windows.Forms.Label lbreviewstar;
        private System.Windows.Forms.RichTextBox txtdescription;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnsearch;
    }
}