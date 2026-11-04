using PropertyChanged;
using SkladCv2_2026.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SkladCv2_2026.ViewModels
{
    public class MainWindowVM
    {
        [AddINotifyPropertyChangedInterface]
        public class MainWindow : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler? PropertyChanged;

            public bool PovolitTabulky { get; set; } = true;

            public RelayCommand OpenMaterialCommand { get; }
            public RelayCommand OpenPaletyCommand { get; }
            public RelayCommand OpenPrehledMaterialuCommand { get; }
            public RelayCommand OpenPrehledPaletCommand { get; }

            public MainWindow()
            {
                OpenMaterialCommand = new RelayCommand(
                    ExecuteOpenMaterial,
                    _ => PovolitTabulky
                );

                OpenPaletyCommand = new RelayCommand(
                    ExecuteOpenPalety,
                    _ => PovolitTabulky
                );

                OpenPrehledMaterialuCommand = new RelayCommand(ExecuteOpenPrehledMaterialu);
                OpenPrehledPaletCommand = new RelayCommand(ExecuteOpenPrehledPalet);
            }

            private void ExecuteOpenMaterial(object? parameter)
            {
            }

            private void ExecuteOpenPalety(object? parameter)
            {
            }

            private void ExecuteOpenPrehledMaterialu(object? parameter)
            {
            }

            private void ExecuteOpenPrehledPalet(object? parameter)
            {
            }
        }
    }
}