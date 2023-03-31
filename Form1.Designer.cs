namespace Chipset_Wafer_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbox_wafer = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_company = new System.Windows.Forms.ComboBox();
            this.btn_com_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_name = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_111 = new System.Windows.Forms.RadioButton();
            this.rb_110 = new System.Windows.Forms.RadioButton();
            this.rb_100 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_radius = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_n = new System.Windows.Forms.RadioButton();
            this.rb_p = new System.Windows.Forms.RadioButton();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_radius)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbox_wafer
            // 
            this.lbox_wafer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbox_wafer.FormattingEnabled = true;
            this.lbox_wafer.ItemHeight = 16;
            this.lbox_wafer.Location = new System.Drawing.Point(13, 24);
            this.lbox_wafer.Name = "lbox_wafer";
            this.lbox_wafer.Size = new System.Drawing.Size(199, 340);
            this.lbox_wafer.TabIndex = 0;
            this.lbox_wafer.SelectedIndexChanged += new System.EventHandler(this.lbox_wafer_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(231, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Made By :";
            // 
            // cbox_company
            // 
            this.cbox_company.FormattingEnabled = true;
            this.cbox_company.Location = new System.Drawing.Point(397, 30);
            this.cbox_company.Name = "cbox_company";
            this.cbox_company.Size = new System.Drawing.Size(192, 34);
            this.cbox_company.TabIndex = 2;
            // 
            // btn_com_add
            // 
            this.btn_com_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_com_add.Location = new System.Drawing.Point(614, 36);
            this.btn_com_add.Name = "btn_com_add";
            this.btn_com_add.Size = new System.Drawing.Size(119, 32);
            this.btn_com_add.TabIndex = 3;
            this.btn_com_add.Text = "Add";
            this.btn_com_add.UseVisualStyleBackColor = true;
            this.btn_com_add.Click += new System.EventHandler(this.btn_com_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(231, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name : ";
            // 
            // tbox_name
            // 
            this.tbox_name.Location = new System.Drawing.Point(396, 86);
            this.tbox_name.Name = "tbox_name";
            this.tbox_name.Size = new System.Drawing.Size(192, 32);
            this.tbox_name.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_111);
            this.groupBox1.Controls.Add(this.rb_110);
            this.groupBox1.Controls.Add(this.rb_100);
            this.groupBox1.Location = new System.Drawing.Point(235, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // rb_111
            // 
            this.rb_111.AutoSize = true;
            this.rb_111.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rb_111.Location = new System.Drawing.Point(269, 32);
            this.rb_111.Name = "rb_111";
            this.rb_111.Size = new System.Drawing.Size(69, 30);
            this.rb_111.TabIndex = 2;
            this.rb_111.TabStop = true;
            this.rb_111.Text = "111";
            this.rb_111.UseVisualStyleBackColor = true;
            // 
            // rb_110
            // 
            this.rb_110.AutoSize = true;
            this.rb_110.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rb_110.Location = new System.Drawing.Point(161, 32);
            this.rb_110.Name = "rb_110";
            this.rb_110.Size = new System.Drawing.Size(69, 30);
            this.rb_110.TabIndex = 1;
            this.rb_110.TabStop = true;
            this.rb_110.Text = "110";
            this.rb_110.UseVisualStyleBackColor = true;
            // 
            // rb_100
            // 
            this.rb_100.AutoSize = true;
            this.rb_100.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rb_100.Location = new System.Drawing.Point(60, 32);
            this.rb_100.Name = "rb_100";
            this.rb_100.Size = new System.Drawing.Size(69, 30);
            this.rb_100.TabIndex = 0;
            this.rb_100.TabStop = true;
            this.rb_100.Text = "100";
            this.rb_100.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(235, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Radius : ";
            // 
            // nud_radius
            // 
            this.nud_radius.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.nud_radius.Location = new System.Drawing.Point(327, 242);
            this.nud_radius.Name = "nud_radius";
            this.nud_radius.Size = new System.Drawing.Size(201, 32);
            this.nud_radius.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_n);
            this.groupBox2.Controls.Add(this.rb_p);
            this.groupBox2.Location = new System.Drawing.Point(235, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 73);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // rb_n
            // 
            this.rb_n.AutoSize = true;
            this.rb_n.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rb_n.Location = new System.Drawing.Point(235, 30);
            this.rb_n.Name = "rb_n";
            this.rb_n.Size = new System.Drawing.Size(102, 30);
            this.rb_n.TabIndex = 1;
            this.rb_n.TabStop = true;
            this.rb_n.Text = "N Type";
            this.rb_n.UseVisualStyleBackColor = true;
            // 
            // rb_p
            // 
            this.rb_p.AutoSize = true;
            this.rb_p.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.rb_p.Location = new System.Drawing.Point(81, 29);
            this.rb_p.Name = "rb_p";
            this.rb_p.Size = new System.Drawing.Size(101, 30);
            this.rb_p.TabIndex = 0;
            this.rb_p.TabStop = true;
            this.rb_p.Text = "P Type";
            this.rb_p.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_add.Location = new System.Drawing.Point(235, 370);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(166, 35);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Enabled = false;
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btn_remove.Location = new System.Drawing.Point(407, 370);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(166, 35);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Delete";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 440);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.nud_radius);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbox_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_com_add);
            this.Controls.Add(this.cbox_company);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbox_wafer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Chipset Wafer Simulator - 배공민";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_radius)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox_wafer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_company;
        private System.Windows.Forms.Button btn_com_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_111;
        private System.Windows.Forms.RadioButton rb_110;
        private System.Windows.Forms.RadioButton rb_100;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_radius;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_n;
        private System.Windows.Forms.RadioButton rb_p;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
    }
}

