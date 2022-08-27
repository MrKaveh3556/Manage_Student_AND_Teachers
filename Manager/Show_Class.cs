using Manager.Properties;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Manager
{
    public class ShowClass
    {
        public ShowStudents_Form show_student = new ShowStudents_Form();
        public ShowTeachers_Form show_techer = new ShowTeachers_Form();
        public static string Miladi_To_Shamsi(int day, int month, int year)
        {
            PersianCalendar p = new PersianCalendar();
            DateTime x = new DateTime(year, month, day);
            int y, m, d;
            y = p.GetYear(x);
            m = p.GetMonth(x);
            d = p.GetDayOfMonth(x);
            return $"{y}/{m}/{d}";
        }
        #region Students
        public string Add_Student()
        {
            bool flag = false;
            if (Settings.Default.Student_Firstname == null)
                MessageBox.Show("شما دانشجویی اضافه نکردید");
            else
            {
                int count = Settings.Default.Student_Firstname.Count;
                show_student.datagridview.Rows.Add(count);
                for (int i = 0; i < count; i++)
                {
                    #region Add Students
                    show_student.datagridview.Rows[i].Cells[0].Value = i + 1;//اضافه کردن ردیف و نام و نام خانوادگی دانشجو
                    show_student.datagridview.Rows[i].Cells[1].Value = $"{Settings.Default.Student_Firstname[i]} {Settings.Default.Student_Lastname[i]}";//---//
                    #endregion
                    #region Check Grades
                    if (Settings.Default.Math == null
                        || Settings.Default.Physic == null
                        || Settings.Default.Shimi == null
                        || Settings.Default.Arabi == null
                        || Settings.Default.Adabiat == null)
                        flag = true;
                    #endregion
                    #region Add Grades
                    else if (!flag)
                    {
                        show_student.datagridview.Rows[i].Cells[2].Value = Settings.Default.Math[i];
                        show_student.datagridview.Rows[i].Cells[3].Value = Settings.Default.Physic[i];
                        show_student.datagridview.Rows[i].Cells[4].Value = Settings.Default.Shimi[i];
                        show_student.datagridview.Rows[i].Cells[5].Value = Settings.Default.Arabi[i];
                        show_student.datagridview.Rows[i].Cells[6].Value = Settings.Default.Adabiat[i];
                    }
                    #endregion
                }
                for (int i = 0; i < count; i++)
                {
                    #region Check Birthday
                    int year_miladi = DateTime.Now.Year,//دریافت تاریخ میلادی
                        month_miladi = DateTime.Now.Month,
                        day_miladi = DateTime.Now.Day;//--------------------//
                    string date_shamsi = ShowClass.Miladi_To_Shamsi(day_miladi, month_miladi, year_miladi);//تبدیل تاریخ میلادی به شمسی
                    string[] dateshamsi_array = date_shamsi.Split('/');
                    int month_shamsi = Convert.ToInt32(dateshamsi_array[1]),
                        day_shamsi = Convert.ToInt32(dateshamsi_array[2]);//---------------//
                    string date_student = Convert.ToString(Settings.Default.Student_Birthdate[i]);//دریافت تاریخ تولد دانش آموز
                    string[] datestudent_array = date_student.Split('/');
                    int month_student = Convert.ToInt32(datestudent_array[1]),
                        day_student = Convert.ToInt32(datestudent_array[2]);//--------------------------//
                    if (month_shamsi == month_student && day_shamsi == day_student)//چک کردن تاریخ تولد
                        MessageBox.Show($"هست {show_student.datagridview.Rows[i].Cells[1].Value} امروز تولد");//---------------------//
                    #endregion
                }
            }
            return "finish";
        }
        public string Save_Students()
        {
            bool flag = false;
            for (int i = 0; i < show_student.datagridview.RowCount; i++)
            {
                #region Save data in Variable
                string math = Convert.ToString(show_student.datagridview.Rows[i].Cells[2].Value),
                        physic = Convert.ToString(show_student.datagridview.Rows[i].Cells[3].Value),
                        shimi = Convert.ToString(show_student.datagridview.Rows[i].Cells[4].Value),
                        arabi = Convert.ToString(show_student.datagridview.Rows[i].Cells[5].Value),
                        adabiat = Convert.ToString(show_student.datagridview.Rows[i].Cells[6].Value),
                        average = Convert.ToString(show_student.datagridview.Rows[i].Cells[7].Value);
                #endregion
                if (math == string.Empty || physic == string.Empty || shimi == string.Empty
                || arabi == string.Empty || adabiat == string.Empty || average == string.Empty)
                {
                    flag = true;//یعنی یکی از خانه ها خالی هست
                    break;
                }
            }
            if (flag)
                MessageBox.Show("حداقل یکی از ستون نمرات خالی میباشد! شما باید \n یا همه ی ستون ها را پر کنید یا اینکه صفر قرار دهید");
            if (!flag)//یعنی همه ی ستون ها پر شده اند
            {
                for (int i = 0; i < show_student.datagridview.RowCount; i++)
                {
                    #region Check Setting Null
                    if (Settings.Default.Math == null)
                        Settings.Default.Math = new StringCollection();
                    if (Settings.Default.Physic == null)
                        Settings.Default.Physic = new StringCollection();
                    if (Settings.Default.Shimi == null)
                        Settings.Default.Shimi = new StringCollection();
                    if (Settings.Default.Arabi == null)
                        Settings.Default.Arabi = new StringCollection();
                    if (Settings.Default.Adabiat == null)
                        Settings.Default.Adabiat = new StringCollection();
                    if (Settings.Default.Average == null)
                        Settings.Default.Average = new StringCollection();
                    #endregion
                    #region Save in Setting
                    Settings.Default.Math.Add(show_student.datagridview.Rows[i].Cells[2].Value.ToString());
                    Settings.Default.Physic.Add(show_student.datagridview.Rows[i].Cells[3].Value.ToString());
                    Settings.Default.Shimi.Add(show_student.datagridview.Rows[i].Cells[4].Value.ToString());
                    Settings.Default.Arabi.Add(show_student.datagridview.Rows[i].Cells[5].Value.ToString());
                    Settings.Default.Adabiat.Add(show_student.datagridview.Rows[i].Cells[6].Value.ToString());
                    Settings.Default.Average.Add(show_student.datagridview.Rows[i].Cells[7].Value.ToString());
                    #endregion
                }
                Settings.Default.Save();
            }
            return "finish";
        }
        public string Add_Average()
        {
            bool flag = false;
            int count = show_student.datagridview.RowCount;
            if (count == 0)
                MessageBox.Show("هیچ دانشجویی اضافه نشده");
            else
            {
                for (int i = 0; i < count; i++)
                {
                    #region Save Grades in Variable
                    string math = Convert.ToString(show_student.datagridview.Rows[i].Cells[2].Value),
            physic = Convert.ToString(show_student.datagridview.Rows[i].Cells[3].Value),
            shimi = Convert.ToString(show_student.datagridview.Rows[i].Cells[4].Value),
            arabi = Convert.ToString(show_student.datagridview.Rows[i].Cells[5].Value),
            adabiat = Convert.ToString(show_student.datagridview.Rows[i].Cells[6].Value);
                    #endregion
                    #region Check Grade Cells Not To Be Empty
                    if (math == string.Empty || physic == string.Empty || shimi == string.Empty || arabi == string.Empty || adabiat == string.Empty)
                    {
                        flag = true;//یعنی خونه یکی از درس ها خالی مانده
                        break;
                    }
                    #endregion
                }
                if (flag)
                    MessageBox.Show("!حداقل خونه یکی از درس ها خالی مانده! لطفا همه ی خانه ها را پر کنید یا صفر قرار دهید");
                if (!flag)
                {
                    for (int i = 0; i < count; i++)
                    {
                        #region Add Average
                        double math = Convert.ToDouble(show_student.datagridview.Rows[i].Cells[2].Value),
                            physic = Convert.ToDouble(show_student.datagridview.Rows[i].Cells[3].Value),
                            shimi = Convert.ToDouble(show_student.datagridview.Rows[i].Cells[4].Value),
                            arabi = Convert.ToDouble(show_student.datagridview.Rows[i].Cells[5].Value),
                            adabiat = Convert.ToDouble(show_student.datagridview.Rows[i].Cells[6].Value);
                        show_student.datagridview.Rows[i].Cells[7].Value = (math + physic + shimi + arabi + adabiat) / 5;
                        #endregion
                    }
                }
            }
            return "finish";
        }
        #endregion
        #region Teachers
        public string Add_Teachers()
        {
            if (Settings.Default.Teacher_Firstname == null)
                MessageBox.Show("شما معلمی اضافه نکردید");
            else
            {
                #region Add Teachers
                int count = Settings.Default.Teacher_Firstname.Count;
                show_student.datagridview.Rows.Add(count);
                for (int i = 0; i < count; i++)//اضافه کردن ردیف و نام و نام خانوادگی دانشجو
                {
                    show_student.datagridview.Rows[i].Cells[0].Value = i + 1;
                    show_student.datagridview.Rows[i].Cells[1].Value = $"{Settings.Default.Teacher_Firstname[i]} {Settings.Default.Teacher_Lastname[i]}";
                    show_student.datagridview.Rows[i].Cells[2].Value = Settings.Default.Teacher_Fathername[i];
                    show_student.datagridview.Rows[i].Cells[3].Value = Settings.Default.Teacher_Codemeli[i];
                    show_student.datagridview.Rows[i].Cells[4].Value = Settings.Default.Teacher_Birthdate[i];
                }
                #endregion
                #region Check Birthday
                for (int i = 0; i < count; i++)
                {
                    int year_miladi = DateTime.Now.Year,
                        month_miladi = DateTime.Now.Month,
                        day_miladi = DateTime.Now.Day;
                    string date_shamsi = ShowClass.Miladi_To_Shamsi(day_miladi, month_miladi, year_miladi);
                    string[] dateshamsi_array = date_shamsi.Split('/');
                    int month_shamsi = Convert.ToInt32(dateshamsi_array[1]),
                        day_shamsi = Convert.ToInt32(dateshamsi_array[2]);
                    string date_teacher = Convert.ToString(show_student.datagridview.Rows[i].Cells[4].Value);
                    string[] dateteacher_array = date_teacher.Split('/');
                    int month_teacher = Convert.ToInt32(dateteacher_array[1]),
                        day_teacher = Convert.ToInt32(dateteacher_array[2]);
                    if (month_shamsi == month_teacher && day_shamsi == day_teacher)
                        MessageBox.Show($"هست {show_student.datagridview.Rows[i].Cells[1].Value} امروز تولد");
                }
                #endregion
            }
            return "finish";
        }
        #endregion
    }
}
