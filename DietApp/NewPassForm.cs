﻿using System;
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
    public partial class NewPassForm : Form
    {
        Classes.AppDbContext db = new Classes.AppDbContext();

        public NewPassForm()
        {
            InitializeComponent();
        }
    }
}
