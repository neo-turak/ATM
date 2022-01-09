using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SkinSharp;
namespace ATM
{
    public partial class Main : Form
    {
        public String name = "";
        public String layoutName = "";
        public String path = "";
        public SkinH_Net skinH;
        string configFile = Path.Combine(AppContext.BaseDirectory, Application.ProductName + ".txt");
        public Main()
        {
            skinH = new SkinH_Net();
            //  skinH.AttachEx(AppContext.BaseDirectory + "/skins/0002.she", null);
            InitializeComponent();

        }

        private void atm_Load(object sender, EventArgs e)
        {
            tb_path.Text = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
            this.skinLists();
            CreateFile();
        }

        private void btn_pickPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择保存文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    tb_path.Text = dialog.SelectedPath;
                    if (File.Exists(configFile))
                    {
                        String[] lines = File.ReadAllLines(configFile);
                        lines[3] = "export path:" + dialog.SelectedPath;
                        File.WriteAllLines(configFile, lines);
                    }
                }
                //this.LoadingText = "处理中...";
                //this.LoadingDisplay = true;
                //Action<string> a = DaoRuData;
                //a.BeginInvoke(dialog.SelectedPath, asyncCallback, a);
            }
        }

        private void tb_pageName_TextChanged(object sender, EventArgs e)
        {
            name = this.tb_pageName.Text.Replace("Activity", "");

            if (rb_activity.Checked)
            {
                this.layoutName = "activity";
            }

            if (rb_fragment.Checked)
            {
                this.layoutName = "fragment";
            }

            Char[] a = name.ToCharArray();
            foreach (Char c in a)
            {

                if (Char.IsUpper(c))
                {
                    this.layoutName += "_" + Char.ToLower(c).ToString();
                }
                else
                {
                    this.layoutName += c.ToString();
                }
            }

            tb_layout.Text = this.layoutName + ".xml";
            tb_model.Text = tb_pageName.Text + "Model.kt";
            tb_component.Text = tb_pageName.Text + "Component.kt";
            tb_presenter.Text = tb_pageName.Text + "Presenter.kt";
            tb_module.Text = tb_pageName.Text + "Module.kt";
            tb_view.Text = tb_pageName.Text + "Contract.kt";
        }

        private void rb_activity_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_activity.Checked)
            {
                this.tb_layout.Text = this.tb_layout.Text.Replace("fragment", "activity");
            }
            else
            {
                this.tb_layout.Text = this.tb_layout.Text.Replace("activity", "fragment");
            }
        }

        public void createFile(String fileName, String content)
        {
            FileStream s;
            if (fileName.EndsWith("\\"))
            {
                s = new FileStream(tb_path.Text + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            else
            {
                s = new FileStream(tb_path.Text + "\\" + fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            }
            StreamWriter sw = new StreamWriter(s);
            sw.Write(content);
            sw.Flush();
            sw.Close();
            s.Close();
        }

        public String GenerateKModel(String type)

        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n";
            module += 
                        "import com.jess.arms.di.scope."+type +"Scope\n"+
                        "import com.jess.arms.integration.IRepositoryManager\n" +
                        "import com.jess.arms.mvp.BaseModel\n" +
                        "import javax.inject.Inject\n\n" +
                        "@"+type +"Scope\n" +
                        "class " + tb_pageName.Text + "Model\n" +
                        "@Inject\n" +
                        "constructor(repositoryManager: IRepositoryManager) : BaseModel(repositoryManager)," + tb_pageName.Text + "Contract.Model{\n" +
               " }\n";

            return module;
        }

   
        public String GenerateKContract()
        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n";
            module += "import com.jess.arms.mvp.IModel\n" +
                      "import com.jess.arms.mvp.IView\n\n" +
                      "interface " + tb_pageName.Text + "Contract {\n" +
                    " interface View : IView\n" +
                    "interface Model : IModel\n" +
                        "}";
            return module;
        }

        public String GenerateKPresenter(String type)
        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n";
            module +="import com.jess.arms.di.scope." + type +"Scope\n"+
                    "import com.jess.arms.mvp.BasePresenter\n" +
                    "import me.jessyan.rxerrorhandler.core.RxErrorHandler\n" +
                    "import javax.inject.Inject\n\n\n" +
                    "@"+type +"Scope\n"+
                    "class " + tb_pageName.Text + "Presenter\n @Inject\n" +
                    "constructor(model: " + tb_pageName.Text + "Contract.Model, rootView: " + tb_pageName.Text + "Contract.View) :\n" +
                    "BasePresenter<" + tb_pageName.Text + "Contract.Model, " + tb_pageName.Text + "Contract.View>(model, rootView) {\n" +
                    "@Inject\n lateinit var mErrorHandler: RxErrorHandler\n\n" +
                    "}";
            return module;
        }

        public String GenerateKModule(String type)
        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n";
            module += "import com.jess.arms.di.scope."+type +"Scope\n"+
                    "import dagger.Module\n" +
                    "import dagger.Provides\n\n\n" +
                    "class " + tb_pageName.Text + "Module(private val view:" + tb_pageName.Text + "Contract.View) {\n" +
                    "@"+type+"Scope\n"+
                    "@Provides\n" +
                    "fun provide" + tb_pageName.Text + "View():" + tb_pageName.Text + "Contract.View{\n" +
                    "     return this.view\n}\n\n" +
                    "@" + type + "Scope\n" +
                    "@Provides\n" +
                    "fun provide" + tb_pageName.Text + "Model(model:" + tb_pageName.Text + "Model):" + tb_pageName.Text + "Contract.Model{\n" +
                    "return model\n" +
                    "}\n}";
            return module;
        }

        public String GenerateKComponent(String type)
        {
            String package = tb_packageName.Text;
            String module = "package  " + package + "\n";
            module += "import com.jess.arms.di.component.AppComponent\n" +
                "import com.jess.arms.di.scope."+type +"Scope\n"+
                "import dagger.Component\n\n" +
                "@"+type + "Scope\n" +
                "@Component(modules = [" + tb_pageName.Text + "Module::class],dependencies = [AppComponent::class])\n" +
                "interface " + tb_pageName.Text + "Component{\n" +
                "    fun inject(activity:" + tb_pageName.Text + type + ")\n" +
                "}";
            return module;
        }

        public String GenerateLayout()
        {
            String module = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
   "<androidx.constraintlayout.widget.ConstraintLayout\n" +
        "        xmlns:android=\"http://schemas.android.com/apk/res/android\"\n" +
        "        xmlns:app=\"http://schemas.android.com/apk/res-auto\"\n" +
        "        xmlns:tools=\"http://schemas.android.com/tools\"\n"+
        "        android:layout_width=\"match_parent\"\n" +
        "        android:layout_height=\"match_parent\">\n\n\n\n" +
        "</androidx.constraintlayout.widget.ConstraintLayout>\n";
            return module;
        }

        public String GenerateKActivity()
        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n\n" +
            "import android.content.Intent\n" +
            "import android.os.Bundle\n" +
            "import com.jess.arms.base.BaseActivity\n" +
            "import com.jess.arms.di.component.AppComponent\n" +
            "import com.jess.arms.utils.ArmsUtils\n\n" +
            "//TODO 请自行声明到Manifest里\n" +
            "class " + tb_pageName.Text + "Activity : BaseActivity<" + tb_pageName.Text + "Presenter>() , " + tb_pageName.Text + "Contract.View {\n\n" +
            "    override fun setupActivityComponent(appComponent:AppComponent) {\n" +
            " Dagger" + tb_pageName.Text + "Component //如找不到该类,请编译一下项目\n" +
            "                .builder()\n" +
            "                .appComponent(appComponent)\n" +
            "                ." + tb_pageName.Text.ToString().Substring(0, 1).ToLower() + tb_pageName.Text.Substring(1, tb_pageName.Text.Length - 1) + "Module(" + tb_pageName.Text + "Module(this))\n" +
            "                .build()\n" +
            "                .inject(this)\n" +
            "    }\n\n" +
            "    override fun initView(savedInstanceState:Bundle?):Int {\n" +
            "              return R.layout." + tb_layout.Text.Replace(".xml", "") + " //如果你不需要框架帮你设置 setContentView(id) 需要自行设置,请返回 0\n" +
            "}\n\n\n\n" +
            "    override fun initData(savedInstanceState:Bundle?) {\n" +
            "\n\n}\n" +
            "    override fun showLoading() {\n\n }\n\n       override fun hideLoading(){\n\n}\n" +
            "    override fun showMessage(message:String) {\n" +
            "        ArmsUtils.snackbarText(message)\n}\n" +
            "    override fun launchActivity(intent:Intent) {\n" +
            "        ArmsUtils.startActivity(intent)\n}\n" +
            "    override fun killMyself() {\n" +
            "        finish()\n}\n}\n";
            return module;
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            //activity
            if (rb_activity.Checked)
            {
                //语言：Java
                if (rb_java.Checked)
                {
                    createFile(tb_model.Text, GenerateJModel());
                    createFile(tb_layout.Text, GenerateLayout());
                    createFile(tb_component.Text, GenerateJComponent());
                    createFile(tb_module.Text, GenerateJModule());
                    createFile(tb_presenter.Text, GenerateJPresenter());
                    createFile(tb_view.Text, GenerateJContract());
                    createFile(tb_pageName.Text + "Activity.java", GenerateJActivity());
                }
                //语言：Kotlin
                else
                {
                    createFile(tb_model.Text, GenerateKModel("Activity"));
                    createFile(tb_layout.Text, GenerateLayout());
                    createFile(tb_component.Text, GenerateKComponent("Activity"));
                    createFile(tb_module.Text, GenerateKModule("Activity"));
                    createFile(tb_presenter.Text, GenerateKPresenter("Activity"));
                    createFile(tb_view.Text, GenerateKContract());
                    createFile(tb_pageName.Text + "Activity.kt", GenerateKActivity());
                }

            }
            //Fragment
            if (rb_fragment.Checked)
            {
                //语言Kotlin
                if (rb_kotlin.Checked)
                {
                    createFile(tb_model.Text, GenerateKModel("Fragment"));
                    createFile(tb_layout.Text, GenerateLayout());
                    createFile(tb_component.Text, GenerateKComponent("Fragment"));
                    createFile(tb_module.Text, GenerateKModule("Fragment"));
                    createFile(tb_presenter.Text, GenerateKPresenter("Fragment"));
                    createFile(tb_view.Text, GenerateKContract());
                    createFile(tb_pageName.Text + "Fragment.kt", GenerateKFragment());
                }
                else
                {
                    //语言Java
                    createFile(tb_model.Text, GenerateJModel());
                    createFile(tb_layout.Text, GenerateLayout());
                    createFile(tb_component.Text, GenerateJComponent());
                    createFile(tb_module.Text, GenerateJModule());
                    createFile(tb_presenter.Text, GenerateJPresenter());
                    createFile(tb_view.Text, GenerateJContract());
                    //TODO 要生成JFragment
                    //     createFile(tb_pageName.Text + "Fragment.java", GenerateJFragment());
                }

            }

            MessageBox.Show("创建成功！", "Arm工具", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public String GenerateJActivity()
        {
            String package = tb_packageName.Text.ToString();
            String module = "package " + package + ";" + "\n\n" +
                "import android.content.Intent;\n" +
"import android.os.Bundle;\n" +
"import android.support.annotation.NonNull;\n" +
"import android.support.annotation.Nullable;\n" +
"import com.jess.arms.base.BaseActivity;\n" +
"import com.jess.arms.di.component.AppComponent;\n" +
"import com.jess.arms.utils.ArmsUtils;\n" +
"import " + tb_packageName + ".Dagger" + tb_pageName.Text.ToString() + "Component;\n" +
"import " + tb_packageName + "." + tb_pageName.Text.ToString() + "Contract;\n" +
"import " + tb_packageName + "." + tb_pageName.Text.ToString() + "Presenter;\n" +
"import " + tb_packageName + "." + "R;\n" +
"import static com.jess.arms.utils.Preconditions.checkNotNull;\n\n" +
"public class " + tb_pageName.Text.ToString() + "Activity extends BaseActivity<" + tb_pageName.Text.ToString() +
"Presenter> implements " + tb_pageName.Text.ToString() + "Contract.View {\n\n" +

"@Override\n\n" +
"public void setupActivityComponent(@NonNull AppComponent appComponent) {\n" +
"Dagger" + tb_pageName.Text.ToString() + "Component//如找不到该类，请编译一下项目" +
"           .builder()\n" +
"           .appComponent(appComponent)\n" +
"           .view(this)\n" +
"           .build()\n" +
"           .inject(this)\n" +
"}\n\n" +

"@Override\n" +
"public int initView(@Nullable Bundle savedInstanceState) {\n" +
 "          return R.layout." + tb_layout.Text.Replace(".xml", "") + "; //如果你不需要框架帮你设置 setContentView(id) 需要自行设置,请返回 0\n" +
 "}\n\n" +

"    @Override\n" +
"    public void initData(@Nullable Bundle savedInstanceState)\n\n" +
"            {\n\n" +
"   @Override\n" +
"    public void showLoading()\n" +
"           {           \n }\n\n" +
"  @Override\n" +
"    public void hideLoading()\n{\n\n}\n\n" +
"    @Override\n" +
"    public void showMessage(@NonNull String message)\n" +
"            {\n" +
"                checkNotNull(message);\n" +
"                ArmsUtils.snackbarText(message);\n" +
"            }\n\n" +
"            @Override\n" +
"    public void launchActivity(@NonNull Intent intent)\n" +
"            {\n" +
"                checkNotNull(intent);\n" +
"                ArmsUtils.startActivity(intent);\n" +
"           }\n\n" +

"            @Override\n" +
"    public void killMyself()\n" +
"            {\n" +
"                finish();\n" +
"            }\n" +
"            }\n";
            return module;
        }

        public String GenerateJComponent()
        {
            String package = tb_packageName.Text.ToString();
            String module = "package " + package + ";" + "\n\n" +
"import dagger.BindsInstance;\n" +
"import dagger.Component;\n" +
"import com.jess.arms.di.component.AppComponent;\n" +
"import " + package + "." + tb_pageName + "Module;\n" +
"import " + package + "." + tb_pageName + "Contract;\n" +

"import com.jess.arms.di.scope.ActivityScope;\n" +
"import " + package + "." + tb_pageName + "Activity;\n" +

"@ActivityScope\n" +
"@Component(modules = MeetingMeModule.class, dependencies = AppComponent.class)\n" +
"public interface MeetingMeComponent" +
"        {\n" +
 "   void inject(MeetingMeActivity activity);\n" +
 "   @Component.Builder\n" +
  "  interface Builder" +
  "          {\n" +
  "      @BindsInstance\n" +
  "      MeetingMeComponent.Builder view(MeetingMeContract.View view);\n" +
  "      MeetingMeComponent.Builder appComponent(AppComponent appComponent);\n" +
  "      MeetingMeComponent build();\n" +
  "         }\n" +
  "}";
            return module;
        }

        public String GenerateJContract()
        {
            String package = tb_packageName.Text.ToString();
            String module = "package " + package + ";\n" +
"import com.jess.arms.mvp.IView;\n" +
"import com.jess.arms.mvp.IModel;\n" +

"public interface " + tb_pageName.Text.ToString() + "Contract{\n" +
"    //对于经常使用的关于UI的方法可以定义到IView中,如显示隐藏进度条,和显示文字消息\n" +
 "   interface View extends IView{\n" +

 "   }\n" +
 "   //Model层定义接口,外部只需关心Model返回的数据,无需关心内部细节,即是否使用缓存\n" +
 "   interface Model extends IModel" +
 "           {\n" +

"    }\n" +
"}\n";
            return module;
        }

        public String GenerateJModel()
        {
            String package = tb_packageName.Text.ToString();
            String module = "package " + package + ";\n\n" +
"import android.app.Application;\n" +
"import com.google.gson.Gson;\n" +
"import com.jess.arms.integration.IRepositoryManager;\n" +
"import com.jess.arms.mvp.BaseModel;\n" +
"import com.jess.arms.di.scope.ActivityScope;\n" +
"import javax.inject.Inject;\n" +
"import " + package + "." + tb_pageName.Text + "Contract;\n\n\n" +
"@ActivityScope\n" +
"public class " + tb_pageName.Text + "Model extends BaseModel implements " + tb_pageName.Text + "Contract.Model{\n" +
"    @Inject\n" +
"    Gson mGson;\n" +
"    @Inject\n" +
"    Application mApplication;\n\n" +
"    @Inject\n" +
"    public " + tb_pageName.Text + "+Model(IRepositoryManager repositoryManager) {\n" +
"        super(repositoryManager);\n" +
"}\n\n" +
"    @Override\n" +
"    public void onDestroy() {\n" +
"        super.onDestroy();{\n" +
"        this.mGson = null;\n" +
"        this.mApplication = null;\n    }\n}";

            return module;
        }

        public String GenerateJModule()
        {
            String package = tb_packageName.Text.ToString();
            String module = "package " + package + ";\n\n" +
"import com.jess.arms.di.scope.ActivityScope;\n" +
"import dagger.Binds;\nimport dagger.Module;\nimport dagger.Provides;\n\n" +
"import " + package + "." + tb_pageName.Text + "Contract;\n" +
"import " + package + "." + tb_pageName.Text + "Model;\n\n\n" +
"@Module\n\n" +
"public abstract class " + tb_pageName.Text + "Module {\n\n" +
"    @Binds\n" +
"    abstract " + tb_pageName.Text + "Contract.Model bind" + tb_pageName.Text + "Model(" + tb_pageName.Text + "Model model);\n}";
            return module;
        }

        public String GenerateJPresenter()
        {
            String package = tb_packageName.Text.ToString();
            String module = "package " + package + ";\n\n" +
"import android.app.Application;\n" +
"import com.jess.arms.di.scope.ActivityScope;\n" +
"import com.jess.arms.http.imageloader.ImageLoader;\n" +
"import com.jess.arms.integration.AppManager;\n" +
"import com.jess.arms.mvp.BasePresenter;\n" +
"import javax.inject.Inject;\n" +
"import me.jessyan.rxerrorhandler.core.RxErrorHandler;\n" +
"@ActivityScope\n" +
"public class " + tb_pageName.Text + "Presenter extends BasePresenter<" + tb_pageName.Text + "Contract.Model, " + tb_pageName.Text
+ "Contract.View> {\n" +
"    @Inject\n" +
"    RxErrorHandler mErrorHandler;\n" +
"    @Inject\n" +
"   Application mApplication;\n" +
"    @Inject\n" +
"    ImageLoader mImageLoader;\n" +
"    @Inject\n" +
"    AppManager mAppManager;\n\n" +
"    @Inject\n" +
"   public " + tb_pageName.Text + "Presenter (" + tb_pageName.Text + "Contract.Model model," + tb_pageName.Text + "Contract.View rootView) {\n" +
"        super(model, rootView);" +
"   }\n\n" +
"    @Override\n" +
"    public void onDestroy() {\n" +
"        super.onDestroy();\n" +
"        this.mErrorHandler = null;\n" +
"        this.mAppManager = null;\n" +
"        this.mImageLoader = null;\n" +
"        this.mApplication = null;\n" +
"    }\n\n}";
            return module;
        }

        public String GenerateKFragment()
        {
            String package = tb_packageName.Text.ToString();
            String module = 
"package " + package + "\n\n" +
"import android.content.Intent\n" +
"import android.os.Bundle\n" +
"import android.os.Message\n" +
"import android.view.LayoutInflater\n" +
"import android.view.View\n" +
"import android.view.ViewGroup\n" +
"import com.jess.arms.base.BaseFragment\n" +
"import com.jess.arms.di.component.AppComponent\n" +
"import com.jess.arms.utils.ArmsUtils\n" +
"import " + package + ".Dagger" + tb_pageName.Text.ToString() + "Component\n" +
"import " + package + "." + tb_pageName.Text.ToString() + "Module\n" +
"import " + package + "." + tb_pageName.Text.ToString() + "Contract\n" +
"import " + package + "." + tb_pageName.Text.ToString() + "Presenter\n\n" +
"import " + package + ".R\n\n\n\n" +


"class " + tb_pageName.Text.ToString() + "Fragment : BaseFragment<" + tb_pageName.Text.ToString() + "Presenter>() , " + tb_pageName.Text.ToString() + "Contract.View{\n" +
"   companion object {\n" +
"   fun newInstance():" + tb_pageName.Text.ToString() + "Fragment {\n" +
"   val fragment = " + tb_pageName.Text.ToString() + "Fragment()\n" +
"   return fragment\n" +
"}\n}\n\n\n" +
"   override fun setupFragmentComponent(appComponent:AppComponent) {\n" +
"       Dagger" + tb_pageName.Text.ToString() + "Component//需要编译\n" +
"                .builder()\n                .appComponent(appComponent)\n" +
"                ." + tb_pageName.Text.Substring(0, 1).ToLower() + tb_pageName.Text.Substring(1, tb_pageName.Text.Length - 1) + "Module(" + tb_pageName.Text + "Module(this))\n" +
"                .build()\n                .inject(this)\n}\n" +
" override fun initView(inflater: LayoutInflater, container: ViewGroup?, savedInstanceState: Bundle?):View{\n" +
"                 return inflater.inflate(R.layout." + tb_layout.Text.Replace("activity", "fragment").Replace(".xml", "") + ",container, false)\n" +
"}\n\n" +
"override fun initData(savedInstanceState:Bundle?) {\n\n}\n" +
"   override fun setData(data:Any?) {\n" +
" }\n" +
"override fun showLoading(){\n\n}\n" +
"override fun hideLoading(){\n\n}\n" +
"override fun showMessage(message:String) {\n" +
"     ArmsUtils.snackbarText(message)\n}\n\n" +
"override fun launchActivity(intent:Intent) {\n" +
"      ArmsUtils.startActivity(intent)\n}\n\n " +
" override fun killMyself() {\n\n}\n}";
            return module;
        }

        public void skinLists()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(AppContext.BaseDirectory + "/skins");
            //默认指定一个皮肤。
            String skinName = "";
            FileInfo config = new FileInfo(configFile);
            if (config.Exists)
            {
                String[] skin = File.ReadAllLines(configFile);
                skinName = skin[0].Substring(10);
            }
            else
            {
                skinName = "china.she";
            }

            if (directoryInfo.Exists)
            {
                FileInfo[] fileInfos = directoryInfo.GetFiles();
                foreach (FileInfo fileInfo in fileInfos)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem("s" + fileInfo.Name);
                    item.Click += Item_Click;
                    item.Text = fileInfo.Name;
                    TSMI皮肤.DropDownItems.Add(item);
                    if (fileInfo.Name == skinName)
                    {
                        item.Checked = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("皮肤文件不存在！");
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem i in TSMI皮肤.DropDownItems)
            {
                i.Checked = false;
            }
            String name = (sender as ToolStripMenuItem).Text;
            (sender as ToolStripMenuItem).Checked = true;
            skinH.AttachEx(AppContext.BaseDirectory + "/skins/" + name, null);
            String[] lines = File.ReadAllLines(configFile);
            lines[0] = "skin name:" + name;
            File.WriteAllLines(configFile, lines);
        }

        private void tsmi环境_Click(object sender, EventArgs e)
        {
            Form form = new Settings();
            form.Show();
            this.Hide();
        }

        private void TSMIexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /**
         * 创建 
         */
        private void CreateFile()
        {
            //创建一个空白文件
            if (File.Exists(configFile))
            {
               String[] str=File.ReadAllLines(configFile);
                skinH.AttachEx(AppContext.BaseDirectory + "/skins/" + str[0].Substring(10), null);
                tb_packageName.Text = str[2].Substring(13);
                tb_path.Text = str[3].Substring(12);
            }
            else
            {
                //皮肤名称
                string[] lines = {
                "skin name:",
                "user name:",
                "package name:",
                "export path:",
                "package path:",
                "contract path:",
                "model path:",
                "presenter path：" ,
                "module path:",
                "component path:",
                "activity path:",
                "fragment path:",
                "layout path:",
                "auto:"
            };

                foreach (ToolStripMenuItem item in this.TSMI皮肤.DropDownItems)
                {
                    if (item.Checked)
                    {
                        lines[0] = "skin name:" + item.Text;
                        break;
                    }
                }
                File.WriteAllLines(configFile, lines, Encoding.UTF8);

            }
        }

        private void tb_packageName_Leave(object sender, EventArgs e)
        {
           String[] str=File.ReadAllLines(configFile);
            str[2]= "package name:" + tb_packageName.Text;
            File.WriteAllLines(configFile, str, Encoding.UTF8);
        }

    

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}