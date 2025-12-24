using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using System;
using System.Collections.Generic;

namespace MayinTarlasi.Avalonia;

public partial class MainWindow : Window
{
    private const int TotalCells = 68;
    private const int TotalMines = 15;
    
    private readonly HashSet<int> _mines = new();
    private int _selectedCount = 0;
    private int _foundMines = 0;
    private readonly Random _random = new();

    // Colors
    private static readonly IBrush DefaultBg = new SolidColorBrush(Color.Parse("#2d4a6e"));
    private static readonly IBrush DefaultBorder = new SolidColorBrush(Color.Parse("#3d5a7e"));
    private static readonly IBrush MineBg = new SolidColorBrush(Color.Parse("#e94560"));
    private static readonly IBrush MineBorder = new SolidColorBrush(Color.Parse("#ff6b85"));
    private static readonly IBrush SafeBg = new SolidColorBrush(Color.Parse("#4ecca3"));
    private static readonly IBrush SafeBorder = new SolidColorBrush(Color.Parse("#6eecc3"));
    private static readonly IBrush TextLight = new SolidColorBrush(Color.Parse("#eaeaea"));
    private static readonly IBrush TextDark = new SolidColorBrush(Color.Parse("#1a1a2e"));

    public MainWindow()
    {
        InitializeComponent();
        StartNewGame();
    }

    private void StartNewGame()
    {
        // Reset state
        _mines.Clear();
        _selectedCount = 0;
        _foundMines = 0;
        
        // Hide win overlay
        winOverlay.IsVisible = false;

        // Generate random mines
        while (_mines.Count < TotalMines)
        {
            int minePos = _random.Next(1, TotalCells + 1);
            _mines.Add(minePos);
        }

        // Clear and create cells
        gameBoard.Children.Clear();
        
        for (int i = 1; i <= TotalCells; i++)
        {
            var btn = new Button
            {
                Content = i.ToString(),
                Tag = i,
                Classes = { "cell" },
                Background = DefaultBg,
                BorderBrush = DefaultBorder,
                Foreground = TextLight
            };
            
            btn.Click += OnCellClick;
            gameBoard.Children.Add(btn);
        }

        UpdateStats();
    }

    private void OnCellClick(object? sender, RoutedEventArgs e)
    {
        if (sender is not Button btn || !btn.IsEnabled) return;

        int cellNumber = (int)btn.Tag!;
        bool isMine = _mines.Contains(cellNumber);

        btn.IsEnabled = false;
        btn.Classes.Remove("cell");

        if (isMine)
        {
            // Mine found
            btn.Background = MineBg;
            btn.BorderBrush = MineBorder;
            btn.Foreground = TextLight;
            btn.Content = "💣";
            btn.Classes.Add("cell");
            btn.Classes.Add("mine");
            
            _foundMines++;
        }
        else
        {
            // Safe cell
            btn.Background = SafeBg;
            btn.BorderBrush = SafeBorder;
            btn.Foreground = TextDark;
            btn.Content = "✓";
            btn.Classes.Add("cell");
            btn.Classes.Add("safe");
            
            _selectedCount++;
        }

        UpdateStats();

        // Check win condition
        if (_foundMines == TotalMines)
        {
            ShowWinMessage();
        }
    }

    private void UpdateStats()
    {
        txtSecilen.Text = _selectedCount.ToString();
        txtBulunan.Text = _foundMines.ToString();
        txtKalan.Text = (TotalMines - _foundMines).ToString();
    }

    private void ShowWinMessage()
    {
        winOverlay.IsVisible = true;
    }

    private void OnNewGameClick(object? sender, RoutedEventArgs e)
    {
        StartNewGame();
    }
}

