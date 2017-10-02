using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace HomeworkDateTime
{
    public partial class FormDayOfWeek : Form
    {
        public FormDayOfWeek()
        {
            InitializeComponent();
        }

        private void DateTimePickerDay_ValueChanged(object sender, EventArgs e)
        {
            labelDayOfWeek.Text = dateTimePickerDay.Value.ToString("dddd",
                        new CultureInfo("ru-RU"));
        }
    }
}
