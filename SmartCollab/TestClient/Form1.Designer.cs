namespace TestClient
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new TestClient.masterDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.serviceURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serv_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.searchServ = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reqKW = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.searchReq = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tenant_id = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.requirement_id = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.serv_id = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.repubServ = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.subListServ = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.servSubRslt = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.reqSubRslt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.reqSubList = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.reqOwner = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.ownRslt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ServOwn = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.masterDataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(304, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Publish Service";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // serviceURL
            // 
            this.serviceURL.Location = new System.Drawing.Point(213, 32);
            this.serviceURL.Name = "serviceURL";
            this.serviceURL.Size = new System.Drawing.Size(100, 20);
            this.serviceURL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to SmartCollab Test Client";
            // 
            // serv_desc
            // 
            this.serv_desc.Location = new System.Drawing.Point(213, 68);
            this.serv_desc.Multiline = true;
            this.serv_desc.Name = "serv_desc";
            this.serv_desc.Size = new System.Drawing.Size(100, 152);
            this.serv_desc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Service URL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Service Description";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.serv_desc);
            this.groupBox1.Controls.Add(this.serviceURL);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 255);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publishing a Service";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.searchServ);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(490, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 147);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Searching for a Service";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Search Keywords";
            // 
            // searchServ
            // 
            this.searchServ.Location = new System.Drawing.Point(213, 32);
            this.searchServ.Name = "searchServ";
            this.searchServ.Size = new System.Drawing.Size(100, 20);
            this.searchServ.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(304, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Search for a Service";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.reqKW);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 147);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Publishing a Requirement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Requirement";
            // 
            // reqKW
            // 
            this.reqKW.Location = new System.Drawing.Point(213, 33);
            this.reqKW.Multiline = true;
            this.reqKW.Name = "reqKW";
            this.reqKW.Size = new System.Drawing.Size(100, 60);
            this.reqKW.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(304, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Publish Requirements";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.searchReq);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(490, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 249);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Searching for a Requirement";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Search Requirements";
            // 
            // searchReq
            // 
            this.searchReq.Location = new System.Drawing.Point(213, 32);
            this.searchReq.Multiline = true;
            this.searchReq.Name = "searchReq";
            this.searchReq.Size = new System.Drawing.Size(100, 163);
            this.searchReq.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(9, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(304, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Search Requirements";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tenant ID: ";
            // 
            // tenant_id
            // 
            this.tenant_id.Location = new System.Drawing.Point(69, 10);
            this.tenant_id.Name = "tenant_id";
            this.tenant_id.Size = new System.Drawing.Size(100, 20);
            this.tenant_id.TabIndex = 13;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.requirement_id);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Location = new System.Drawing.Point(12, 498);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(340, 147);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Unpublishing a Requirement";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Requirement ID";
            // 
            // requirement_id
            // 
            this.requirement_id.Location = new System.Drawing.Point(213, 33);
            this.requirement_id.Name = "requirement_id";
            this.requirement_id.Size = new System.Drawing.Size(100, 20);
            this.requirement_id.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(9, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(304, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Unpublish Requirements";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.serv_id);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Location = new System.Drawing.Point(490, 498);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 147);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Unpublishing a Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Service ID";
            // 
            // serv_id
            // 
            this.serv_id.Location = new System.Drawing.Point(213, 33);
            this.serv_id.Name = "serv_id";
            this.serv_id.Size = new System.Drawing.Size(100, 20);
            this.serv_id.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(304, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Unpublish Service";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.repubServ);
            this.groupBox7.Controls.Add(this.button7);
            this.groupBox7.Location = new System.Drawing.Point(12, 651);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(340, 147);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Republish Service";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Service ID";
            // 
            // repubServ
            // 
            this.repubServ.Location = new System.Drawing.Point(213, 33);
            this.repubServ.Name = "repubServ";
            this.repubServ.Size = new System.Drawing.Size(100, 20);
            this.repubServ.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(9, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(304, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Republish Service";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.servSubRslt);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.subListServ);
            this.groupBox8.Controls.Add(this.button8);
            this.groupBox8.Location = new System.Drawing.Point(490, 651);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(340, 147);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Get Service Subscribers";
            // 
            // subListServ
            // 
            this.subListServ.Location = new System.Drawing.Point(213, 33);
            this.subListServ.Name = "subListServ";
            this.subListServ.Size = new System.Drawing.Size(100, 20);
            this.subListServ.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(9, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(304, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "Get Service Subscribers";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Service ID";
            // 
            // servSubRslt
            // 
            this.servSubRslt.Location = new System.Drawing.Point(6, 61);
            this.servSubRslt.Multiline = true;
            this.servSubRslt.Name = "servSubRslt";
            this.servSubRslt.Size = new System.Drawing.Size(307, 20);
            this.servSubRslt.TabIndex = 10;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.reqSubRslt);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.reqSubList);
            this.groupBox9.Controls.Add(this.button9);
            this.groupBox9.Location = new System.Drawing.Point(959, 84);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(340, 147);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Get Requirement Subscribers";
            // 
            // reqSubRslt
            // 
            this.reqSubRslt.Location = new System.Drawing.Point(6, 61);
            this.reqSubRslt.Multiline = true;
            this.reqSubRslt.Name = "reqSubRslt";
            this.reqSubRslt.Size = new System.Drawing.Size(307, 20);
            this.reqSubRslt.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Requirement ID";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // reqSubList
            // 
            this.reqSubList.Location = new System.Drawing.Point(213, 33);
            this.reqSubList.Name = "reqSubList";
            this.reqSubList.Size = new System.Drawing.Size(100, 20);
            this.reqSubList.TabIndex = 3;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(9, 99);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(304, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Get Requirement Subscribers";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.reqOwner);
            this.groupBox10.Controls.Add(this.button10);
            this.groupBox10.Location = new System.Drawing.Point(959, 244);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(340, 147);
            this.groupBox10.TabIndex = 15;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Get Requirement Owner";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Requirement ID";
            // 
            // reqOwner
            // 
            this.reqOwner.Location = new System.Drawing.Point(213, 33);
            this.reqOwner.Name = "reqOwner";
            this.reqOwner.Size = new System.Drawing.Size(100, 20);
            this.reqOwner.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(9, 99);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(304, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Get Requirement Owner";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.ownRslt);
            this.groupBox11.Controls.Add(this.label14);
            this.groupBox11.Controls.Add(this.ServOwn);
            this.groupBox11.Controls.Add(this.button11);
            this.groupBox11.Location = new System.Drawing.Point(959, 404);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(340, 147);
            this.groupBox11.TabIndex = 16;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Get Owned Services";
            // 
            // ownRslt
            // 
            this.ownRslt.Location = new System.Drawing.Point(6, 61);
            this.ownRslt.Multiline = true;
            this.ownRslt.Name = "ownRslt";
            this.ownRslt.Size = new System.Drawing.Size(307, 20);
            this.ownRslt.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Tenant ID";
            // 
            // ServOwn
            // 
            this.ServOwn.Location = new System.Drawing.Point(213, 33);
            this.ServOwn.Name = "ServOwn";
            this.ServOwn.Size = new System.Drawing.Size(100, 20);
            this.ServOwn.TabIndex = 3;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(9, 99);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(304, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "Get Owned Services";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 873);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.tenant_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SmartCollab Test Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox serviceURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serv_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchServ;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reqKW;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox searchReq;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tenant_id;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox requirement_id;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox serv_id;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox repubServ;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox servSubRslt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox subListServ;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox reqSubRslt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox reqSubList;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox reqOwner;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox ownRslt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ServOwn;
        private System.Windows.Forms.Button button11;
    }
}

