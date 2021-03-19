
namespace crmUI
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.nameBox = new System.Windows.Forms.TextBox();
            this.labelProduct = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.numericPrice = new System.Windows.Forms.NumericUpDown();
            this.labelCount = new System.Windows.Forms.Label();
            this.numericCount = new System.Windows.Forms.NumericUpDown();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(109, 54);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(138, 20);
            this.nameBox.TabIndex = 0;
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduct.Location = new System.Drawing.Point(54, 9);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(152, 26);
            this.labelProduct.TabIndex = 1;
            this.labelProduct.Text = "Product create";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 54);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(186, 205);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // numericPrice
            // 
            this.numericPrice.DecimalPlaces = 2;
            this.numericPrice.Location = new System.Drawing.Point(109, 98);
            this.numericPrice.Name = "numericPrice";
            this.numericPrice.Size = new System.Drawing.Size(138, 20);
            this.numericPrice.TabIndex = 4;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(12, 143);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(56, 20);
            this.labelCount.TabIndex = 5;
            this.labelCount.Text = "Count:";
            // 
            // numericCount
            // 
            this.numericCount.Location = new System.Drawing.Point(109, 146);
            this.numericCount.Name = "numericCount";
            this.numericCount.Size = new System.Drawing.Size(138, 20);
            this.numericCount.TabIndex = 6;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(12, 98);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(48, 20);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price:";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(283, 240);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.numericCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.numericPrice);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.nameBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductForm";
            this.Text = "Product Form";
            ((System.ComponentModel.ISupportInitialize)(this.numericPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown numericPrice;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.NumericUpDown numericCount;
        private System.Windows.Forms.Label labelPrice;
    }
}