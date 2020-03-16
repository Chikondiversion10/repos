using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Data;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DataTable DT;
        DataColumn DC;
        DataRow DR;
        DataTable GetEmployeeTable()
        {
            DT = new DataTable("Employee");

            #region Employee DataTable
            DC = new DataColumn("EmpID",  typeof(int));
            DT.Columns.Add(DC);
            DT.PrimaryKey = new DataColumn[] { DC };

            DC = new DataColumn("EmpName", typeof(string));
            DT.Columns.Add(DC);

            DC = new DataColumn("DeptId", typeof(int));
            DT.Columns.Add(DC);

            DR = DT.NewRow();
            DR[0] = 101;
            DR[1] = "Chikondi";
            DR[2] = 10;
            DT.Rows.Add(DR);


            DR = DT.NewRow();
            DR[0] = 102;
            DR[1] = "Roosevelt0";
            DR[2] = 12;
            #endregion
            return DT;



        }

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void empDatagrid_Load (object sender, EventArgs e)
        {
            DataTable EmpTable = GetEmployeeTable();
            empDatagrid. = EmpTable;
        }
    }
}
