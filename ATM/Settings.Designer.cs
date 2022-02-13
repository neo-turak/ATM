namespace ATM
{
    partial class Settings
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProjectId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.btn_layout = new System.Windows.Forms.Button();
            this.btn_fragment = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnComponent = new System.Windows.Forms.Button();
            this.btnModule = new System.Windows.Forms.Button();
            this.btnPresenter = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnModel = new System.Windows.Forms.Button();
            this.tb_layout = new System.Windows.Forms.TextBox();
            this.tb_fragment = new System.Windows.Forms.TextBox();
            this.tb_view = new System.Windows.Forms.TextBox();
            this.tb_component = new System.Windows.Forms.TextBox();
            this.tb_module = new System.Windows.Forms.TextBox();
            this.tb_presenter = new System.Windows.Forms.TextBox();
            this.tb_contract = new System.Windows.Forms.TextBox();
            this.cb_layout = new System.Windows.Forms.CheckBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.cb_fragment = new System.Windows.Forms.CheckBox();
            this.cb_view = new System.Windows.Forms.CheckBox();
            this.cb_component = new System.Windows.Forms.CheckBox();
            this.cb_module = new System.Windows.Forms.CheckBox();
            this.cb_presenter = new System.Windows.Forms.CheckBox();
            this.cb_contract = new System.Windows.Forms.CheckBox();
            this.cb_model = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(284, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "基本参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "用   户   名:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(144, 52);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(166, 25);
            this.tbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "项 目  名 称:";
            // 
            // tbProjectId
            // 
            this.tbProjectId.Location = new System.Drawing.Point(143, 83);
            this.tbProjectId.Name = "tbProjectId";
            this.tbProjectId.Size = new System.Drawing.Size(281, 25);
            this.tbProjectId.TabIndex = 2;
            this.tbProjectId.TextChanged += new System.EventHandler(this.tbProjectId_TextChanged);
            this.tbProjectId.Leave += new System.EventHandler(this.tbProjectId_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "项 目  目 录:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "选择目录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(37, 146);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 15);
            this.lblPath.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbAuto);
            this.groupBox1.Controls.Add(this.btn_layout);
            this.groupBox1.Controls.Add(this.btn_fragment);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnComponent);
            this.groupBox1.Controls.Add(this.btnModule);
            this.groupBox1.Controls.Add(this.btnPresenter);
            this.groupBox1.Controls.Add(this.btnContract);
            this.groupBox1.Controls.Add(this.btnModel);
            this.groupBox1.Controls.Add(this.tb_layout);
            this.groupBox1.Controls.Add(this.tb_fragment);
            this.groupBox1.Controls.Add(this.tb_view);
            this.groupBox1.Controls.Add(this.tb_component);
            this.groupBox1.Controls.Add(this.tb_module);
            this.groupBox1.Controls.Add(this.tb_presenter);
            this.groupBox1.Controls.Add(this.tb_contract);
            this.groupBox1.Controls.Add(this.cb_layout);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.cb_fragment);
            this.groupBox1.Controls.Add(this.cb_view);
            this.groupBox1.Controls.Add(this.cb_component);
            this.groupBox1.Controls.Add(this.cb_module);
            this.groupBox1.Controls.Add(this.cb_presenter);
            this.groupBox1.Controls.Add(this.cb_contract);
            this.groupBox1.Controls.Add(this.cb_model);
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.groupBox1.Location = new System.Drawing.Point(34, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 370);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(107, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "勾选：生成文件的时候自动创建到对应的目录下。\r\n未勾选：生成到设置的目录下。";
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(14, 275);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(86, 19);
            this.cbAuto.TabIndex = 17;
            this.cbAuto.Text = "自动写入";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // btn_layout
            // 
            this.btn_layout.Location = new System.Drawing.Point(476, 229);
            this.btn_layout.Name = "btn_layout";
            this.btn_layout.Size = new System.Drawing.Size(86, 28);
            this.btn_layout.TabIndex = 16;
            this.btn_layout.Text = "选择";
            this.btn_layout.UseVisualStyleBackColor = true;
            this.btn_layout.Click += new System.EventHandler(this.btn_layout_Click);
            // 
            // btn_fragment
            // 
            this.btn_fragment.Location = new System.Drawing.Point(476, 198);
            this.btn_fragment.Name = "btn_fragment";
            this.btn_fragment.Size = new System.Drawing.Size(86, 28);
            this.btn_fragment.TabIndex = 16;
            this.btn_fragment.Text = "选择";
            this.btn_fragment.UseVisualStyleBackColor = true;
            this.btn_fragment.Click += new System.EventHandler(this.btn_fragment_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(476, 169);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(86, 28);
            this.btnView.TabIndex = 16;
            this.btnView.Text = "选择";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnActivity_Click);
            // 
            // btnComponent
            // 
            this.btnComponent.Location = new System.Drawing.Point(476, 140);
            this.btnComponent.Name = "btnComponent";
            this.btnComponent.Size = new System.Drawing.Size(86, 28);
            this.btnComponent.TabIndex = 16;
            this.btnComponent.Text = "选择";
            this.btnComponent.UseVisualStyleBackColor = true;
            this.btnComponent.Click += new System.EventHandler(this.btnComponent_Click);
            // 
            // btnModule
            // 
            this.btnModule.Location = new System.Drawing.Point(476, 110);
            this.btnModule.Name = "btnModule";
            this.btnModule.Size = new System.Drawing.Size(86, 28);
            this.btnModule.TabIndex = 16;
            this.btnModule.Text = "选择";
            this.btnModule.UseVisualStyleBackColor = true;
            this.btnModule.Click += new System.EventHandler(this.btnModule_Click);
            // 
            // btnPresenter
            // 
            this.btnPresenter.Location = new System.Drawing.Point(476, 80);
            this.btnPresenter.Name = "btnPresenter";
            this.btnPresenter.Size = new System.Drawing.Size(86, 28);
            this.btnPresenter.TabIndex = 16;
            this.btnPresenter.Text = "选择";
            this.btnPresenter.UseVisualStyleBackColor = true;
            this.btnPresenter.Click += new System.EventHandler(this.btnPresenter_Click);
            // 
            // btnContract
            // 
            this.btnContract.Location = new System.Drawing.Point(476, 21);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(86, 28);
            this.btnContract.TabIndex = 16;
            this.btnContract.Text = "选择";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(476, 51);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(86, 28);
            this.btnModel.TabIndex = 16;
            this.btnModel.Text = "选择";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // tb_layout
            // 
            this.tb_layout.Location = new System.Drawing.Point(110, 230);
            this.tb_layout.Name = "tb_layout";
            this.tb_layout.Size = new System.Drawing.Size(360, 25);
            this.tb_layout.TabIndex = 15;
            // 
            // tb_fragment
            // 
            this.tb_fragment.Location = new System.Drawing.Point(110, 199);
            this.tb_fragment.Name = "tb_fragment";
            this.tb_fragment.Size = new System.Drawing.Size(360, 25);
            this.tb_fragment.TabIndex = 15;
            // 
            // tb_view
            // 
            this.tb_view.Location = new System.Drawing.Point(110, 169);
            this.tb_view.Name = "tb_view";
            this.tb_view.Size = new System.Drawing.Size(360, 25);
            this.tb_view.TabIndex = 15;
            // 
            // tb_component
            // 
            this.tb_component.Location = new System.Drawing.Point(110, 140);
            this.tb_component.Name = "tb_component";
            this.tb_component.Size = new System.Drawing.Size(360, 25);
            this.tb_component.TabIndex = 14;
            // 
            // tb_module
            // 
            this.tb_module.Location = new System.Drawing.Point(110, 109);
            this.tb_module.Name = "tb_module";
            this.tb_module.Size = new System.Drawing.Size(360, 25);
            this.tb_module.TabIndex = 13;
            // 
            // tb_presenter
            // 
            this.tb_presenter.Location = new System.Drawing.Point(110, 80);
            this.tb_presenter.Name = "tb_presenter";
            this.tb_presenter.Size = new System.Drawing.Size(360, 25);
            this.tb_presenter.TabIndex = 12;
            // 
            // tb_contract
            // 
            this.tb_contract.Location = new System.Drawing.Point(110, 21);
            this.tb_contract.Name = "tb_contract";
            this.tb_contract.Size = new System.Drawing.Size(360, 25);
            this.tb_contract.TabIndex = 11;
            // 
            // cb_layout
            // 
            this.cb_layout.AutoSize = true;
            this.cb_layout.Checked = true;
            this.cb_layout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_layout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_layout.Location = new System.Drawing.Point(15, 232);
            this.cb_layout.Name = "cb_layout";
            this.cb_layout.Size = new System.Drawing.Size(74, 19);
            this.cb_layout.TabIndex = 9;
            this.cb_layout.Text = "Layout";
            this.cb_layout.UseVisualStyleBackColor = true;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(110, 51);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(359, 25);
            this.tb_model.TabIndex = 10;
            // 
            // cb_fragment
            // 
            this.cb_fragment.AutoSize = true;
            this.cb_fragment.Checked = true;
            this.cb_fragment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_fragment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_fragment.Location = new System.Drawing.Point(15, 201);
            this.cb_fragment.Name = "cb_fragment";
            this.cb_fragment.Size = new System.Drawing.Size(90, 19);
            this.cb_fragment.TabIndex = 9;
            this.cb_fragment.Text = "Fragment";
            this.cb_fragment.UseVisualStyleBackColor = true;
            // 
            // cb_view
            // 
            this.cb_view.AutoSize = true;
            this.cb_view.Checked = true;
            this.cb_view.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_view.Location = new System.Drawing.Point(15, 171);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(90, 19);
            this.cb_view.TabIndex = 9;
            this.cb_view.Text = "Activity";
            this.cb_view.UseVisualStyleBackColor = true;
            // 
            // cb_component
            // 
            this.cb_component.AutoSize = true;
            this.cb_component.Checked = true;
            this.cb_component.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_component.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_component.Location = new System.Drawing.Point(14, 142);
            this.cb_component.Name = "cb_component";
            this.cb_component.Size = new System.Drawing.Size(98, 19);
            this.cb_component.TabIndex = 8;
            this.cb_component.Text = "Component";
            this.cb_component.UseVisualStyleBackColor = true;
            // 
            // cb_module
            // 
            this.cb_module.AutoSize = true;
            this.cb_module.Checked = true;
            this.cb_module.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_module.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_module.Location = new System.Drawing.Point(14, 112);
            this.cb_module.Name = "cb_module";
            this.cb_module.Size = new System.Drawing.Size(74, 19);
            this.cb_module.TabIndex = 7;
            this.cb_module.Text = "Module";
            this.cb_module.UseVisualStyleBackColor = true;
            // 
            // cb_presenter
            // 
            this.cb_presenter.AutoSize = true;
            this.cb_presenter.Checked = true;
            this.cb_presenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_presenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_presenter.Location = new System.Drawing.Point(13, 80);
            this.cb_presenter.Name = "cb_presenter";
            this.cb_presenter.Size = new System.Drawing.Size(98, 19);
            this.cb_presenter.TabIndex = 6;
            this.cb_presenter.Text = "Presenter";
            this.cb_presenter.UseVisualStyleBackColor = true;
            // 
            // cb_contract
            // 
            this.cb_contract.AutoSize = true;
            this.cb_contract.Checked = true;
            this.cb_contract.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_contract.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_contract.Location = new System.Drawing.Point(13, 23);
            this.cb_contract.Name = "cb_contract";
            this.cb_contract.Size = new System.Drawing.Size(90, 19);
            this.cb_contract.TabIndex = 5;
            this.cb_contract.Text = "Contract";
            this.cb_contract.UseVisualStyleBackColor = true;
            // 
            // cb_model
            // 
            this.cb_model.AutoSize = true;
            this.cb_model.Checked = true;
            this.cb_model.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_model.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_model.Location = new System.Drawing.Point(13, 51);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(66, 19);
            this.cb_model.TabIndex = 4;
            this.cb_model.Text = "Model";
            this.cb_model.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(179, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 42);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(627, 532);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbProjectId);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("SimSun", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProjectId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tb_view;
        private System.Windows.Forms.TextBox tb_component;
        private System.Windows.Forms.CheckBox cb_view;
        private System.Windows.Forms.CheckBox cb_component;
        private System.Windows.Forms.CheckBox cb_module;
        private System.Windows.Forms.CheckBox cb_presenter;
        private System.Windows.Forms.CheckBox cb_contract;
        private System.Windows.Forms.CheckBox cb_model;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnComponent;
        private System.Windows.Forms.Button btnModule;
        private System.Windows.Forms.Button btnPresenter;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.CheckBox cb_fragment;
        private System.Windows.Forms.Button btn_fragment;
        private System.Windows.Forms.TextBox tb_fragment;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.Button btn_layout;
        private System.Windows.Forms.TextBox tb_layout;
        private System.Windows.Forms.CheckBox cb_layout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox tb_module;
        protected System.Windows.Forms.TextBox tb_presenter;
        public System.Windows.Forms.TextBox tb_contract;
        protected System.Windows.Forms.TextBox tb_model;
    }
}