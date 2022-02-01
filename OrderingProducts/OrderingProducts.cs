namespace OrderingProducts
{
    public partial class OrderingProducts : Form
    {
        public OrderingProducts()
        {
            InitializeComponent();
        }

        private void OpenProductsDirectoryButton_Click(object sender, EventArgs e)
        {
            ProductDirectory productDirectoryFrom = new ProductDirectory();
            productDirectoryFrom.ShowDialog();
        }

        private void OpenUnitDirectoryButton_Click(object sender, EventArgs e)
        {
            UnitDirectory unitDirectoryForm = new UnitDirectory();
            unitDirectoryForm.ShowDialog();
        }

        private void OpenGroupsProductDirectoryButton_Click(object sender, EventArgs e)
        {
            GroupsProductDirectory groupsProductDirectoryForm = new GroupsProductDirectory();
            groupsProductDirectoryForm.ShowDialog();
        }

        private void OpenOrdersStatusDirectoryButton_Click(object sender, EventArgs e)
        {
            OrdersStatusDirectory ordersStatusDirectorForm = new OrdersStatusDirectory();
            ordersStatusDirectorForm.ShowDialog();
        }

        private void OpenOrdersDocumentButton_Click(object sender, EventArgs e)
        {
            OrdersDocument ordersDocumentForm = new OrdersDocument();
            ordersDocumentForm.ShowDialog();
        }

        private void OpenReportForCollectorButton_Click(object sender, EventArgs e)
        {
            ReportForCollector reportForCollectorForm = new ReportForCollector();
            reportForCollectorForm.ShowDialog();
        }
    }
}