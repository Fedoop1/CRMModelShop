
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
            this.продавецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.покупательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEntity.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuEntity
            // 
            this.menuEntity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EntityToolStripMenuItem});
            this.menuEntity.Location = new System.Drawing.Point(0, 0);
            this.menuEntity.Name = "menuEntity";
            this.menuEntity.Size = new System.Drawing.Size(800, 24);
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
            this.ProductMenu.Name = "ProductMenu";
            this.ProductMenu.Size = new System.Drawing.Size(180, 22);
            this.ProductMenu.Text = "Товар";
            this.ProductMenu.Click += new System.EventHandler(this.ProductMenu_Click);
            // 
            // продавецToolStripMenuItem
            // 
            this.продавецToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.продавецToolStripMenuItem.Name = "продавецToolStripMenuItem";
            this.продавецToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.продавецToolStripMenuItem.Text = "Продавец";
            this.продавецToolStripMenuItem.Click += new System.EventHandler(this.SellerMenu_Click);
            // 
            // покупательToolStripMenuItem
            // 
            this.покупательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.покупательToolStripMenuItem.Name = "покупательToolStripMenuItem";
            this.покупательToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.покупательToolStripMenuItem.Text = "Покупатель";
            this.покупательToolStripMenuItem.Click += new System.EventHandler(this.CustomerMenu_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.CustomerAddMenu_Click);
            // 
            // чекToolStripMenuItem
            // 
            this.чекToolStripMenuItem.Name = "чекToolStripMenuItem";
            this.чекToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.чекToolStripMenuItem.Text = "Чек";
            this.чекToolStripMenuItem.Click += new System.EventHandler(this.BillMenu_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.SellerAddMenu_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuEntity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "crmUI";
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
    }
}

