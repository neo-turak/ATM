
namespace ATM
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tb_pageName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_packageName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_layout = new System.Windows.Forms.TextBox();
            this.tb_component = new System.Windows.Forms.TextBox();
            this.tb_module = new System.Windows.Forms.TextBox();
            this.tb_presenter = new System.Windows.Forms.TextBox();
            this.tb_view = new System.Windows.Forms.TextBox();
            this.tb_model = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_kotlin = new System.Windows.Forms.RadioButton();
            this.rb_java = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_fragment = new System.Windows.Forms.RadioButton();
            this.rb_activity = new System.Windows.Forms.RadioButton();
            this.cb_layout = new System.Windows.Forms.CheckBox();
            this.cb_component = new System.Windows.Forms.CheckBox();
            this.cb_module = new System.Windows.Forms.CheckBox();
            this.cb_presenter = new System.Windows.Forms.CheckBox();
            this.cb_view = new System.Windows.Forms.CheckBox();
            this.cb_model = new System.Windows.Forms.CheckBox();
            this.btn_pickPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIsettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI皮肤 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi环境 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIexit = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反馈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_pageName
            // 
            this.tb_pageName.Location = new System.Drawing.Point(76, 33);
            this.tb_pageName.Name = "tb_pageName";
            this.tb_pageName.Size = new System.Drawing.Size(255, 24);
            this.tb_pageName.TabIndex = 0;
            this.tb_pageName.TextChanged += new System.EventHandler(this.tb_pageName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "页      名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "包       名";
            // 
            // tb_packageName
            // 
            this.tb_packageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_packageName.Location = new System.Drawing.Point(76, 64);
            this.tb_packageName.Name = "tb_packageName";
            this.tb_packageName.Size = new System.Drawing.Size(427, 22);
            this.tb_packageName.TabIndex = 1;
            this.tb_packageName.Leave += new System.EventHandler(this.tb_packageName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "生成目录";
            // 
            // tb_path
            // 
            this.tb_path.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_path.Location = new System.Drawing.Point(76, 98);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(339, 22);
            this.tb_path.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.tb_layout);
            this.groupBox1.Controls.Add(this.tb_component);
            this.groupBox1.Controls.Add(this.tb_module);
            this.groupBox1.Controls.Add(this.tb_presenter);
            this.groupBox1.Controls.Add(this.tb_view);
            this.groupBox1.Controls.Add(this.tb_model);
            this.groupBox1.Controls.Add(this.btn_generate);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cb_layout);
            this.groupBox1.Controls.Add(this.cb_component);
            this.groupBox1.Controls.Add(this.cb_module);
            this.groupBox1.Controls.Add(this.cb_presenter);
            this.groupBox1.Controls.Add(this.cb_view);
            this.groupBox1.Controls.Add(this.cb_model);
            this.groupBox1.Location = new System.Drawing.Point(20, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 338);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // tb_layout
            // 
            this.tb_layout.Location = new System.Drawing.Point(136, 169);
            this.tb_layout.Name = "tb_layout";
            this.tb_layout.Size = new System.Drawing.Size(426, 24);
            this.tb_layout.TabIndex = 15;
            // 
            // tb_component
            // 
            this.tb_component.Location = new System.Drawing.Point(136, 140);
            this.tb_component.Name = "tb_component";
            this.tb_component.Size = new System.Drawing.Size(426, 24);
            this.tb_component.TabIndex = 14;
            // 
            // tb_module
            // 
            this.tb_module.Location = new System.Drawing.Point(137, 110);
            this.tb_module.Name = "tb_module";
            this.tb_module.Size = new System.Drawing.Size(425, 24);
            this.tb_module.TabIndex = 13;
            // 
            // tb_presenter
            // 
            this.tb_presenter.Location = new System.Drawing.Point(138, 80);
            this.tb_presenter.Name = "tb_presenter";
            this.tb_presenter.Size = new System.Drawing.Size(424, 24);
            this.tb_presenter.TabIndex = 12;
            // 
            // tb_view
            // 
            this.tb_view.Location = new System.Drawing.Point(138, 50);
            this.tb_view.Name = "tb_view";
            this.tb_view.Size = new System.Drawing.Size(424, 24);
            this.tb_view.TabIndex = 11;
            // 
            // tb_model
            // 
            this.tb_model.Location = new System.Drawing.Point(138, 21);
            this.tb_model.Name = "tb_model";
            this.tb_model.Size = new System.Drawing.Size(424, 24);
            this.tb_model.TabIndex = 10;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(234, 279);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(102, 41);
            this.btn_generate.TabIndex = 18;
            this.btn_generate.Text = "生成";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_kotlin);
            this.groupBox3.Controls.Add(this.rb_java);
            this.groupBox3.Location = new System.Drawing.Point(290, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "语言";
            // 
            // rb_kotlin
            // 
            this.rb_kotlin.AutoSize = true;
            this.rb_kotlin.Checked = true;
            this.rb_kotlin.Location = new System.Drawing.Point(176, 28);
            this.rb_kotlin.Name = "rb_kotlin";
            this.rb_kotlin.Size = new System.Drawing.Size(63, 22);
            this.rb_kotlin.TabIndex = 17;
            this.rb_kotlin.TabStop = true;
            this.rb_kotlin.Text = "Kotlin";
            this.rb_kotlin.UseVisualStyleBackColor = true;
            this.rb_kotlin.CheckedChanged += new System.EventHandler(this.rb_kotlin_CheckedChanged);
            // 
            // rb_java
            // 
            this.rb_java.AutoSize = true;
            this.rb_java.BackColor = System.Drawing.Color.Transparent;
            this.rb_java.Location = new System.Drawing.Point(24, 28);
            this.rb_java.Name = "rb_java";
            this.rb_java.Size = new System.Drawing.Size(57, 22);
            this.rb_java.TabIndex = 16;
            this.rb_java.TabStop = true;
            this.rb_java.Text = "Java";
            this.rb_java.UseVisualStyleBackColor = false;
            this.rb_java.CheckedChanged += new System.EventHandler(this.rb_java_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_fragment);
            this.groupBox2.Controls.Add(this.rb_activity);
            this.groupBox2.Location = new System.Drawing.Point(8, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "类型";
            // 
            // rb_fragment
            // 
            this.rb_fragment.AutoSize = true;
            this.rb_fragment.Location = new System.Drawing.Point(154, 23);
            this.rb_fragment.Name = "rb_fragment";
            this.rb_fragment.Size = new System.Drawing.Size(89, 22);
            this.rb_fragment.TabIndex = 1;
            this.rb_fragment.Text = "Fragment";
            this.rb_fragment.UseVisualStyleBackColor = true;
            // 
            // rb_activity
            // 
            this.rb_activity.AutoSize = true;
            this.rb_activity.Checked = true;
            this.rb_activity.Location = new System.Drawing.Point(24, 23);
            this.rb_activity.Name = "rb_activity";
            this.rb_activity.Size = new System.Drawing.Size(71, 22);
            this.rb_activity.TabIndex = 0;
            this.rb_activity.TabStop = true;
            this.rb_activity.Text = "Activity";
            this.rb_activity.UseVisualStyleBackColor = true;
            this.rb_activity.CheckedChanged += new System.EventHandler(this.rb_activity_CheckedChanged);
            // 
            // cb_layout
            // 
            this.cb_layout.AutoSize = true;
            this.cb_layout.Checked = true;
            this.cb_layout.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_layout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_layout.Location = new System.Drawing.Point(15, 169);
            this.cb_layout.Name = "cb_layout";
            this.cb_layout.Size = new System.Drawing.Size(71, 22);
            this.cb_layout.TabIndex = 9;
            this.cb_layout.Text = "Layout";
            this.cb_layout.UseVisualStyleBackColor = true;
            // 
            // cb_component
            // 
            this.cb_component.AutoSize = true;
            this.cb_component.Checked = true;
            this.cb_component.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_component.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_component.Location = new System.Drawing.Point(14, 142);
            this.cb_component.Name = "cb_component";
            this.cb_component.Size = new System.Drawing.Size(105, 22);
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
            this.cb_module.Size = new System.Drawing.Size(76, 22);
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
            this.cb_presenter.Location = new System.Drawing.Point(12, 80);
            this.cb_presenter.Name = "cb_presenter";
            this.cb_presenter.Size = new System.Drawing.Size(91, 22);
            this.cb_presenter.TabIndex = 6;
            this.cb_presenter.Text = "Presenter";
            this.cb_presenter.UseVisualStyleBackColor = true;
            // 
            // cb_view
            // 
            this.cb_view.AutoSize = true;
            this.cb_view.Checked = true;
            this.cb_view.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_view.Location = new System.Drawing.Point(12, 51);
            this.cb_view.Name = "cb_view";
            this.cb_view.Size = new System.Drawing.Size(58, 22);
            this.cb_view.TabIndex = 5;
            this.cb_view.Text = "View";
            this.cb_view.UseVisualStyleBackColor = true;
            // 
            // cb_model
            // 
            this.cb_model.AutoSize = true;
            this.cb_model.Checked = true;
            this.cb_model.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_model.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_model.Location = new System.Drawing.Point(12, 22);
            this.cb_model.Name = "cb_model";
            this.cb_model.Size = new System.Drawing.Size(68, 22);
            this.cb_model.TabIndex = 4;
            this.cb_model.Text = "Model";
            this.cb_model.UseVisualStyleBackColor = true;
            // 
            // btn_pickPath
            // 
            this.btn_pickPath.Location = new System.Drawing.Point(424, 92);
            this.btn_pickPath.Name = "btn_pickPath";
            this.btn_pickPath.Size = new System.Drawing.Size(79, 34);
            this.btn_pickPath.TabIndex = 3;
            this.btn_pickPath.Text = "选择目录";
            this.btn_pickPath.UseVisualStyleBackColor = true;
            this.btn_pickPath.Click += new System.EventHandler(this.btn_pickPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(179, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "版权：北京 思无界有限责任公司";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(247, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "V 1.0.6";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIsettings,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIsettings
            // 
            this.TSMIsettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI皮肤,
            this.tsmi环境,
            this.TSMIexit});
            this.TSMIsettings.Name = "TSMIsettings";
            this.TSMIsettings.Size = new System.Drawing.Size(59, 20);
            this.TSMIsettings.Text = "设置(&S)";
            // 
            // TSMI皮肤
            // 
            this.TSMI皮肤.Name = "TSMI皮肤";
            this.TSMI皮肤.Size = new System.Drawing.Size(180, 22);
            this.TSMI皮肤.Text = "皮肤";
            // 
            // tsmi环境
            // 
            this.tsmi环境.Name = "tsmi环境";
            this.tsmi环境.Size = new System.Drawing.Size(180, 22);
            this.tsmi环境.Text = "环境配置";
            this.tsmi环境.Click += new System.EventHandler(this.tsmi环境_Click);
            // 
            // TSMIexit
            // 
            this.TSMIexit.Name = "TSMIexit";
            this.TSMIexit.Size = new System.Drawing.Size(180, 22);
            this.TSMIexit.Text = "退出(&X)";
            this.TSMIexit.Click += new System.EventHandler(this.TSMIexit_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.反馈ToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 反馈ToolStripMenuItem
            // 
            this.反馈ToolStripMenuItem.Name = "反馈ToolStripMenuItem";
            this.反馈ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.反馈ToolStripMenuItem.Text = "反馈";
            this.反馈ToolStripMenuItem.Click += new System.EventHandler(this.反馈ToolStripMenuItem_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(344, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "清除";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(509, 92);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(79, 34);
            this.btnOpen.TabIndex = 12;
            this.btnOpen.Text = "打开目录";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(604, 530);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_pickPath);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.tb_packageName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pageName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARM 模板助手";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.atm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_pageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_packageName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_layout;
        private System.Windows.Forms.CheckBox cb_component;
        private System.Windows.Forms.CheckBox cb_module;
        private System.Windows.Forms.CheckBox cb_presenter;
        private System.Windows.Forms.CheckBox cb_view;
        private System.Windows.Forms.CheckBox cb_model;
        private System.Windows.Forms.TextBox tb_layout;
        private System.Windows.Forms.TextBox tb_component;
        private System.Windows.Forms.TextBox tb_module;
        private System.Windows.Forms.TextBox tb_presenter;
        private System.Windows.Forms.TextBox tb_view;
        private System.Windows.Forms.TextBox tb_model;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_kotlin;
        private System.Windows.Forms.RadioButton rb_java;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_fragment;
        private System.Windows.Forms.RadioButton rb_activity;
        private System.Windows.Forms.Button btn_pickPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIsettings;
        private System.Windows.Forms.ToolStripMenuItem TSMI皮肤;
        private System.Windows.Forms.ToolStripMenuItem tsmi环境;
        private System.Windows.Forms.ToolStripMenuItem TSMIexit;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反馈ToolStripMenuItem;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
    }
}

