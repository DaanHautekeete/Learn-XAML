namespace Learn_.NET_MAUI
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Pressed(object sender, EventArgs e)
        {
            string strName = "";


            if (txtName.Text != string.Empty)
            {
                strName = txtName.Text;
                BtnSubmit.Text = strName;
            }
            else
            {
                BtnSubmit.Text = "Confirm name!";
                Application.Current.MainPage.DisplayAlert("Error", "Please enter a name", "ok");
            }

        }
    }

}
