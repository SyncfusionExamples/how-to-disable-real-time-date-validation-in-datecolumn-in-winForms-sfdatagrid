using SfDataGridDemo;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using Syncfusion.WinForms.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfDataGridDemo
{
    public partial class Form1 : Form
    {
        public OrderInfoCollection collections;
        public Form1()
        {
            InitializeComponent();
            collections = new OrderInfoCollection();
            sfDataGrid1.AutoGenerateColumns = true;
            sfDataGrid1.DataSource = collections.Orders;

            this.sfDataGrid1.CellRenderers.Remove("DateTime");
            this.sfDataGrid1.CellRenderers.Add("DateTime", new CustomDateTimeCellRenderer());            
        }
    }

    public class CustomDateTimeCellRenderer : GridDateTimeCellRenderer
    {
        protected override void OnInitializeEditElement(DataColumnBase column, RowColumnIndex rowColumnIndex, SfDateTimeEdit uiElement)
        {
            var dateColumn = column.GridColumn as GridDateTimeColumn;
            if (dateColumn != null)
                dateColumn.DateTimeEditingMode = default;

            base.OnInitializeEditElement(column, rowColumnIndex, uiElement);
        }
    }
}
