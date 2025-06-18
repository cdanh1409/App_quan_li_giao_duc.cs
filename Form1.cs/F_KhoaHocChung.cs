using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1.cs
{
    public partial class Form9 : Form
    {
        private void InitializeComponen()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Form9));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label_sotienmua = new Label();
            label_danhgia = new Label();
            label_ngoisao = new PictureBox();
            guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            btn_found = new Guna.UI2.WinForms.Guna2Button();
            btn_exit = new Guna.UI2.WinForms.Guna2Button();
            btn_giohang = new Guna.UI2.WinForms.Guna2Button();
            btn_thongbao = new Guna.UI2.WinForms.Guna2Button();
            label_sotien = new Guna.UI2.WinForms.Guna2HtmlLabel();
            textbox_timkiem = new Guna.UI2.WinForms.Guna2TextBox();
            guna2GradientPanel1.SuspendLayout();
            ((ISupportInitialize)label_ngoisao).BeginInit();
            SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.Controls.Add(guna2Panel1);
            guna2GradientPanel1.Controls.Add(label_sotienmua);
            guna2GradientPanel1.Controls.Add(label_danhgia);
            guna2GradientPanel1.Controls.Add(label_ngoisao);
            guna2GradientPanel1.Controls.Add(guna2Button8);
            guna2GradientPanel1.Controls.Add(btn_found);
            guna2GradientPanel1.Controls.Add(btn_exit);
            guna2GradientPanel1.Controls.Add(btn_giohang);
            guna2GradientPanel1.Controls.Add(btn_thongbao);
            guna2GradientPanel1.Controls.Add(label_sotien);
            guna2GradientPanel1.Controls.Add(textbox_timkiem);
            guna2GradientPanel1.CustomizableEdges = customizableEdges15;
            guna2GradientPanel1.FillColor = Color.FromArgb(0, 74, 173);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(203, 108, 230);
            guna2GradientPanel1.Location = new Point(0, 2);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges16;
            guna2GradientPanel1.Size = new Size(1920, 1080);
            guna2GradientPanel1.TabIndex = 5;
            // 
            // guna2Panel1
            // 
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Location = new Point(218, 393);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1334, 610);
            guna2Panel1.TabIndex = 33;
            // 
            // label_sotienmua
            // 
            label_sotienmua.AutoSize = true;
            label_sotienmua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_sotienmua.ForeColor = Color.Red;
            label_sotienmua.Location = new Point(62, 615);
            label_sotienmua.Name = "label_sotienmua";
            label_sotienmua.Size = new Size(89, 28);
            label_sotienmua.TabIndex = 32;
            label_sotienmua.Text = "400.000";
            // 
            // label_danhgia
            // 
            label_danhgia.AutoSize = true;
            label_danhgia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_danhgia.Location = new Point(112, 578);
            label_danhgia.Name = "label_danhgia";
            label_danhgia.Size = new Size(41, 28);
            label_danhgia.TabIndex = 31;
            label_danhgia.Text = "5.0";
            // 
            // label_ngoisao
            // 
            label_ngoisao.BackgroundImage = (Image)resources.GetObject("label_ngoisao.BackgroundImage");
            label_ngoisao.BackgroundImageLayout = ImageLayout.Stretch;
            label_ngoisao.Location = new Point(62, 578);
            label_ngoisao.Name = "label_ngoisao";
            label_ngoisao.Size = new Size(33, 29);
            label_ngoisao.TabIndex = 30;
            label_ngoisao.TabStop = false;
            // 
            // guna2Button8
            // 
            guna2Button8.BackColor = Color.Transparent;
            guna2Button8.BorderRadius = 40;
            guna2Button8.CustomizableEdges = customizableEdges3;
            guna2Button8.DisabledState.BorderColor = Color.DarkGray;
            guna2Button8.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button8.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button8.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button8.FillColor = Color.LightGray;
            guna2Button8.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button8.ForeColor = Color.Black;
            guna2Button8.Location = new Point(1577, 210);
            guna2Button8.Name = "guna2Button8";
            guna2Button8.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button8.Size = new Size(287, 82);
            guna2Button8.TabIndex = 25;
            guna2Button8.Text = "Tạo cuộc thi";
            // 
            // btn_found
            // 
            btn_found.BackColor = Color.Transparent;
            btn_found.BackgroundImage = (Image)resources.GetObject("btn_found.BackgroundImage");
            btn_found.BackgroundImageLayout = ImageLayout.Stretch;
            btn_found.CustomizableEdges = customizableEdges5;
            btn_found.DisabledState.BorderColor = Color.DarkGray;
            btn_found.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_found.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_found.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_found.FillColor = Color.Transparent;
            btn_found.Font = new Font("Segoe UI", 9F);
            btn_found.ForeColor = Color.White;
            btn_found.Location = new Point(985, 209);
            btn_found.Name = "btn_found";
            btn_found.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_found.Size = new Size(87, 82);
            btn_found.TabIndex = 24;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Transparent;
            btn_exit.BackgroundImage = (Image)resources.GetObject("btn_exit.BackgroundImage");
            btn_exit.BackgroundImageLayout = ImageLayout.Stretch;
            btn_exit.CustomizableEdges = customizableEdges7;
            btn_exit.DisabledState.BorderColor = Color.DarkGray;
            btn_exit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_exit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_exit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_exit.FillColor = Color.Transparent;
            btn_exit.Font = new Font("Segoe UI", 9F);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(1797, 15);
            btn_exit.Name = "btn_exit";
            btn_exit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_exit.Size = new Size(67, 56);
            btn_exit.TabIndex = 23;
            // 
            // btn_giohang
            // 
            btn_giohang.BackColor = Color.Transparent;
            btn_giohang.BackgroundImage = (Image)resources.GetObject("btn_giohang.BackgroundImage");
            btn_giohang.BackgroundImageLayout = ImageLayout.Stretch;
            btn_giohang.BorderRadius = 30;
            btn_giohang.CustomizableEdges = customizableEdges9;
            btn_giohang.DisabledState.BorderColor = Color.DarkGray;
            btn_giohang.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_giohang.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_giohang.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_giohang.FillColor = Color.Transparent;
            btn_giohang.Font = new Font("Segoe UI", 9F);
            btn_giohang.ForeColor = Color.White;
            btn_giohang.Location = new Point(1578, 15);
            btn_giohang.Name = "btn_giohang";
            btn_giohang.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btn_giohang.Size = new Size(68, 56);
            btn_giohang.TabIndex = 22;
            // 
            // btn_thongbao
            // 
            btn_thongbao.BackColor = Color.Transparent;
            btn_thongbao.BackgroundImage = (Image)resources.GetObject("btn_thongbao.BackgroundImage");
            btn_thongbao.BackgroundImageLayout = ImageLayout.Stretch;
            btn_thongbao.CustomizableEdges = customizableEdges11;
            btn_thongbao.DisabledState.BorderColor = Color.DarkGray;
            btn_thongbao.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_thongbao.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_thongbao.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_thongbao.FillColor = Color.Transparent;
            btn_thongbao.Font = new Font("Segoe UI", 9F);
            btn_thongbao.ForeColor = Color.White;
            btn_thongbao.Location = new Point(1682, 15);
            btn_thongbao.Name = "btn_thongbao";
            btn_thongbao.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btn_thongbao.Size = new Size(71, 56);
            btn_thongbao.TabIndex = 21;
            // 
            // label_sotien
            // 
            label_sotien.AutoSize = false;
            label_sotien.AutoSizeHeightOnly = true;
            label_sotien.BackColor = Color.LightGray;
            label_sotien.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_sotien.Location = new Point(1230, 16);
            label_sotien.Name = "label_sotien";
            label_sotien.Size = new Size(322, 55);
            label_sotien.TabIndex = 20;
            label_sotien.Text = "Số tiền: ";
            // 
            // textbox_timkiem
            // 
            textbox_timkiem.BackColor = Color.Transparent;
            textbox_timkiem.BorderColor = Color.Transparent;
            textbox_timkiem.BorderRadius = 30;
            textbox_timkiem.CustomizableEdges = customizableEdges13;
            textbox_timkiem.DefaultText = "Tìm kiếm :";
            textbox_timkiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            textbox_timkiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            textbox_timkiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            textbox_timkiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            textbox_timkiem.FillColor = Color.LightGray;
            textbox_timkiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox_timkiem.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textbox_timkiem.ForeColor = Color.Black;
            textbox_timkiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            textbox_timkiem.Location = new Point(218, 209);
            textbox_timkiem.Margin = new Padding(10, 14, 10, 14);
            textbox_timkiem.Name = "textbox_timkiem";
            textbox_timkiem.PlaceholderForeColor = Color.Black;
            textbox_timkiem.PlaceholderText = "";
            textbox_timkiem.SelectedText = "";
            textbox_timkiem.ShadowDecoration.CustomizableEdges = customizableEdges14;
            textbox_timkiem.Size = new Size(754, 83);
            textbox_timkiem.TabIndex = 18;
            // 
            // Form9
            // 
            ClientSize = new Size(1902, 1033);
            Controls.Add(guna2GradientPanel1);
            Name = "Form9";
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ((ISupportInitialize)label_ngoisao).EndInit();
            ResumeLayout(false);

        }
        private Label label_sotienmua;
        private Label label_danhgia;
        private PictureBox label_ngoisao;
        private Guna.UI2.WinForms.Guna2Button guna2Button8;
        private Guna.UI2.WinForms.Guna2Button btn_found;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_giohang;
        private Guna.UI2.WinForms.Guna2Button btn_thongbao;
        private Guna.UI2.WinForms.Guna2TextBox textbox_timkiem;
        private Guna.UI2.WinForms.Guna2HtmlLabel label_sotien;
    }
}
