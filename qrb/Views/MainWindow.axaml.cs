using System;
using System.Collections.Generic;
using System.Threading;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.OpenGL.Egl;
using qrb.Models;
using Npgsql;

namespace qrb.Views;

public partial class MainWindow : Window
{
    private NpgsqlDataSource dataSource;
    
    
    private void vas()
    {
        using (var cmd = dataSource.CreateCommand($"select login from users where id = 1"))
        { 
            var reader = cmd.ExecuteReader();
            reader.Read();
        }
    }

    
    public MainWindow()
    {
        var connectionString = "Host=195.161.68.211;Port=49212;Username=danya;Password=vapeetozlo;Database=postgres";
        dataSource = NpgsqlDataSource.Create(connectionString);
        InitializeComponent();
        vas();
    }
    
    

    private void perehod_na_reg(object? sender, RoutedEventArgs e)
    {
        new Registration().Show();
        Close(); 
    }
    

    private void Button_OnClick(object sender, RoutedEventArgs e)
    {
        using (var cmd = dataSource.CreateCommand($"SELECT COUNT(*) FROM users WHERE login = @login AND password = @password"))
        {
            cmd.Parameters.AddWithValue("login", LogText.Text);
            cmd.Parameters.AddWithValue("password", ParolText.Text);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                int count = reader.GetInt32(0);
                if (count == 1)
                {
                    new MainMenu().Show();
                    Close();
                }
                else
                {
                    ErrorBlock.IsVisible = true;
                }
            }
        }
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