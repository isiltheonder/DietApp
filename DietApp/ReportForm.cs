using DietApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietApp
{
    public partial class ReportForm : Form
    {
        AppDbContext db = new AppDbContext();

        public ReportForm(string language)
        {
            InitializeComponent();
        }
    }
}
