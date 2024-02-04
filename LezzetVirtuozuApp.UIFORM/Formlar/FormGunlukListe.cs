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
    public partial class FormGunlukListe : Form
    {
        IMealSERVICE _mealSERVICE;
        IProductSERVICE _productService;
        
        private Member _member;

        public FormGunlukListe(Member member)
        {
            InitializeComponent();
            _mealSERVICE = new MealSERVICE();
            _productService = new ProductSERVICE();
            _member = member;
        }

        public FormGunlukListe()
        {
            InitializeComponent();
        }

        private void dtp_tarih_ValueChanged(object sender, EventArgs e)
        {
            CleanLabelsAndLists();

            var breakfast = _mealSERVICE.GetMealByMealIdDate(Meals.Sabah, _member.MemberId, dtp_tarih.Value.Date);
            var lunch = _mealSERVICE.GetMealByMealIdDate(Meals.Ogle, _member.MemberId, dtp_tarih.Value.Date);
            var dinner = _mealSERVICE.GetMealByMealIdDate(Meals.Aksam, _member.MemberId, dtp_tarih.Value.Date);

            double x = 0;
            double totalCalories = 0;
            double totalProtein = 0;
            double totalCarbonhydrate = 0;
            double totalFat = 0;


            if (breakfast != null)
            {
                var resultBreakfast = _productService.GetWhere(x => x.MealId == breakfast.MealId);
                foreach (Product item in resultBreakfast)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = item.ProductName;
                    lst.SubItems.Add(item.Calories.ToString());
                    lst.SubItems.Add(item.Protein.ToString());
                    lst.SubItems.Add(item.Carbonhydrate.ToString());
                    lst.SubItems.Add(item.Fat.ToString());
                    lst.Tag = item;

                    lst_sabah.Items.Add(lst);

                    totalCalories += (double)item.Calories;
                    totalProtein += (double)item.Protein;
                    totalCarbonhydrate += (double)item.Carbonhydrate;
                    totalFat += (double)item.Fat;
                }
                lbl_kaloriToplamSabah.Text = totalCalories.ToString();
                lbl_karbonhidratToplamSabah.Text = totalCarbonhydrate.ToString();
                lbl_proteinToplamSabah.Text = totalProtein.ToString();
                lbl_yagToplamSabah.Text = totalFat.ToString();
                x += totalCalories;

                totalCalories = 0;
                totalProtein = 0;
                totalCarbonhydrate = 0;
                totalFat = 0;
            }

            if (lunch != null)
            {
                var resultLunch = _productService.GetWhere(x => x.MealId == lunch.MealId);
                foreach (Product item in resultLunch)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = item.ProductName;
                    lst.SubItems.Add(item.Calories.ToString());
                    lst.SubItems.Add(item.Protein.ToString());
                    lst.SubItems.Add(item.Carbonhydrate.ToString());
                    lst.SubItems.Add(item.Fat.ToString());
                    lst.Tag = item;

                    lst_ogle.Items.Add(lst);

                    totalCalories += (double)item.Calories;
                    totalProtein += (double)item.Protein;
                    totalCarbonhydrate += (double)item.Carbonhydrate;
                    totalFat += (double)item.Fat;
                }
                lbl_kaloriToplamOgle.Text = totalCalories.ToString();
                lbl_karbonhidratToplamOgle.Text = totalCarbonhydrate.ToString();
                lbl_proteinToplamOgle.Text = totalProtein.ToString();
                lbl_yagToplamOgle.Text = totalFat.ToString();
                x += totalCalories;

                totalCalories = 0;
                totalProtein = 0;
                totalCarbonhydrate = 0;
                totalFat = 0;
            }

            if (dinner != null)
            {
                var resultDinner = _productService.GetWhere(x => x.MealId == dinner.MealId);
                foreach (Product item in resultDinner)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.Text = item.ProductName;
                    lst.SubItems.Add(item.Calories.ToString());
                    lst.SubItems.Add(item.Protein.ToString());
                    lst.SubItems.Add(item.Carbonhydrate.ToString());
                    lst.SubItems.Add(item.Fat.ToString());
                    lst.Tag = item;

                    lst_aksam.Items.Add(lst);

                    totalCalories += (double)item.Calories;
                    totalProtein += (double)item.Protein;
                    totalCarbonhydrate += (double)item.Carbonhydrate;
                    totalFat += (double)item.Fat;
                }
                lbl_kaloriToplamAksam.Text = totalCalories.ToString();
                lbl_karbonhidratToplamAksam.Text = totalCarbonhydrate.ToString();
                lbl_proteinToplamAksam.Text = totalProtein.ToString();
                lbl_yagToplamAksam.Text = totalFat.ToString();
                x += totalCalories;

                totalCalories = 0;
                totalProtein = 0;
                totalCarbonhydrate = 0;
                totalFat = 0;
            }
            lbl_toplamKalori.Text = $"{x} kCal";
        }
        private void CleanLabelsAndLists()
        {
            lst_sabah.Items.Clear();
            lst_ogle.Items.Clear();
            lst_aksam.Items.Clear();
            lbl_kaloriToplamAksam.Text = string.Empty;
            lbl_kaloriToplamOgle.Text = string.Empty;
            lbl_kaloriToplamSabah.Text = string.Empty;
            lbl_proteinToplamAksam.Text = string.Empty;
            lbl_proteinToplamOgle.Text = string.Empty;
            lbl_proteinToplamSabah.Text = string.Empty;
            lbl_karbonhidratToplamAksam.Text = string.Empty;
            lbl_karbonhidratToplamOgle.Text = string.Empty;
            lbl_karbonhidratToplamSabah.Text = string.Empty;
            lbl_yagToplamAksam.Text = string.Empty;
            lbl_yagToplamOgle.Text = string.Empty;
            lbl_yagToplamSabah.Text = string.Empty;
        }
    }
}
