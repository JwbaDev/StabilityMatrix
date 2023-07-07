﻿using FluentAvalonia.UI.Controls;

namespace StabilityMatrix.Avalonia.ViewModels;

/// <summary>
/// An abstract class for enabling page navigation.
/// </summary>
public abstract class PageViewModelBase : ViewModelBase
{
    /// <summary>
    /// Gets if the user can navigate to the next page
    /// </summary>
    public abstract bool CanNavigateNext { get; protected set; }

    /// <summary>
    /// Gets if the user can navigate to the previous page
    /// </summary>
    public abstract bool CanNavigatePrevious { get; protected set; }
    
    public abstract string Title { get; }
    public abstract Symbol Icon { get; }
}
