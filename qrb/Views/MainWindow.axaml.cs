using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using qrb.Models;

namespace qrb.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void perehod_na_reg(object? sender, RoutedEventArgs e)
    {
        new Registration().Show();
        Close();
    }

    /*private bool ValidateUserCredentials(string enteredUsername, string enteredPassword)
    {
        // Здесь предполагается, что у вас есть список пользовательских данных
        Users users = Registrationn;

        // Перебираем элементы списка и сверяем логин и пароль
        foreach (Users user in users)
        {
            if (userCredentials.Username == enteredUsername && userCredentials.Password == enteredPassword)
            {
                // Логин и пароль совпадают, пользователь успешно вошел
                return true;
            }
        }

        // Если не найдено совпадение, пользователь не смог войти
        return false;
    }*/

    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        string enteredUsername = LogText.Text;
        string enteredPassword = ParolText.Text;

        /*bool loginSuccessful = ValidateUserCredentials(enteredUsername, enteredPassword);*/
/**/
        /*if (loginSuccessful)
        {
            // Скрываем текущее окно
            this.Hide();

            // Здесь можно открыть новое окно (замените MainWindow на ваш класс основного окна)
            MainWindow mainWindow = new MainWindow();
            mainWindow.Closed += (s, args) => this.Close(); // Закрываем текущее окно при закрытии нового
            mainWindow.Show();
        }
        else
        {
            ErrorBorder.IsVisible = true;
        }*/
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /*private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        
        Users users = Registration.Users.FirstOrDefault(u => u.Username == LogText.Text && u.Password == ParolText.Text);w

        if (users is null)
        {
            ErrorBorder.IsVisible = true;
        }
        else
        {
            new MainMenu().Show();
            this.Close();
        }
    }*/
}