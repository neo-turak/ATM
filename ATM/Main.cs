using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class atm : Form
    {
        public String name = "";
        public String layoutName = "";
        public String path = "";

        public atm()
        {
            InitializeComponent();
        }

        private void atm_Load(object sender, EventArgs e)
        {
            tb_path.Text = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
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

        public String GenerateKModel()

        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n";
            module += "import android.app.Application\n" +
                        "import com.google.gson.Gson\n" +
                        "import com.jess.arms.di.scope.ActivityScope\n" +
                        "import com.jess.arms.integration.IRepositoryManager\n" +
                        "import com.jess.arms.mvp.BaseModel\n" +
                        "import javax.inject.Inject\n\n" +
                        "@ActivityScope\n" +
                        "class " + tb_pageName.Text + "Model\n" +
                        "@Inject\n" +
                        "constructor(repositoryManager: IRepositoryManager) : BaseModel(repositoryManager)," + tb_pageName.Text + "Contract.Model{\n" +
                     "   @Inject\n" +
                 "  lateinit var mGson:Gson;\n" +
                  " @Inject\n" +
               "lateinit var mApplication:Application;\n" +

               " override fun onDestroy()\n" +
               "     {\n" +
               "         super.onDestroy();\n" +
                  "     }\n" +
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
                     "//对于经常使用的关于UI的方法可以定义到IView中,如显示隐藏进度条,和显示文字消息\n" +
                    " interface View : IView\n" +
                    "//Model层定义接口,外部只需关心Model返回的数据,无需关心内部细节,即是否使用缓存\n" +
                    "interface Model : IModel\n" +
                        "}";
            return module;
        }

        public String GenerateKPresenter()
        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n";
            module += "import android.app.Application\n" +
                    "import com.jess.arms.di.scope.ActivityScope\n" +
                    "import com.jess.arms.http.imageloader.ImageLoader\n" +
                    "import com.jess.arms.integration.AppManager\n" +
                    "import com.jess.arms.mvp.BasePresenter\n" +
                    "import me.jessyan.rxerrorhandler.core.RxErrorHandler\n" +
                    "import javax.inject.Inject\n\n\n" +
                    "@ActivityScope\n class " + tb_pageName.Text + "Presenter\n @Inject\n" +
                    "constructor(model: " + tb_pageName.Text + "Contract.Model, rootView: " + tb_pageName.Text + "Contract.View) :\n" +
                    "BasePresenter<" + tb_pageName.Text + "Contract.Model, " + tb_pageName.Text + "Contract.View>(model, rootView) {\n" +
                    "@Inject\n lateinit var mErrorHandler: RxErrorHandler\n" +
                    "@Inject\n lateinit var mApplication: Application\n" +
                    "@Inject\n lateinit var mImageLoader: ImageLoader\n" +
                    "@Inject\n lateinit var mAppManager: AppManager\n" +
                    "override fun onDestroy() {\n" +
                     " super.onDestroy();\n" +
                    "}" +
                    "}";
            return module;
        }

        public String GenerateKModule()
        {
            String package = tb_packageName.Text;
            String module = "package " + package + "\n";
            module += "import com.jess.arms.di.scope.ActivityScope\n" +
                    "import dagger.Module\n" +
                    "import dagger.Provides\n\n\n" +
                    "@Module\n" +
                    "//构建" + tb_pageName.Text + "Module时,将View的实现类传进来,这样就可以提供View的实现类给presenter\n" +
                    "class " + tb_pageName.Text + "Module(private val view:" + tb_pageName.Text + "Contract.View) {\n" +
                    "@ActivityScope\n@Provides\n" +
                    "fun provide" + tb_pageName.Text + "View():" + tb_pageName.Text + "Contract.View{\n" +
                    "     return this.view\n}\n\n" +
                    "@ActivityScope\n@Provides\n" +
                    "fun provide" + tb_pageName.Text + "Model(model:" + tb_pageName.Text + "Model):" + tb_pageName.Text + "Contract.Model{\n" +
                    "return model\n" +
                    "}\n}";
            return module;
        }

        public String GenerateKComponent()
        {
            String package = tb_packageName.Text;
            String module = "package  " + package + "\n";
            module += "import com.jess.arms.di.component.AppComponent\n" +
                "import com.jess.arms.di.scope.ActivityScope\n" +
                "import dagger.Component\n\n" +
                "@ActivityScope\n" +
                "@Component(modules = arrayOf(" + tb_pageName.Text + "Module::class),dependencies = arrayOf(AppComponent::class))\n" +
                "interface " + tb_pageName.Text + "Component{\n" +
                "    fun inject(activity:" + tb_pageName.Text + "Activity)\n" +
                "}";
            return module;
        }

        public String GenerateLayout()
        {
            String module = "<?xml version=\"1.0\" encoding=\"utf-8\"?>\n" +
   "<android.support.constraint.ConstraintLayout\n" +
        "        xmlns:android=\"http://schemas.android.com/apk/res/android\"\n" +
        "        xmlns:app=\"http://schemas.android.com/apk/res-auto\"\n" +
        "        android:layout_width=\"match_parent\"\n" +
        "        android:layout_height=\"match_parent\">\n\n\n\n" +
        "</android.support.constraint.ConstraintLayout>\n";
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
                 createFile(tb_model.Text, GenerateKModel());
                createFile(tb_layout.Text, GenerateLayout());
                createFile(tb_component.Text, GenerateKComponent());
                createFile(tb_module.Text, GenerateKModule());
                createFile(tb_presenter.Text, GenerateKPresenter());
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
                createFile(tb_model.Text, GenerateKModel());
                createFile(tb_layout.Text, GenerateLayout());
                createFile(tb_component.Text, GenerateKComponent());
                createFile(tb_module.Text, GenerateKModule());
                createFile(tb_presenter.Text, GenerateKPresenter());
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
            String module = "package " + package + "\n\n" +
 "import android.content.Intent\n" +
 "import android.os.Bundle\n" +
"import android.os.Message\n" +
"import android.support.v4.app.Fragment\n" +
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
"import " + package + ".R\n" +
"/**\n" +
 "* 如果没presenter\n" +
" * 你可以这样写\n" +
 "*\n" +
" *@FragmentScope(請注意命名空間) class NullObjectPresenterByFragment\n" +
 "* @Inject constructor() : IPresenter {\n" +
" * override fun onStart()\n" +
 "       {\n" +
 "           * }\n" +
" *\n" +
" * override fun onDestroy()\n" +
 "       {\n" +
 "           * }\n" +
 "* }\n" +
 "*/\n" +

"class " + tb_pageName.Text.ToString() + "Fragment : BaseFragment<" + tb_pageName.Text.ToString() + "Presenter>() , " + tb_pageName.Text.ToString() + "Contract.View{\n" +
"   companion object {\n" +
"   fun newInstance():" + tb_pageName.Text.ToString() + "Fragment {\n" +
"   val fragment = " + tb_pageName.Text.ToString() + "Fragment()\n" +
"   return fragment\n" +
"}\n}\n\n\n" +
"   override fun setupFragmentComponent(appComponent:AppComponent) {\n" +
"       Dagger" + tb_pageName.Text.ToString() + "Component//如找不到该类，请编译一下项目{\n" +
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

    }

}