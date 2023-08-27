using IdentityServer_Desktop.Models.DB;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentityServer_Desktop
{
    public partial class Welcome : Form
    {
        public bool IsAuthenticated { get; set; } = false;

        public Welcome()
        {
            InitializeComponent();
            // Initial state setup
            loader.Visible = false;
            productsDataGrid.Visible = false;
            authenticateBtn.Visible = true;
        }

        private async void authenticateBtn_Click(object sender, EventArgs e)
        {
            if (!ProcessAuthentication())
            {
                // If authentication fails, you may want to notify the user or take some other action.
                MessageBox.Show("Authentication failed!");
                return;
            }

            ToggleUIElementsForLoading(true);

            try
            {
                await LoadProductsDataAsync();
            }
            catch (Exception)
            {
                ToggleUIElementsForLoading(false);
                MessageBox.Show("An error occurred while loading the data.");
                return;
            }
        }

        private async Task LoadProductsDataAsync()
        {
            var data = await FetchProductsFromDatabase().ConfigureAwait(false);

            productsDataGrid.Invoke(new Action(() =>
            {
                productsDataGrid.DataSource = data;

                if (productsDataGrid.Columns["Orders"] != null)
                    productsDataGrid.Columns["Orders"].Visible = false;

                ToggleUIElementsForLoading(false);
            }));
        }

        private async Task<List<Product>> FetchProductsFromDatabase()
        {
            return await Task.Run(() =>
            {
                using var context = new ZpidentityServerContext();
                return context.Products.ToList();
            });
        }

        private bool ProcessAuthentication()
        {
            IsAuthenticated = true;
            // Your authentication logic here
            return IsAuthenticated;
        }

        private void ToggleUIElementsForLoading(bool isLoading)
        {
            loader.Visible = isLoading;
            authenticateBtn.Visible = false; // This should always be hidden after its initial click
            productsDataGrid.Visible = !isLoading;
        }
    }
}
