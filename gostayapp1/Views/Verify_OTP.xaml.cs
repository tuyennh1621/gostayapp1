namespace gostayapp1.Views;

public partial class Verify_OTP : ContentPage
{
	public Verify_OTP()
	{
        InitializeComponent();
    }

    static string strOTP = "";

    public bool checkOTP(string strOTP)
    {
        if (strOTP.Length >= 6) { return true; }
        return false;
    }
    public void grabOTP()
    {
        strOTP = Entry1.Text + Entry2.Text + Entry3.Text
            + Entry4.Text + Entry5.Text + Entry6.Text;
        btnTieptucPhone.IsEnabled = checkOTP(strOTP);
    }

    private void Entry1_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var text = entry.Text;

        if (text.Length >= 1)
        {
            Entry2.Focus();
        }
        grabOTP();
    }
    private void Entry2_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var text = entry.Text;

        if (text.Length >= 1)
        {
            Entry3.Focus();
        }
        if (string.IsNullOrEmpty(e.NewTextValue))
        {
            Entry1.Focus();
        }
        grabOTP();
    }
    private void Entry3_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var text = entry.Text;

        if (text.Length >= 1)
        {
            Entry4.Focus();
        }
        if (string.IsNullOrEmpty(e.NewTextValue))
        {
            Entry2.Focus();
        }
        grabOTP();
    }
    private void Entry4_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var text = entry.Text;

        if (text.Length >= 1)
        {
            Entry5.Focus();
        }
        if (string.IsNullOrEmpty(e.NewTextValue))
        {
            Entry3.Focus();
        }
        grabOTP();
    }
    private void Entry5_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var text = entry.Text;

        if (text.Length >= 1)
        {
            Entry6.Focus();
        }
        if (string.IsNullOrEmpty(e.NewTextValue))
        {
            Entry4.Focus();
        }
        grabOTP();

    }
    private void Entry6_TextChanged(object sender, TextChangedEventArgs e)
    {
        var entry = (Entry)sender;
        var text = entry.Text;

        if (string.IsNullOrEmpty(e.NewTextValue))
        {
            Entry5.Focus();
        }
        grabOTP();
    }

    private async void btnTieptucPhone_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Thông báo", "Đăng nhập thành công", "cancel");
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Entry1.Focus();
    }


    private void Entry1_Focused(object sender, FocusEventArgs e)
    {
    }

    private void Entry1_Completed(object sender, EventArgs e)
    {
        Entry2.Focus();
    }

    private void Entry2_Completed(object sender, EventArgs e)
    {
        Entry1.Focus();
    }
}