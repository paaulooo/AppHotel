namespace AppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_room.ItemsSource = PropriedadesApp.ListaQuartos;

        dtp_check_in.MinimumDate = DateTime.Now;
        dtp_check_in.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtp_check_out.MinimumDate = dtp_check_in.Date.AddDays(1);
        dtp_check_out.MaximumDate = dtp_check_in.Date.AddMonths(6);



    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            await Navigation.PushAsync(new Sobre());
        }
        catch(Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
        
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    private void dtp_check_in_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker element = sender as DatePicker;

        DateTime data_selecionada_check_in = element.Date;
        dtp_check_out.MinimumDate = data_selecionada_check_in.AddDays(1);
        dtp_check_out.MaximumDate = data_selecionada_check_in.AddMonths(6);
    }
}