using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ATM
{
    public partial class Settings : Form
    {
        private Main a = null;
        string configFile = Path.Combine(AppContext.BaseDirectory, Application.ProductName + ".txt");
        string id = "";
        public Settings()
        {
            InitializeComponent();
            this.a = new Main();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            String[] str = File.ReadAllLines(configFile);
            tbName.Text=str[1].Substring(10);
            tbProjectId.Text=str[2].Substring(13);
            lblPath.Text = str[4].Substring(13);
            tb_contract.Text = str[5].Substring(14);
            tb_model.Text= str[6].Substring(11);
            tb_presenter.Text= str[7].Substring(15);
            tb_module.Text= str[8].Substring(12);
            tb_component.Text= str[9].Substring(15);
           tb_view.Text= str[10].Substring(14);
            tb_fragment.Text= str[11].Substring(14);
            tb_layout.Text= str[12].Substring(12);
                
            //
            if (str[13]=="auto:true")
            {
                cbAuto.Checked=true;
            }
            else
            {
                cbAuto.Checked=false;
            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            a.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择项目根目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    lblPath.Text = dialog.SelectedPath;
                    String[] str = File.ReadAllLines(configFile);
                    str[4] = "package path:" + dialog.SelectedPath;
                    File.WriteAllLines(configFile, str);

                    //对应目录
                    if (cb_contract.Checked)
                    {
                       tb_contract.Text = dialog.SelectedPath + @"\app\src\main\java\"+id.Replace(".",@"\")+@"\mvp\contract";
                    }

                    if (cb_model.Checked)
                    {
                        tb_model.Text = dialog.SelectedPath + @"\app\src\main\java\" + id.Replace(".", @"\") + @"\mvp\model";
                    }

                    if (cb_presenter.Checked)
                    {
                        tb_presenter.Text= dialog.SelectedPath + @"\app\src\main\java\" + id.Replace(".", @"\") + @"\mvp\presenter";
                    }

                    if (cb_module.Checked)
                    {
                        tb_module.Text= dialog.SelectedPath + @"\app\src\main\java\" + id.Replace(".", @"\") + @"\di\module";
                    }

                    if (cb_component.Checked)
                    {
                        tb_component.Text= dialog.SelectedPath + @"\app\src\main\java\" + id.Replace(".", @"\") + @"\di\component";
                    }

                    if (cb_view.Checked)
                    {
                        tb_view.Text= dialog.SelectedPath + @"\app\src\main\java\" + id.Replace(".", @"\") + @"\mvp\ui\activity";
                    }

                    if (cb_fragment.Checked)
                    {
                        tb_fragment.Text= dialog.SelectedPath + @"\app\src\main\java\" + id.Replace(".", @"\") + @"\ui\fragment";
                    }

                    if (cb_layout.Checked)
                    {
                        tb_layout.Text= dialog.SelectedPath + @"\app\src\main\res\layout";
                    }
                   
                }

            }
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Model生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_model.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Contract生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_contract.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnPresenter_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Presenter生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_presenter.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnModule_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Module生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_module.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnComponent_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Component生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_component.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Activity生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_view.Text = dialog.SelectedPath;
                }
            }
        }

        private void btn_fragment_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Fragment生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_fragment.Text = dialog.SelectedPath;
                }
            }
        }

        private void btn_layout_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Layout生成目录";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_layout.Text = dialog.SelectedPath;
                }
            }
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
      
        }

        private void tbProjectId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbProjectId_Leave(object sender, EventArgs e)
        {
            id = tbProjectId.Text;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String[] str = File.ReadAllLines(configFile);
            str[1] ="user name:"+ tbName.Text;
            str[2] = "package name:" + tbProjectId.Text;
            str[4] = "package path:"+lblPath.Text;
            str[5] = "contract path:"+tb_contract.Text;
            str[6] = "model path:" +tb_model.Text;
            str[7] = "presenter path："+tb_presenter.Text;
            str[8] = "module path:"+tb_module.Text;
            str[9] = "component path:"+tb_component.Text;
            str[10] = "activity path:"+tb_view.Text;
            str[11] = "fragment path:"+tb_fragment.Text;
            str[12] = "layout path:"+tb_layout.Text;
            //
            if (cbAuto.Checked)
            {
                str[13] = "auto:true";
            }
            else
            {
                str[13] = "auto:false";
            }

            File.WriteAllLines(configFile, str);
            MessageBox.Show("保存成功！", "Arm工具", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
