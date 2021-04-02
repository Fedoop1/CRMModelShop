
namespace crmUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuEntity = new System.Windows.Forms.MenuStrip();
            this.EntityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.продавецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моделированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productBox = new System.Windows.Forms.ListBox();
            this.cartBox = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.sumLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.LinkLabel();
            this.menuEntity.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuEntity
            // 
            this.menuEntity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntityToolStripMenuItem,
            this.моделированиеToolStripMenuItem});
            this.menuEntity.Location = new System.Drawing.Point(0, 0);
            this.menuEntity.Name = "menuEntity";
            this.menuEntity.Size = new System.Drawing.Size(600, 24);
            this.menuEntity.TabIndex = 2;
            this.menuEntity.Text = "menuStrip1";
            // 
            // EntityToolStripMenuItem
            // 
            this.EntityToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductMenu,
            this.продавецToolStripMenuItem,
            this.покупательToolStripMenuItem,
            this.чекToolStripMenuItem});
            this.EntityToolStripMenuItem.Name = "EntityToolStripMenuItem";
            this.EntityToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.EntityToolStripMenuItem.Text = "Сущности";
            // 
            // ProductMenu
            // 
            this.ProductMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem2});
            this.ProductMenu.Name = "ProductMenu";
            this.ProductMenu.Size = new System.Drawing.Size(139, 22);
            this.ProductMenu.Text = "Товар";
            this.ProductMenu.Click += new System.EventHandler(this.ProductMenu_Click);
            // 
            // добавитьToolStripMenuItem2
            // 
            this.добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            this.добавитьToolStripMenuItem2.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem2.Text = "Добавить";
            this.добавитьToolStripMenuItem2.Click += new System.EventHandler(this.ProductAddMenu_Click);
            // 
            // продавецToolStripMenuItem
            // 
            this.продавецToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.продавецToolStripMenuItem.Name = "продавецToolStripMenuItem";
            this.продавецToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.продавецToolStripMenuItem.Text = "Продавец";
            this.продавецToolStripMenuItem.Click += new System.EventHandler(this.SellerMenu_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.SellerAddMenu_Click);
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.покупательToolStripMenuItem.Text = "Покупатель";
            this.покупательToolStripMenuItem.Click += new System.EventHandler(this.CustomerMenu_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.CustomerAddMenu_Click);
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.чекToolStripMenuItem.Text = "Чек";
            this.чекToolStripMenuItem.Click += new System.EventHandler(this.BillMenu_Click);
            // 
            // моделированиеToolStripMenuItem
            // 
            this.моделированиеToolStripMenuItem.Name = "моделированиеToolStripMenuItem";
            this.моделированиеToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.моделированиеToolStripMenuItem.Text = "Моделирование";
            this.моделированиеToolStripMenuItem.Click += new System.EventHandler(this.ModelMenuItem_Click);
            // 
            // productBox
            // 
            this.productBox.FormattingEnabled = true;
            this.productBox.Location = new System.Drawing.Point(12, 57);
            this.productBox.Name = "productBox";
            this.productBox.Size = new System.Drawing.Size(202, 355);
            this.productBox.TabIndex = 3;
            this.productBox.DoubleClick += new System.EventHandler(this.productBox_DoubleClick);
            // 
            // cartBox
            // 
            this.cartBox.FormattingEnabled = true;
            this.cartBox.Location = new System.Drawing.Point(254, 57);
            this.cartBox.Name = "cartBox";
            this.cartBox.Size = new System.Drawing.Size(214, 355);
            this.cartBox.TabIndex = 4;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(474, 57);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(114, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(251, 415);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(34, 13);
            this.sumLabel.TabIndex = 6;
            this.sumLabel.Text = "Sum: ";
            // 
            // BuyButton
            // 
            this.BuyButton.Enabled = false;
            this.BuyButton.Location = new System.Drawing.Point(474, 86);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(114, 23);
            this.BuyButton.TabIndex = 7;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(473, 31);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(94, 13);
            this.loginLabel.TabIndex = 8;
            this.loginLabel.TabStop = true;
            this.loginLabel.Text = "Click here, to login";
            this.loginLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cartBox);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.menuEntity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuEntity.ResumeLayout(false);
            this.menuEntity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEntity;
        private System.Windows.Forms.ToolStripMenuItem EntityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProductMenu;
        private System.Windows.Forms.ToolStripMenuItem продавецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem покупательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem моделированиеToolStripMenuItem;
        private System.Windows.Forms.ListBox productBox;
        private System.Windows.Forms.ListBox cartBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.LinkLabel loginLabel;
    }
}

