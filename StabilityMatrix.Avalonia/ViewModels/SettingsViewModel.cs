﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Avalonia.Controls.Notifications;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FluentAvalonia.UI.Controls;
using StabilityMatrix.Avalonia.Services;
using StabilityMatrix.Avalonia.Views;
using StabilityMatrix.Core.Attributes;

namespace StabilityMatrix.Avalonia.ViewModels;

[View(typeof(SettingsPage))]
public partial class SettingsViewModel : PageViewModelBase
{
    private readonly INotificationService notificationService;
    
    public override string Title => "Settings";
    public override Symbol Icon => Symbol.Setting;
    
    [ObservableProperty]
    private string? selectedTheme;
    
    public ObservableCollection<string> AvailableThemes { get; } = new()
    {
        "Light",
        "Dark",
        "System",
    };

    public SettingsViewModel(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }
    
    [RelayCommand]
    private void DebugNotification()
    {
        notificationService.Show(new Notification(
            title: "Test Notification",
            message: "Here is some message",
            type: NotificationType.Information));
    }
    
    public override bool CanNavigateNext { get; protected set; }
    public override bool CanNavigatePrevious { get; protected set; }
}
