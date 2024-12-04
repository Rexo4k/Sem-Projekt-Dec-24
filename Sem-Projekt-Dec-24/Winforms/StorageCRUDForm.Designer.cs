﻿namespace Sem_Projekt_Dec_24.Winforms
{
    partial class StorageCRUDForm
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
            this.dgvStorageItems = new System.Windows.Forms.DataGridView();
            this.dgvStorageProducts = new System.Windows.Forms.DataGridView();
            this.btnStorageItemsUpdate = new System.Windows.Forms.Button();
            this.btnStorageProductsUpdate = new System.Windows.Forms.Button();
            this.txtbStorageItemsCategory = new System.Windows.Forms.TextBox();
            this.txtbStorageProductsId = new System.Windows.Forms.TextBox();
            this.txtbStorageItemsId = new System.Windows.Forms.TextBox();
            this.txtbStorageItemsName = new System.Windows.Forms.TextBox();
            this.txtbStorageProductsName = new System.Windows.Forms.TextBox();
            this.txtbStorageProductsCategory = new System.Windows.Forms.TextBox();
            this.btnStorageItemsCreate = new System.Windows.Forms.Button();
            this.btnStorageItemsDelete = new System.Windows.Forms.Button();
            this.btnStorageProductsDelete = new System.Windows.Forms.Button();
            this.btnStorageProductsCreate = new System.Windows.Forms.Button();
            this.btnStorageGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStorageItems
            // 
            this.dgvStorageItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageItems.Location = new System.Drawing.Point(2, 302);
            this.dgvStorageItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStorageItems.Name = "dgvStorageItems";
            this.dgvStorageItems.RowHeadersWidth = 62;
            this.dgvStorageItems.Size = new System.Drawing.Size(579, 391);
            this.dgvStorageItems.TabIndex = 0;
            // 
            // dgvStorageProducts
            // 
            this.dgvStorageProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorageProducts.Location = new System.Drawing.Point(576, 302);
            this.dgvStorageProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvStorageProducts.Name = "dgvStorageProducts";
            this.dgvStorageProducts.RowHeadersWidth = 62;
            this.dgvStorageProducts.Size = new System.Drawing.Size(624, 391);
            this.dgvStorageProducts.TabIndex = 1;
            // 
            // btnStorageItemsUpdate
            // 
            this.btnStorageItemsUpdate.Location = new System.Drawing.Point(216, 158);
            this.btnStorageItemsUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorageItemsUpdate.Name = "btnStorageItemsUpdate";
            this.btnStorageItemsUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnStorageItemsUpdate.TabIndex = 2;
            this.btnStorageItemsUpdate.Text = "Update";
            this.btnStorageItemsUpdate.UseVisualStyleBackColor = true;
            // 
            // btnStorageProductsUpdate
            // 
            this.btnStorageProductsUpdate.Location = new System.Drawing.Point(855, 158);
            this.btnStorageProductsUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorageProductsUpdate.Name = "btnStorageProductsUpdate";
            this.btnStorageProductsUpdate.Size = new System.Drawing.Size(112, 35);
            this.btnStorageProductsUpdate.TabIndex = 3;
            this.btnStorageProductsUpdate.Text = "Update";
            this.btnStorageProductsUpdate.UseVisualStyleBackColor = true;
            // 
            // txtbStorageItemsCategory
            // 
            this.txtbStorageItemsCategory.Location = new System.Drawing.Point(18, 235);
            this.txtbStorageItemsCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbStorageItemsCategory.Name = "txtbStorageItemsCategory";
            this.txtbStorageItemsCategory.Size = new System.Drawing.Size(148, 26);
            this.txtbStorageItemsCategory.TabIndex = 4;
            // 
            // txtbStorageProductsId
            // 
            this.txtbStorageProductsId.Location = new System.Drawing.Point(1032, 89);
            this.txtbStorageProductsId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbStorageProductsId.Name = "txtbStorageProductsId";
            this.txtbStorageProductsId.Size = new System.Drawing.Size(148, 26);
            this.txtbStorageProductsId.TabIndex = 5;
            // 
            // txtbStorageItemsId
            // 
            this.txtbStorageItemsId.Location = new System.Drawing.Point(20, 89);
            this.txtbStorageItemsId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbStorageItemsId.Name = "txtbStorageItemsId";
            this.txtbStorageItemsId.Size = new System.Drawing.Size(148, 26);
            this.txtbStorageItemsId.TabIndex = 6;
            // 
            // txtbStorageItemsName
            // 
            this.txtbStorageItemsName.Location = new System.Drawing.Point(20, 163);
            this.txtbStorageItemsName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbStorageItemsName.Name = "txtbStorageItemsName";
            this.txtbStorageItemsName.Size = new System.Drawing.Size(148, 26);
            this.txtbStorageItemsName.TabIndex = 7;
            // 
            // txtbStorageProductsName
            // 
            this.txtbStorageProductsName.Location = new System.Drawing.Point(1032, 163);
            this.txtbStorageProductsName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbStorageProductsName.Name = "txtbStorageProductsName";
            this.txtbStorageProductsName.Size = new System.Drawing.Size(148, 26);
            this.txtbStorageProductsName.TabIndex = 8;
            // 
            // txtbStorageProductsCategory
            // 
            this.txtbStorageProductsCategory.Location = new System.Drawing.Point(1032, 235);
            this.txtbStorageProductsCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbStorageProductsCategory.Name = "txtbStorageProductsCategory";
            this.txtbStorageProductsCategory.Size = new System.Drawing.Size(148, 26);
            this.txtbStorageProductsCategory.TabIndex = 9;
            // 
            // btnStorageItemsCreate
            // 
            this.btnStorageItemsCreate.Location = new System.Drawing.Point(216, 89);
            this.btnStorageItemsCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorageItemsCreate.Name = "btnStorageItemsCreate";
            this.btnStorageItemsCreate.Size = new System.Drawing.Size(112, 35);
            this.btnStorageItemsCreate.TabIndex = 10;
            this.btnStorageItemsCreate.Text = "Create";
            this.btnStorageItemsCreate.UseVisualStyleBackColor = true;
            this.btnStorageItemsCreate.Click += new System.EventHandler(this.btnStorageItemsCreate_Click);
            // 
            // btnStorageItemsDelete
            // 
            this.btnStorageItemsDelete.Location = new System.Drawing.Point(216, 231);
            this.btnStorageItemsDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorageItemsDelete.Name = "btnStorageItemsDelete";
            this.btnStorageItemsDelete.Size = new System.Drawing.Size(112, 35);
            this.btnStorageItemsDelete.TabIndex = 11;
            this.btnStorageItemsDelete.Text = "Delete";
            this.btnStorageItemsDelete.UseVisualStyleBackColor = true;
            // 
            // btnStorageProductsDelete
            // 
            this.btnStorageProductsDelete.Location = new System.Drawing.Point(855, 232);
            this.btnStorageProductsDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorageProductsDelete.Name = "btnStorageProductsDelete";
            this.btnStorageProductsDelete.Size = new System.Drawing.Size(112, 35);
            this.btnStorageProductsDelete.TabIndex = 12;
            this.btnStorageProductsDelete.Text = "Delete";
            this.btnStorageProductsDelete.UseVisualStyleBackColor = true;
            // 
            // btnStorageProductsCreate
            // 
            this.btnStorageProductsCreate.Location = new System.Drawing.Point(855, 89);
            this.btnStorageProductsCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorageProductsCreate.Name = "btnStorageProductsCreate";
            this.btnStorageProductsCreate.Size = new System.Drawing.Size(112, 35);
            this.btnStorageProductsCreate.TabIndex = 13;
            this.btnStorageProductsCreate.Text = "Create";
            this.btnStorageProductsCreate.UseVisualStyleBackColor = true;
            // 
            // btnStorageGoBack
            // 
            this.btnStorageGoBack.Location = new System.Drawing.Point(18, 18);
            this.btnStorageGoBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStorageGoBack.Name = "btnStorageGoBack";
            this.btnStorageGoBack.Size = new System.Drawing.Size(112, 35);
            this.btnStorageGoBack.TabIndex = 14;
            this.btnStorageGoBack.Text = "Go Back";
            this.btnStorageGoBack.UseVisualStyleBackColor = true;
            this.btnStorageGoBack.Click += new System.EventHandler(this.btnStorageGoBack_Click);
            // 
            // StorageCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnStorageGoBack);
            this.Controls.Add(this.btnStorageProductsCreate);
            this.Controls.Add(this.btnStorageProductsDelete);
            this.Controls.Add(this.btnStorageItemsDelete);
            this.Controls.Add(this.btnStorageItemsCreate);
            this.Controls.Add(this.txtbStorageProductsCategory);
            this.Controls.Add(this.txtbStorageProductsName);
            this.Controls.Add(this.txtbStorageItemsName);
            this.Controls.Add(this.txtbStorageItemsId);
            this.Controls.Add(this.txtbStorageProductsId);
            this.Controls.Add(this.txtbStorageItemsCategory);
            this.Controls.Add(this.btnStorageProductsUpdate);
            this.Controls.Add(this.btnStorageItemsUpdate);
            this.Controls.Add(this.dgvStorageProducts);
            this.Controls.Add(this.dgvStorageItems);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StorageCRUDForm";
            this.Text = "StorageCRUDForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorageProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStorageItems;
        private System.Windows.Forms.DataGridView dgvStorageProducts;
        private System.Windows.Forms.Button btnStorageItemsUpdate;
        private System.Windows.Forms.Button btnStorageProductsUpdate;
        private System.Windows.Forms.TextBox txtbStorageItemsCategory;
        private System.Windows.Forms.TextBox txtbStorageProductsId;
        private System.Windows.Forms.TextBox txtbStorageItemsId;
        private System.Windows.Forms.TextBox txtbStorageItemsName;
        private System.Windows.Forms.TextBox txtbStorageProductsName;
        private System.Windows.Forms.TextBox txtbStorageProductsCategory;
        private System.Windows.Forms.Button btnStorageItemsCreate;
        private System.Windows.Forms.Button btnStorageItemsDelete;
        private System.Windows.Forms.Button btnStorageProductsDelete;
        private System.Windows.Forms.Button btnStorageProductsCreate;
        private System.Windows.Forms.Button btnStorageGoBack;
    }
}