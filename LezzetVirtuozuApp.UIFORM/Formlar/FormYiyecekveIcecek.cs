using DiyetUygulama.DAL.Contexts;
using DiyetUygulama.DATA.Entities;
using DiyetUygulama.DATA.Enums;
using DiyetUygulama.SERVICE.Concrete;
using DiyetUygulama.SERVICE.Interfaces;
using LezzetVirtuozuApp.UIFORM.Metotlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LezzetVirtuozuApp.UIFORM.Formlar
{
    public partial class FormYiyecekveIcecek : Form
    {
        IProductSERVICE _productSERVICE;
        ICategorySERVICE _categorySERVICE;
        IMealSERVICE _mealSERVICE;
        DiyetUygulamasiContext db;
        private Member _member;

        public FormYiyecekveIcecek(Member member)
        {
            InitializeComponent();
            LoadThema();
            _mealSERVICE = new MealSERVICE();
            _productSERVICE = new ProductSERVICE();
            _categorySERVICE = new CategorySERVICE();
            db = new DiyetUygulamasiContext();
            
            _member = member;
        }
        private void LoadThema()
        {
            foreach (Control Btns in this.Controls)
            {
                if (Btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)Btns;
                    Btns.BackColor = ThemeColor.PrimaryColor;
                    Btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void FormYiyecekveIcecek_Load(object sender, EventArgs e)
        {
            btn_guncelle.Enabled = false;

            cmb_kategori.DataSource = _categorySERVICE.GetAll();
            cmb_kategori.DisplayMember = "CategoryName";
            cmb_kategori.ValueMember = "CategoryId";

            cmb_ogun.DataSource = Enum.GetValues(typeof(Meals));

            var result = _productSERVICE.GetAll();
            Listele(result);

            if (!db.Meals.Any(x => x.MealType == (Meals)cmb_ogun.SelectedValue && x.MealDate.Date == DateTime.Now.Date))
                btn_guncelle.Enabled = false;
            else
                btn_guncelle.Enabled = true;
        }

        private void btn_yiyecekAra_Click(object sender, EventArgs e)
        {
            var result = _productSERVICE.GetWhere(x => x.ProductName.Contains(txt_arama.Text) & x.Visible==true).ToList();
            Listele(result);
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            List<Product> result;

            if (chk_gluten.Checked == true && chk_laktoz.Checked == true)
            {
                result = _productSERVICE.GetWhere(x => x.CategoryId == (int)cmb_kategori.SelectedValue & x.HasLactose == false & x.HasGluten == false & x.Visible == true).ToList();
                Listele(result);
            }
            else if (chk_gluten.Checked == true && chk_laktoz.Checked == false)
            {
                result = _productSERVICE.GetWhere(x => x.CategoryId == (int)cmb_kategori.SelectedValue & x.HasLactose == true & x.HasGluten == false & x.Visible == true).ToList();
                Listele(result);
            }
            else if (chk_gluten.Checked == false && chk_laktoz.Checked == true)
            {
                result = _productSERVICE.GetWhere(x => x.CategoryId == (int)cmb_kategori.SelectedValue & x.HasLactose == false & x.HasGluten == true & x.Visible == true).ToList();
                Listele(result);
            }
            else if (chk_gluten.Checked == false && chk_laktoz.Checked == false)
            {
                result = _productSERVICE.GetWhere(x => x.CategoryId == (int)cmb_kategori.SelectedValue & x.HasLactose == true & x.HasGluten == true & x.Visible == true).ToList();
                Listele(result);
            }
        }

        private void Listele(List<Product> result)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(64, 64);

            lst_liste.Items.Clear();

            foreach (Product item in result)
            {
                var foto = System.Drawing.Image.FromFile(item.PhotoPath);
                imageList.Images.Add(foto);

                ListViewItem lst = new ListViewItem();
                lst.ImageIndex = imageList.Images.Count - 1;
                lst.SubItems.Add(item.ProductName);
                lst.SubItems.Add(item.Calories.ToString());
                lst.SubItems.Add(item.Protein.ToString());
                lst.SubItems.Add(item.Fat.ToString());
                lst.SubItems.Add(item.Carbonhydrate.ToString());
                lst.SubItems.Add(item.Portion.ToString());
                lst.Tag = item;

                lst_liste.Items.Add(lst);
            }
            lst_liste.SmallImageList = imageList;
            lst_liste.LargeImageList = imageList;
        }

        private void lst_liste_MouseClick(object sender, MouseEventArgs e)
        {
            Product selectedProduct = (Product)lst_liste.SelectedItems[0].Tag;
            pb_yiyecekResmi.Image = System.Drawing.Image.FromFile(selectedProduct.PhotoPath);
        }

        private void btn_oguneEkle_Click(object sender, EventArgs e)
        {
            if (cmb_ogun.SelectedIndex != -1)
            {
                Meal meal = new Meal();
                meal.MealType = (Meals)cmb_ogun.SelectedValue;
                meal.MemberId = _member.MemberId;
                db.Meals.Add(meal);
                db.SaveChanges();
                for (int i = 0; i < lst_urunListesi.Items.Count; i++)
                {
                    Product product1 = new Product();
                    int x = product1.ProductId;
                    product1 = (Product)lst_urunListesi.Items[i].Tag;
                    product1.ProductId = x;
                    product1.MealId = meal.MealId;
                    product1.Visible = false;
                    _productSERVICE.Add(product1);
                }
                MessageBox.Show("Öğününüz başarıyla oluşturuldu.");
            }
            else
                MessageBox.Show("Öğün bilginizi giriniz.");
        }

        private void lst_liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            var selectedProduct = (Product)lst_liste.SelectedItems[0].Tag;

            ListViewItem lst = new ListViewItem();
            lst.Text = selectedProduct.ProductName;
            lst.SubItems.Add(selectedProduct.Calories.ToString());
            lst.Tag = selectedProduct;
            lst_urunListesi.Items.Add(lst);
        }

        private void lst_urunListesi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lst_urunListesi.Items.Remove(lst_urunListesi.SelectedItems[0]);
        }

        private void cmb_ogun_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!db.Meals.Any(x => x.MealType == (Meals)cmb_ogun.SelectedValue && x.MealDate.Date == DateTime.Now.Date))
                btn_guncelle.Enabled = false;
            else
                btn_guncelle.Enabled = true;

            lst_urunListesi.Items.Clear();

            Meals selectedMealType = (Meals)cmb_ogun.SelectedValue;
            var selectedMealIds = db.Meals.Where(m => m.MealType == selectedMealType & m.MemberId == _member.MemberId & m.MealDate.Date == DateTime.Now.Date).Select(m => m.MealId).ToList();
            var productsInSelectedMeals = db.Products.Where(p => selectedMealIds.Contains(p.MealId)).ToList();

            if (productsInSelectedMeals != null)
            {
                foreach (Product item in productsInSelectedMeals)
                {
                    var foto = System.Drawing.Image.FromFile(item.PhotoPath);
                    ListViewItem lst = new ListViewItem();
                    lst.Text = item.ProductName;
                    lst.SubItems.Add(item.Calories.ToString());
                    lst.Tag = item;
                    lst_urunListesi.Items.Add(lst);
                }
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            var result = _mealSERVICE.GetMealByMealIdDate((Meals)cmb_ogun.SelectedValue, _member.MemberId, DateTime.Now.Date);

            List<Product> products = _productSERVICE.GetWhere(x => x.MealId == result.MealId);

            int productId = (db.Products.OrderByDescending(p => p.ProductId).FirstOrDefault()).ProductId;
            foreach (Product item in products)
            {
                _productSERVICE.Delete(item);
            }

            for (int i = 0; i < lst_urunListesi.Items.Count; i++)
            {
                Product product1 = new Product();
                Product product2 = (Product)lst_urunListesi.Items[i].Tag;               //SENİN ALLAH BİN BELANI VERSİN TAG GİBİ
                product1.ProductName = product2.ProductName;
                product1.Amount = product2.Amount;
                product1.Unit = product2.Unit;
                product1.Portion = product2.Portion;
                product1.Calories = product2.Calories;
                product1.Protein = product2.Protein;
                product1.Carbonhydrate = product2.Carbonhydrate;
                product1.Fat = product2.Fat;
                product1.HasGluten = product2.HasGluten;
                product1.HasLactose = product2.HasLactose;
                product1.PhotoPath = product2.PhotoPath;
                product1.CategoryId = product2.CategoryId;
                product1.MealId = result.MealId;
                product1.Visible = false;


                _productSERVICE.Add(product1);
            }
            MessageBox.Show("Öğününüz başarıyla güncellendi.");
        }

        private void btn_tumListe_Click(object sender, EventArgs e)
        {
            var result = _productSERVICE.GetAll();
            Listele(result);
        }
    }
}
