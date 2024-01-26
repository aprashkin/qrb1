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

public partial class Registration : Window
{
    private NpgsqlDataSource dataSource;
    
    public static List<Users> Users = new();
    public Registration()
    {
        var connectionString = "";
        dataSource = NpgsqlDataSource.Create(connectionString);
        InitializeComponent();
        vas();
    }

    private void vas()
    {
        using (var cmd = dataSource.CreateCommand($"select username from autorise where id = 2"))
        { 
            var reader = cmd.ExecuteReader();
            reader.Read();
            Login1.Watermark = reader[0].ToString();
        }

    
    }
    
    public string log;
    public string par1;
    public string par2;

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {

    
        Login1.Text = log;
        parol1.Text = par1;
        parol2.Text = par2;
        

        if (string.IsNullOrEmpty(log))
        {
            Login1.Watermark = "Необходимо заполнить";
            Login1.Foreground = Brushes.Red;
        }

        if (string.IsNullOrEmpty(par1))
        {
            parol1.Watermark = "Необходимо заполнить";
            parol1.Foreground = Brushes.Red;
        }

        if (string.IsNullOrEmpty(par2))
        {
            parol2.Watermark = "Необходимо заполнить";
            parol2.Foreground = Brushes.Red;
        }
        
        if (!string.IsNullOrEmpty(log) || !string.IsNullOrEmpty(par1) ||
            !string.IsNullOrEmpty(par2))
        {
            using (var cmd = dataSource.CreateCommand("INSERT INTO autorise (username, password) VALUES ($1, $2)"))
            {
                cmd.Parameters.AddWithValue(Login1.Text);
                cmd.Parameters.AddWithValue(ParolText2.Text);
                cmd.ExecuteNonQuery();
            }
        }
        
        MainWindow main = new MainWindow();                          
        main.Show();
        this.Close();
    }
    private void perehod_na_vhod(object? sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }

}
