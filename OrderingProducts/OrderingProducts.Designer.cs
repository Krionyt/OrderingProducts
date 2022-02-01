namespace OrderingProducts
{
    partial class OrderingProducts
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenProductsDirectoryButton = new System.Windows.Forms.Button();
            this.OpenUnitDirectoryButton = new System.Windows.Forms.Button();
            this.OpenGroupsProductDirectoryButton = new System.Windows.Forms.Button();
            this.OpenOrdersStatusDirectoryButton = new System.Windows.Forms.Button();
            this.OpenOrdersDocumentButton = new System.Windows.Forms.Button();
            this.OpenReportForCollectorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenProductsDirectoryButton
            // 
            this.OpenProductsDirectoryButton.Location = new System.Drawing.Point(12, 21);
            this.OpenProductsDirectoryButton.Name = "OpenProductsDirectoryButton";
            this.OpenProductsDirectoryButton.Size = new System.Drawing.Size(264, 23);
            this.OpenProductsDirectoryButton.TabIndex = 0;
            this.OpenProductsDirectoryButton.Text = "Открыть справочник \"Товары\"";
            this.OpenProductsDirectoryButton.UseVisualStyleBackColor = true;
            this.OpenProductsDirectoryButton.Click += new System.EventHandler(this.OpenProductsDirectoryButton_Click);
            // 
            // OpenUnitDirectoryButton
            // 
            this.OpenUnitDirectoryButton.Location = new System.Drawing.Point(12, 50);
            this.OpenUnitDirectoryButton.Name = "OpenUnitDirectoryButton";
            this.OpenUnitDirectoryButton.Size = new System.Drawing.Size(264, 23);
            this.OpenUnitDirectoryButton.TabIndex = 1;
            this.OpenUnitDirectoryButton.Text = "Открыть справочник \"Единицы измерения\"";
            this.OpenUnitDirectoryButton.UseVisualStyleBackColor = true;
            this.OpenUnitDirectoryButton.Click += new System.EventHandler(this.OpenUnitDirectoryButton_Click);
            // 
            // OpenGroupsProductDirectoryButton
            // 
            this.OpenGroupsProductDirectoryButton.Location = new System.Drawing.Point(12, 79);
            this.OpenGroupsProductDirectoryButton.Name = "OpenGroupsProductDirectoryButton";
            this.OpenGroupsProductDirectoryButton.Size = new System.Drawing.Size(264, 23);
            this.OpenGroupsProductDirectoryButton.TabIndex = 2;
            this.OpenGroupsProductDirectoryButton.Text = "Открыть спрвочник \"Группы товаров\"";
            this.OpenGroupsProductDirectoryButton.UseVisualStyleBackColor = true;
            this.OpenGroupsProductDirectoryButton.Click += new System.EventHandler(this.OpenGroupsProductDirectoryButton_Click);
            // 
            // OpenOrdersStatusDirectoryButton
            // 
            this.OpenOrdersStatusDirectoryButton.Location = new System.Drawing.Point(12, 108);
            this.OpenOrdersStatusDirectoryButton.Name = "OpenOrdersStatusDirectoryButton";
            this.OpenOrdersStatusDirectoryButton.Size = new System.Drawing.Size(264, 23);
            this.OpenOrdersStatusDirectoryButton.TabIndex = 3;
            this.OpenOrdersStatusDirectoryButton.Text = "Открыть спрвочник \"Статусы заказов\"";
            this.OpenOrdersStatusDirectoryButton.UseVisualStyleBackColor = true;
            this.OpenOrdersStatusDirectoryButton.Click += new System.EventHandler(this.OpenOrdersStatusDirectoryButton_Click);
            // 
            // OpenOrdersDocumentButton
            // 
            this.OpenOrdersDocumentButton.Location = new System.Drawing.Point(12, 137);
            this.OpenOrdersDocumentButton.Name = "OpenOrdersDocumentButton";
            this.OpenOrdersDocumentButton.Size = new System.Drawing.Size(264, 23);
            this.OpenOrdersDocumentButton.TabIndex = 4;
            this.OpenOrdersDocumentButton.Text = "Открыть документ \"Заказы\"";
            this.OpenOrdersDocumentButton.UseVisualStyleBackColor = true;
            this.OpenOrdersDocumentButton.Click += new System.EventHandler(this.OpenOrdersDocumentButton_Click);
            // 
            // OpenReportForCollectorButton
            // 
            this.OpenReportForCollectorButton.Location = new System.Drawing.Point(12, 166);
            this.OpenReportForCollectorButton.Name = "OpenReportForCollectorButton";
            this.OpenReportForCollectorButton.Size = new System.Drawing.Size(264, 23);
            this.OpenReportForCollectorButton.TabIndex = 5;
            this.OpenReportForCollectorButton.Text = "Открыть отчет \"Отчет для сборщика\"";
            this.OpenReportForCollectorButton.UseVisualStyleBackColor = true;
            this.OpenReportForCollectorButton.Click += new System.EventHandler(this.OpenReportForCollectorButton_Click);
            // 
            // OrderingProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 210);
            this.Controls.Add(this.OpenReportForCollectorButton);
            this.Controls.Add(this.OpenOrdersDocumentButton);
            this.Controls.Add(this.OpenOrdersStatusDirectoryButton);
            this.Controls.Add(this.OpenGroupsProductDirectoryButton);
            this.Controls.Add(this.OpenUnitDirectoryButton);
            this.Controls.Add(this.OpenProductsDirectoryButton);
            this.Name = "OrderingProducts";
            this.Text = "Заказ товаров";
            this.ResumeLayout(false);

        }

        #endregion

        private Button OpenProductsDirectoryButton;
        private Button OpenUnitDirectoryButton;
        private Button OpenGroupsProductDirectoryButton;
        private Button OpenOrdersStatusDirectoryButton;
        private Button OpenOrdersDocumentButton;
        private Button OpenReportForCollectorButton;
    }
}