﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Skolplattformen.ElevApp.Data;

namespace Skolplattformen.ElevApp.ViewModels
{
    public partial class SettingsViewModel: ObservableObject
    {
        [ObservableProperty] private string skolmatenSeSchoolName;
        [ObservableProperty] private bool useSkolmatenSe;
        [ObservableProperty] private bool showCalendarInTodayView;
        [ObservableProperty] private bool showPlannedAbsenceInTodayView;
        [ObservableProperty] private bool showKalendariumInTodayView;


        [RelayCommand]
        public void Save()
        {
            Settings.UseSkolmatenSe = useSkolmatenSe;
            Settings.SkolmatenSeSchoolName = skolmatenSeSchoolName;
            Settings.ShowCalendarInTodayView = showCalendarInTodayView;
            Settings.ShowPlannedAbsenceInTodayView = showPlannedAbsenceInTodayView;
            Settings.ShowKalendariumInTodayView = showKalendariumInTodayView;
        }


        public Task LoadData()
        {
            UseSkolmatenSe = Settings.UseSkolmatenSe;
            SkolmatenSeSchoolName = Settings.SkolmatenSeSchoolName;
            ShowCalendarInTodayView = Settings.ShowCalendarInTodayView;
            ShowPlannedAbsenceInTodayView = Settings.ShowPlannedAbsenceInTodayView;
            ShowKalendariumInTodayView = Settings.ShowKalendariumInTodayView;

            return Task.CompletedTask;
        }

        public Task OnActivated()
        {
            return LoadData();
        }
    }

    
}