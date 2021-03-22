﻿using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class BasketForms : Form
    {
        public BasketForms()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void BasketList()
        {
            string[] columns = { "SepetID", "Müşteri Adı", "Müşteri Soyad", "Ürün", "Ürün Marka", "Ürün Model", "Adet", "Tutar" };
            for (int i = 0; i < columns.Length; i++)
                listView1.Columns.Add(columns[i], 100);
            BasketBusiness bB = new BasketBusiness();
            bB.BasketList(listView1);

        }
        private void BasketForms_Load(object sender, EventArgs e)
        {
            BasketList();
        }
    }
}
