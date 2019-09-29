namespace SubnetProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtIpAdd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubnet = new System.Windows.Forms.TextBox();
            this.txtBroad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNetwork = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWildCart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWild = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsub = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtWild2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSub2 = new System.Windows.Forms.TextBox();
            this.btnClearSub = new System.Windows.Forms.Button();
            this.btnClearWild = new System.Windows.Forms.Button();
            this.txtPrefix1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClearMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIpAdd
            // 
            this.txtIpAdd.Location = new System.Drawing.Point(117, 31);
            this.txtIpAdd.Name = "txtIpAdd";
            this.txtIpAdd.Size = new System.Drawing.Size(100, 20);
            this.txtIpAdd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ip Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Subnet Mask";
            // 
            // txtSubnet
            // 
            this.txtSubnet.Location = new System.Drawing.Point(117, 57);
            this.txtSubnet.Name = "txtSubnet";
            this.txtSubnet.Size = new System.Drawing.Size(100, 20);
            this.txtSubnet.TabIndex = 2;
            // 
            // txtBroad
            // 
            this.txtBroad.Location = new System.Drawing.Point(117, 135);
            this.txtBroad.Name = "txtBroad";
            this.txtBroad.Size = new System.Drawing.Size(100, 20);
            this.txtBroad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broadcast IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Network IP";
            // 
            // txtNetwork
            // 
            this.txtNetwork.Location = new System.Drawing.Point(117, 109);
            this.txtNetwork.Name = "txtNetwork";
            this.txtNetwork.Size = new System.Drawing.Size(100, 20);
            this.txtNetwork.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(283, 28);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(241, 31);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(31, 20);
            this.txtPrefix.TabIndex = 9;
            this.txtPrefix.TextChanged += new System.EventHandler(this.TxtPrefix_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "WildCard Mask";
            // 
            // txtWildCart
            // 
            this.txtWildCart.Location = new System.Drawing.Point(117, 83);
            this.txtWildCart.Name = "txtWildCart";
            this.txtWildCart.Size = new System.Drawing.Size(100, 20);
            this.txtWildCart.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "WildCard Mask";
            // 
            // txtWild
            // 
            this.txtWild.Location = new System.Drawing.Point(117, 237);
            this.txtWild.Name = "txtWild";
            this.txtWild.Size = new System.Drawing.Size(100, 20);
            this.txtWild.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Subnet Mask";
            // 
            // txtsub
            // 
            this.txtsub.Location = new System.Drawing.Point(117, 211);
            this.txtsub.Name = "txtsub";
            this.txtsub.Size = new System.Drawing.Size(100, 20);
            this.txtsub.TabIndex = 13;
            this.txtsub.TextChanged += new System.EventHandler(this.Txtsub_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "WildCard Mask";
            // 
            // txtWild2
            // 
            this.txtWild2.Location = new System.Drawing.Point(330, 211);
            this.txtWild2.Name = "txtWild2";
            this.txtWild2.Size = new System.Drawing.Size(100, 20);
            this.txtWild2.TabIndex = 19;
            this.txtWild2.TextChanged += new System.EventHandler(this.TxtWild2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Subnet Mask";
            // 
            // txtSub2
            // 
            this.txtSub2.Location = new System.Drawing.Point(330, 240);
            this.txtSub2.Name = "txtSub2";
            this.txtSub2.Size = new System.Drawing.Size(100, 20);
            this.txtSub2.TabIndex = 17;
            // 
            // btnClearSub
            // 
            this.btnClearSub.Location = new System.Drawing.Point(171, 263);
            this.btnClearSub.Name = "btnClearSub";
            this.btnClearSub.Size = new System.Drawing.Size(46, 23);
            this.btnClearSub.TabIndex = 21;
            this.btnClearSub.Text = "Clear";
            this.btnClearSub.UseVisualStyleBackColor = true;
            this.btnClearSub.Click += new System.EventHandler(this.BtnClearSub_Click);
            // 
            // btnClearWild
            // 
            this.btnClearWild.Location = new System.Drawing.Point(384, 266);
            this.btnClearWild.Name = "btnClearWild";
            this.btnClearWild.Size = new System.Drawing.Size(46, 23);
            this.btnClearWild.TabIndex = 22;
            this.btnClearWild.Text = "Clear";
            this.btnClearWild.UseVisualStyleBackColor = true;
            this.btnClearWild.Click += new System.EventHandler(this.BtnClearWild_Click);
            // 
            // txtPrefix1
            // 
            this.txtPrefix1.Location = new System.Drawing.Point(186, 185);
            this.txtPrefix1.Name = "txtPrefix1";
            this.txtPrefix1.Size = new System.Drawing.Size(31, 20);
            this.txtPrefix1.TabIndex = 23;
            this.txtPrefix1.TextChanged += new System.EventHandler(this.TxtPrefix1_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(114, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Prefix";
            // 
            // btnClearMain
            // 
            this.btnClearMain.Location = new System.Drawing.Point(241, 133);
            this.btnClearMain.Name = "btnClearMain";
            this.btnClearMain.Size = new System.Drawing.Size(46, 23);
            this.btnClearMain.TabIndex = 25;
            this.btnClearMain.Text = "Clear";
            this.btnClearMain.UseVisualStyleBackColor = true;
            this.btnClearMain.Click += new System.EventHandler(this.BtnClearMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 321);
            this.Controls.Add(this.btnClearMain);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPrefix1);
            this.Controls.Add(this.btnClearWild);
            this.Controls.Add(this.btnClearSub);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtWild2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSub2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWild);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsub);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtWildCart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNetwork);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBroad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubnet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIpAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ip Address Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIpAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubnet;
        private System.Windows.Forms.TextBox txtBroad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetwork;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWildCart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtWild;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsub;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtWild2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSub2;
        private System.Windows.Forms.Button btnClearSub;
        private System.Windows.Forms.Button btnClearWild;
        private System.Windows.Forms.TextBox txtPrefix1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClearMain;
    }
}

