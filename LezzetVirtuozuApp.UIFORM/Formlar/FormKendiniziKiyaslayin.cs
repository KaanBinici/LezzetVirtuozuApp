using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using DiyetUygulama.SERVICE.Concrete;
using DiyetUygulama.SERVICE.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    public partial class FormKendiniziKiyaslayin : Form
    {
        ICategorySERVICE _categorySERVICE;
        DiyetUygulamasiContext db;

        private Member _member;
        public FormKendiniziKiyaslayin(Member member)
        {
            InitializeComponent();
            _categorySERVICE = new CategorySERVICE();
            db = new DiyetUygulamasiContext();
            _member = member;
        }
        public FormKendiniziKiyaslayin()
        {
            InitializeComponent();
        }

        private void FormKendiniziKiyaslayin_Load(object sender, EventArgs e)
        {
            cmb_kategori.DataSource = _categorySERVICE.GetAll();
            cmb_kategori.DisplayMember = "CategoryName";
            cmb_kategori.ValueMember = "CategoryId";

            cmb_ogun.DataSource = Enum.GetValues(typeof(Meals));

            cmb_ogun.Enabled = false;
            cmb_kategori.Enabled = false;
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_kiyasFaktoru.SelectedIndex != -1)
                {
                    lst_gunluk.Items.Clear();
                    lst_haftalik.Items.Clear();
                    lst_aylik.Items.Clear();

                    DateTime date = dtp_tarih.Value.Date;
                    DateTime weeklyDate = date.AddDays(-7);
                    DateTime monthlyDate = date.AddMonths(-1);

                    if (cmb_kiyasFaktoru.SelectedIndex == 1)
                    {
                        var resultDaily = db.Products.Join(db.Meals, p => p.MealId, m => m.MealId, (p, m) => new { Products = p, Meals = m })
                                           .Join(db.Members, pm => pm.Meals.MemberId, n => n.MemberId, (pm, n) => new { ProductsMeals = pm, Members = n })
                                           .Where(x => x.ProductsMeals.Meals.MealType == (Meals)cmb_ogun.SelectedValue & x.ProductsMeals.Meals.MealDate.Date == date & x.Members.Status != BaseStatus.Deleted)
                                           .GroupBy(x => x.Members.MemberName)
                                           .Select(x => new
                                           {
                                               Member = x.Key,
                                               TotalCalories = x.Sum(x => x.ProductsMeals.Products.Calories),
                                           })
                                           .ToList();

                        foreach (var item in resultDaily)
                        {
                            ListViewItem lst = new ListViewItem();
                            lst.Text = item.Member;
                            lst.SubItems.Add(item.TotalCalories.ToString());
                            lst_gunluk.Items.Add(lst);
                        }

                        var resultWeekly = db.Products.Join(db.Meals, p => p.MealId, m => m.MealId, (p, m) => new { Products = p, Meals = m })
                                               .Join(db.Members, pm => pm.Meals.MemberId, n => n.MemberId, (pm, n) => new { ProductsMeals = pm, Members = n })
                                               .Where(x => x.ProductsMeals.Meals.MealType == (Meals)cmb_ogun.SelectedValue
                                               & x.ProductsMeals.Meals.MealDate.Date >= weeklyDate
                                               & x.ProductsMeals.Meals.MealDate.Date <= date
                                               & x.Members.Status != BaseStatus.Deleted)
                                               .GroupBy(x => x.Members.MemberName)
                                               .Select(x => new
                                               {
                                                   Member = x.Key,
                                                   TotalCalories = x.Sum(x => x.ProductsMeals.Products.Calories),
                                               })
                                               .ToList();

                        foreach (var item in resultWeekly)
                        {
                            ListViewItem lst = new ListViewItem();
                            lst.Text = item.Member;
                            lst.SubItems.Add(item.TotalCalories.ToString());
                            lst_haftalik.Items.Add(lst);
                        }

                        var resultMonthly = db.Products.Join(db.Meals, p => p.MealId, m => m.MealId, (p, m) => new { Products = p, Meals = m })
                                               .Join(db.Members, pm => pm.Meals.MemberId, n => n.MemberId, (pm, n) => new { ProductsMeals = pm, Members = n })
                                               .Where(x => x.ProductsMeals.Meals.MealType == (Meals)cmb_ogun.SelectedValue
                                               & x.ProductsMeals.Meals.MealDate.Date >= monthlyDate
                                               & x.ProductsMeals.Meals.MealDate.Date <= date
                                               & x.Members.Status != BaseStatus.Deleted)
                                               .GroupBy(x => x.Members.MemberName)
                                               .Select(x => new
                                               {
                                                   Member = x.Key,
                                                   TotalCalories = x.Sum(x => x.ProductsMeals.Products.Calories),
                                               })
                                               .ToList();

                        foreach (var item in resultMonthly)
                        {
                            ListViewItem lst = new ListViewItem();
                            lst.Text = item.Member;
                            lst.SubItems.Add(item.TotalCalories.ToString());
                            lst_aylik.Items.Add(lst);
                        }
                    }
                    else if (cmb_kiyasFaktoru.SelectedIndex == 0)
                    {

                        var resultDaily = db.Products.Join(db.Meals, p => p.MealId, m => m.MealId, (p, m) => new { Products = p, Meals = m })
                                           .Join(db.Members, pm => pm.Meals.MemberId, n => n.MemberId, (pm, n) => new { ProductsMeals = pm, Members = n })
                                           .Where(x => x.ProductsMeals.Meals.MealDate.Date == date & x.ProductsMeals.Products.CategoryId == (int)cmb_kategori.SelectedValue & x.Members.Status != BaseStatus.Deleted)
                                           .GroupBy(x => x.Members.MemberName)
                                           .Select(x => new
                                           {
                                               Member = x.Key,
                                               TotalCalories = x.Sum(x => x.ProductsMeals.Products.Calories),
                                           })
                                           .ToList();
                        
                        foreach (var item in resultDaily)
                        {
                            ListViewItem lst = new ListViewItem();
                            lst.Text = item.Member;
                            lst.SubItems.Add(item.TotalCalories.ToString());
                            lst_gunluk.Items.Add(lst);
                        }

                        var resultWeekly = db.Products.Join(db.Meals, p => p.MealId, m => m.MealId, (p, m) => new { Products = p, Meals = m })
                                           .Join(db.Members, pm => pm.Meals.MemberId, n => n.MemberId, (pm, n) => new { ProductsMeals = pm, Members = n })
                                           .Where(x => x.ProductsMeals.Meals.MealDate.Date >= weeklyDate
                                           & x.ProductsMeals.Meals.MealDate.Date <= date
                                           & x.ProductsMeals.Products.CategoryId == (int)cmb_kategori.SelectedValue 
                                           & x.Members.Status != BaseStatus.Deleted)
                                           .GroupBy(x => x.Members.MemberName)
                                           .Select(x => new
                                           {
                                               Member = x.Key,
                                               TotalCalories = x.Sum(x => x.ProductsMeals.Products.Calories),
                                           })
                                           .ToList();

                        foreach (var item in resultWeekly)
                        {
                            ListViewItem lst = new ListViewItem();
                            lst.Text = item.Member;
                            lst.SubItems.Add(item.TotalCalories.ToString());
                            lst_haftalik.Items.Add(lst);
                        }

                        var resultMonthly = db.Products.Join(db.Meals, p => p.MealId, m => m.MealId, (p, m) => new { Products = p, Meals = m })
                                           .Join(db.Members, pm => pm.Meals.MemberId, n => n.MemberId, (pm, n) => new { ProductsMeals = pm, Members = n })
                                           .Where(x => x.ProductsMeals.Meals.MealDate.Date >= monthlyDate
                                           & x.ProductsMeals.Meals.MealDate.Date <= date
                                           & x.ProductsMeals.Products.CategoryId == (int)cmb_kategori.SelectedValue
                                           & x.Members.Status != BaseStatus.Deleted)
                                           .GroupBy(x => x.Members.MemberName)
                                           .Select(x => new
                                           {
                                               Member = x.Key,
                                               TotalCalories = x.Sum(x => x.ProductsMeals.Products.Calories),
                                           })
                                           .ToList();

                        foreach (var item in resultMonthly)
                        {
                            ListViewItem lst = new ListViewItem();
                            lst.Text = item.Member;
                            lst.SubItems.Add(item.TotalCalories.ToString());
                            lst_aylik.Items.Add(lst);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Kıyas Tercihinizi Yapınız.");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen Kıyas Tercihinizi Yapınız.");
            }
        }

        private void cmb_kiyasFaktoru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_kiyasFaktoru.SelectedIndex == 0)
            {
                cmb_ogun.Enabled = false;
                cmb_kategori.Enabled = true;
            }
            else if (cmb_kiyasFaktoru.SelectedIndex == 1)
            {
                cmb_ogun.Enabled = true;
                cmb_kategori.Enabled = false;
            }
        }
    }
}
