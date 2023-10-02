namespace PM_II_Tarea1;
using PM_II_Tarea1.Views;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSumar(object sender, EventArgs e)
    {
        if (validar())
        {
            labInfo.IsVisible = false;
            Double result = Double.Parse(txtNum1.Text) + Double.Parse(txtNum2.Text);

            mostrarResultado(result.ToString());
        }
    }

    private void OnRestar(object sender, EventArgs e)
    {
        if (validar())
        {
            labInfo.IsVisible = false;
            Double result = Double.Parse(txtNum1.Text) - Double.Parse(txtNum2.Text);

            mostrarResultado(result.ToString());
        }
    }

    private void OnDiv(object sender, EventArgs e)
    {
        if (validar())
        {
            labInfo.IsVisible = false;
            Double result = Double.Parse(txtNum1.Text) / Double.Parse(txtNum2.Text);

            mostrarResultado(result.ToString());
        }
    }

    private void OnMul(object sender, EventArgs e)
    {
        if (validar())
        {
            labInfo.IsVisible = false;
            Double result = Double.Parse(txtNum1.Text) * Double.Parse(txtNum2.Text);

            mostrarResultado(result.ToString());
        }
    }

    private bool validar()
    {

        String val1 = txtNum1.Text;
        String val2 = txtNum2.Text;
        if (val1 != null && val2 != null)
        {
            if (val1.Length > 0 && val2.Length > 0)
            {
                return true;
            }
            else
            {
                labInfo.Text = "Por favor complete todos los campos";
                labInfo.IsVisible = true;
                if (val1 == null)
                {
                    txtNum1.Focus();
                }
                return false;

            }
        }
        else
        {
            labInfo.Text = "Por favor complete todos los campos";
            labInfo.IsVisible = true;
            if (val1 == null)
            {
                txtNum1.Focus();
            }
            return false;
        }

    }


    private async void mostrarResultado(String result)
    {
        var PageResult = new PageResult();
        PageResult.BindingContext = result;

        await Navigation.PushAsync(PageResult);
    }
}
