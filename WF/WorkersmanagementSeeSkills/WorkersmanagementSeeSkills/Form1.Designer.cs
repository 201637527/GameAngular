namespace WorkersmanagementSeeSkills
{
    partial class FrmSkillsdata
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
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.dgvskill = new System.Windows.Forms.DataGridView();
            this.txtSelectALLinfo = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblNewEmployee = new System.Windows.Forms.Label();
            this.lblempFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.txtFn = new System.Windows.Forms.TextBox();
            this.txtLn = new System.Windows.Forms.TextBox();
            this.txtEm = new System.Windows.Forms.TextBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.btnSumbitEmp = new System.Windows.Forms.Button();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.linklblURL = new System.Windows.Forms.LinkLabel();
            this.lblAddurl = new System.Windows.Forms.Label();
            this.btnSumbitURL = new System.Windows.Forms.Button();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblSkills = new System.Windows.Forms.Label();
            this.lblNewSkill = new System.Windows.Forms.Label();
            this.lblNameskill = new System.Windows.Forms.Label();
            this.lblBerif = new System.Windows.Forms.Label();
            this.txtNameSkill = new System.Windows.Forms.TextBox();
            this.txtberif = new System.Windows.Forms.TextBox();
            this.btnSumSkill = new System.Windows.Forms.Button();
            this.lbladdref = new System.Windows.Forms.Label();
            this.lblFn = new System.Windows.Forms.Label();
            this.lblLas = new System.Windows.Forms.Label();
            this.lblEm = new System.Windows.Forms.Label();
            this.lblPo = new System.Windows.Forms.Label();
            this.txtFnRef = new System.Windows.Forms.TextBox();
            this.txtPoRef = new System.Windows.Forms.TextBox();
            this.txtLasRef = new System.Windows.Forms.TextBox();
            this.txtEmRef = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSumbitRef = new System.Windows.Forms.Button();
            this.lblSkilLAndREF = new System.Windows.Forms.Label();
            this.lblAliasRef = new System.Windows.Forms.Label();
            this.txtAliRef = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvskill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvemp
            // 
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Location = new System.Drawing.Point(26, 22);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.ReadOnly = true;
            this.dgvemp.Size = new System.Drawing.Size(240, 150);
            this.dgvemp.TabIndex = 0;
            this.dgvemp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemp_CellClick);
            // 
            // dgvskill
            // 
            this.dgvskill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvskill.Location = new System.Drawing.Point(26, 205);
            this.dgvskill.Name = "dgvskill";
            this.dgvskill.ReadOnly = true;
            this.dgvskill.Size = new System.Drawing.Size(240, 150);
            this.dgvskill.TabIndex = 1;
            this.dgvskill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvskill_CellClick);
            // 
            // txtSelectALLinfo
            // 
            this.txtSelectALLinfo.Location = new System.Drawing.Point(330, 22);
            this.txtSelectALLinfo.Multiline = true;
            this.txtSelectALLinfo.Name = "txtSelectALLinfo";
            this.txtSelectALLinfo.ReadOnly = true;
            this.txtSelectALLinfo.Size = new System.Drawing.Size(365, 333);
            this.txtSelectALLinfo.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(112, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(193, 388);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(26, 362);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // lblNewEmployee
            // 
            this.lblNewEmployee.AutoSize = true;
            this.lblNewEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewEmployee.Location = new System.Drawing.Point(12, 414);
            this.lblNewEmployee.Name = "lblNewEmployee";
            this.lblNewEmployee.Size = new System.Drawing.Size(132, 17);
            this.lblNewEmployee.TabIndex = 6;
            this.lblNewEmployee.Text = "ADD new Employee";
            // 
            // lblempFirstName
            // 
            this.lblempFirstName.AutoSize = true;
            this.lblempFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempFirstName.Location = new System.Drawing.Point(9, 439);
            this.lblempFirstName.Name = "lblempFirstName";
            this.lblempFirstName.Size = new System.Drawing.Size(61, 15);
            this.lblempFirstName.TabIndex = 7;
            this.lblempFirstName.Text = "FirsNmae";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(9, 460);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(64, 15);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "LastName";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(25, 484);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlias.Location = new System.Drawing.Point(25, 500);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(33, 15);
            this.lblAlias.TabIndex = 10;
            this.lblAlias.Text = "Alias";
            // 
            // txtFn
            // 
            this.txtFn.Location = new System.Drawing.Point(71, 434);
            this.txtFn.Name = "txtFn";
            this.txtFn.Size = new System.Drawing.Size(100, 20);
            this.txtFn.TabIndex = 11;
            // 
            // txtLn
            // 
            this.txtLn.Location = new System.Drawing.Point(70, 457);
            this.txtLn.Name = "txtLn";
            this.txtLn.Size = new System.Drawing.Size(100, 20);
            this.txtLn.TabIndex = 12;
            // 
            // txtEm
            // 
            this.txtEm.Location = new System.Drawing.Point(71, 479);
            this.txtEm.Name = "txtEm";
            this.txtEm.Size = new System.Drawing.Size(100, 20);
            this.txtEm.TabIndex = 13;
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(70, 499);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(100, 20);
            this.txtAlias.TabIndex = 14;
            // 
            // btnSumbitEmp
            // 
            this.btnSumbitEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbitEmp.Location = new System.Drawing.Point(17, 526);
            this.btnSumbitEmp.Name = "btnSumbitEmp";
            this.btnSumbitEmp.Size = new System.Drawing.Size(153, 35);
            this.btnSumbitEmp.TabIndex = 15;
            this.btnSumbitEmp.Text = "Sumbit employee";
            this.btnSumbitEmp.UseVisualStyleBackColor = true;
            this.btnSumbitEmp.Click += new System.EventHandler(this.btnSumbitEmp_Click);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(328, 380);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(57, 13);
            this.lblURL.TabIndex = 16;
            this.lblURL.Text = "URL/UNC";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(391, 377);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(294, 20);
            this.txtURL.TabIndex = 17;
            // 
            // linklblURL
            // 
            this.linklblURL.AutoSize = true;
            this.linklblURL.Location = new System.Drawing.Point(343, 270);
            this.linklblURL.Name = "linklblURL";
            this.linklblURL.Size = new System.Drawing.Size(55, 13);
            this.linklblURL.TabIndex = 18;
            this.linklblURL.TabStop = true;
            this.linklblURL.Text = "linklblURL";
            this.linklblURL.UseMnemonic = false;
            this.linklblURL.UseWaitCursor = true;
            this.linklblURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblURL_LinkClicked);
            // 
            // lblAddurl
            // 
            this.lblAddurl.AutoSize = true;
            this.lblAddurl.Enabled = false;
            this.lblAddurl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddurl.Location = new System.Drawing.Point(397, 357);
            this.lblAddurl.Name = "lblAddurl";
            this.lblAddurl.Size = new System.Drawing.Size(153, 17);
            this.lblAddurl.TabIndex = 1;
            this.lblAddurl.Text = "Add info to cument skill";
            // 
            // btnSumbitURL
            // 
            this.btnSumbitURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumbitURL.Location = new System.Drawing.Point(610, 403);
            this.btnSumbitURL.Name = "btnSumbitURL";
            this.btnSumbitURL.Size = new System.Drawing.Size(75, 23);
            this.btnSumbitURL.TabIndex = 20;
            this.btnSumbitURL.Text = "Sumbit info";
            this.btnSumbitURL.UseVisualStyleBackColor = true;
            this.btnSumbitURL.Click += new System.EventHandler(this.btnSumbitURL_Click);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(14, 2);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(308, 17);
            this.lblEmp.TabIndex = 21;
            this.lblEmp.Text = "Employee (Click to Select an existing employee)";
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkills.Location = new System.Drawing.Point(25, 185);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(238, 17);
            this.lblSkills.TabIndex = 22;
            this.lblSkills.Text = "Skills(Click to get all skill information)";
            // 
            // lblNewSkill
            // 
            this.lblNewSkill.AutoSize = true;
            this.lblNewSkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewSkill.Location = new System.Drawing.Point(249, 416);
            this.lblNewSkill.Name = "lblNewSkill";
            this.lblNewSkill.Size = new System.Drawing.Size(58, 15);
            this.lblNewSkill.TabIndex = 23;
            this.lblNewSkill.Text = "New Skill";
            // 
            // lblNameskill
            // 
            this.lblNameskill.AutoSize = true;
            this.lblNameskill.Location = new System.Drawing.Point(190, 434);
            this.lblNameskill.Name = "lblNameskill";
            this.lblNameskill.Size = new System.Drawing.Size(163, 13);
            this.lblNameskill.TabIndex = 24;
            this.lblNameskill.Text = "ShortNameOf Skill or technologie";
            // 
            // lblBerif
            // 
            this.lblBerif.AutoSize = true;
            this.lblBerif.Location = new System.Drawing.Point(186, 470);
            this.lblBerif.Name = "lblBerif";
            this.lblBerif.Size = new System.Drawing.Size(121, 13);
            this.lblBerif.TabIndex = 25;
            this.lblBerif.Text = "Berif Descnpition of Skill";
            // 
            // txtNameSkill
            // 
            this.txtNameSkill.Location = new System.Drawing.Point(251, 450);
            this.txtNameSkill.Name = "txtNameSkill";
            this.txtNameSkill.Size = new System.Drawing.Size(133, 20);
            this.txtNameSkill.TabIndex = 26;
            // 
            // txtberif
            // 
            this.txtberif.Location = new System.Drawing.Point(251, 486);
            this.txtberif.Multiline = true;
            this.txtberif.Name = "txtberif";
            this.txtberif.Size = new System.Drawing.Size(134, 43);
            this.txtberif.TabIndex = 27;
            // 
            // btnSumSkill
            // 
            this.btnSumSkill.Location = new System.Drawing.Point(251, 535);
            this.btnSumSkill.Name = "btnSumSkill";
            this.btnSumSkill.Size = new System.Drawing.Size(133, 23);
            this.btnSumSkill.TabIndex = 28;
            this.btnSumSkill.Text = "Sumbit Skill";
            this.btnSumSkill.UseVisualStyleBackColor = true;
            this.btnSumSkill.Click += new System.EventHandler(this.btnSumSkill_Click);
            // 
            // lbladdref
            // 
            this.lbladdref.AutoSize = true;
            this.lbladdref.Location = new System.Drawing.Point(448, 434);
            this.lbladdref.Name = "lbladdref";
            this.lbladdref.Size = new System.Drawing.Size(203, 13);
            this.lbladdref.TabIndex = 29;
            this.lbladdref.Text = "Add Refernce Person to Select Employee";
            // 
            // lblFn
            // 
            this.lblFn.AutoSize = true;
            this.lblFn.Location = new System.Drawing.Point(434, 462);
            this.lblFn.Name = "lblFn";
            this.lblFn.Size = new System.Drawing.Size(57, 13);
            this.lblFn.TabIndex = 30;
            this.lblFn.Text = "First Name";
            // 
            // lblLas
            // 
            this.lblLas.AutoSize = true;
            this.lblLas.Location = new System.Drawing.Point(441, 489);
            this.lblLas.Name = "lblLas";
            this.lblLas.Size = new System.Drawing.Size(55, 13);
            this.lblLas.TabIndex = 31;
            this.lblLas.Text = "LastName";
            // 
            // lblEm
            // 
            this.lblEm.AutoSize = true;
            this.lblEm.Location = new System.Drawing.Point(459, 537);
            this.lblEm.Name = "lblEm";
            this.lblEm.Size = new System.Drawing.Size(32, 13);
            this.lblEm.TabIndex = 32;
            this.lblEm.Text = "Email";
            // 
            // lblPo
            // 
            this.lblPo.AutoSize = true;
            this.lblPo.Location = new System.Drawing.Point(447, 518);
            this.lblPo.Name = "lblPo";
            this.lblPo.Size = new System.Drawing.Size(44, 13);
            this.lblPo.TabIndex = 33;
            this.lblPo.Text = "Position";
            // 
            // txtFnRef
            // 
            this.txtFnRef.Location = new System.Drawing.Point(502, 459);
            this.txtFnRef.Name = "txtFnRef";
            this.txtFnRef.Size = new System.Drawing.Size(100, 20);
            this.txtFnRef.TabIndex = 34;
            // 
            // txtPoRef
            // 
            this.txtPoRef.Location = new System.Drawing.Point(502, 508);
            this.txtPoRef.Name = "txtPoRef";
            this.txtPoRef.Size = new System.Drawing.Size(100, 20);
            this.txtPoRef.TabIndex = 35;
            // 
            // txtLasRef
            // 
            this.txtLasRef.Location = new System.Drawing.Point(502, 482);
            this.txtLasRef.Name = "txtLasRef";
            this.txtLasRef.Size = new System.Drawing.Size(100, 20);
            this.txtLasRef.TabIndex = 36;
            // 
            // txtEmRef
            // 
            this.txtEmRef.Location = new System.Drawing.Point(502, 534);
            this.txtEmRef.Name = "txtEmRef";
            this.txtEmRef.Size = new System.Drawing.Size(100, 20);
            this.txtEmRef.TabIndex = 37;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(620, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSumbitRef
            // 
            this.btnSumbitRef.Location = new System.Drawing.Point(527, 577);
            this.btnSumbitRef.Name = "btnSumbitRef";
            this.btnSumbitRef.Size = new System.Drawing.Size(75, 23);
            this.btnSumbitRef.TabIndex = 39;
            this.btnSumbitRef.Text = "Sumbit Ref";
            this.btnSumbitRef.UseVisualStyleBackColor = true;
            this.btnSumbitRef.Click += new System.EventHandler(this.btnSumbitRef_Click);
            // 
            // lblSkilLAndREF
            // 
            this.lblSkilLAndREF.AutoSize = true;
            this.lblSkilLAndREF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkilLAndREF.Location = new System.Drawing.Point(346, 3);
            this.lblSkilLAndREF.Name = "lblSkilLAndREF";
            this.lblSkilLAndREF.Size = new System.Drawing.Size(102, 17);
            this.lblSkilLAndREF.TabIndex = 40;
            this.lblSkilLAndREF.Text = "Skills/Refernce";
            // 
            // lblAliasRef
            // 
            this.lblAliasRef.AutoSize = true;
            this.lblAliasRef.Location = new System.Drawing.Point(459, 562);
            this.lblAliasRef.Name = "lblAliasRef";
            this.lblAliasRef.Size = new System.Drawing.Size(29, 13);
            this.lblAliasRef.TabIndex = 41;
            this.lblAliasRef.Text = "Alias";
            // 
            // txtAliRef
            // 
            this.txtAliRef.Location = new System.Drawing.Point(502, 559);
            this.txtAliRef.Name = "txtAliRef";
            this.txtAliRef.Size = new System.Drawing.Size(100, 20);
            this.txtAliRef.TabIndex = 42;
            // 
            // FrmSkillsdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 767);
            this.Controls.Add(this.txtAliRef);
            this.Controls.Add(this.lblAliasRef);
            this.Controls.Add(this.lblSkilLAndREF);
            this.Controls.Add(this.btnSumbitRef);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtEmRef);
            this.Controls.Add(this.txtLasRef);
            this.Controls.Add(this.txtPoRef);
            this.Controls.Add(this.txtFnRef);
            this.Controls.Add(this.lblPo);
            this.Controls.Add(this.lblEm);
            this.Controls.Add(this.lblLas);
            this.Controls.Add(this.lblFn);
            this.Controls.Add(this.lbladdref);
            this.Controls.Add(this.btnSumSkill);
            this.Controls.Add(this.txtberif);
            this.Controls.Add(this.txtNameSkill);
            this.Controls.Add(this.lblBerif);
            this.Controls.Add(this.lblNameskill);
            this.Controls.Add(this.lblNewSkill);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.btnSumbitURL);
            this.Controls.Add(this.lblAddurl);
            this.Controls.Add(this.linklblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.btnSumbitEmp);
            this.Controls.Add(this.txtAlias);
            this.Controls.Add(this.txtEm);
            this.Controls.Add(this.txtLn);
            this.Controls.Add(this.txtFn);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblempFirstName);
            this.Controls.Add(this.lblNewEmployee);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtSelectALLinfo);
            this.Controls.Add(this.dgvskill);
            this.Controls.Add(this.dgvemp);
            this.Name = "FrmSkillsdata";
            this.Text = "HR Skills Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvskill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.DataGridView dgvskill;
        private System.Windows.Forms.TextBox txtSelectALLinfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblNewEmployee;
        private System.Windows.Forms.Label lblempFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.TextBox txtFn;
        private System.Windows.Forms.TextBox txtLn;
        private System.Windows.Forms.TextBox txtEm;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Button btnSumbitEmp;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.LinkLabel linklblURL;
        private System.Windows.Forms.Label lblAddurl;
        private System.Windows.Forms.Button btnSumbitURL;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.Label lblNewSkill;
        private System.Windows.Forms.Label lblNameskill;
        private System.Windows.Forms.Label lblBerif;
        private System.Windows.Forms.TextBox txtNameSkill;
        private System.Windows.Forms.TextBox txtberif;
        private System.Windows.Forms.Button btnSumSkill;
        private System.Windows.Forms.Label lbladdref;
        private System.Windows.Forms.Label lblFn;
        private System.Windows.Forms.Label lblLas;
        private System.Windows.Forms.Label lblEm;
        private System.Windows.Forms.Label lblPo;
        private System.Windows.Forms.TextBox txtFnRef;
        private System.Windows.Forms.TextBox txtPoRef;
        private System.Windows.Forms.TextBox txtLasRef;
        private System.Windows.Forms.TextBox txtEmRef;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSumbitRef;
        private System.Windows.Forms.Label lblSkilLAndREF;
        private System.Windows.Forms.Label lblAliasRef;
        private System.Windows.Forms.TextBox txtAliRef;
    }
}

