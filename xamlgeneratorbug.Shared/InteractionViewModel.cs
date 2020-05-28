using GalaSoft.MvvmLight;
using System;
using Windows.Storage;
using Windows.UI.Xaml;

namespace xamlgeneratorbug
{
    public class InteractionViewModel : ViewModelBase
    {
        private Thickness _TabsLeftMargin = new Thickness(200, 0, 0, 0);

        public Thickness TabsLeftMargin
        {
            get => _TabsLeftMargin;
            set => Set(ref _TabsLeftMargin, value);
        }

        private bool _LeftMarginLoaded = true;

        public bool LeftMarginLoaded
        {
            get => _LeftMarginLoaded;
            set => Set(ref _LeftMarginLoaded, value);
        }

        private StorageDeleteOption _PermanentlyDelete = StorageDeleteOption.Default;

        public StorageDeleteOption PermanentlyDelete
        {
            get => _PermanentlyDelete;
            set => Set(ref _PermanentlyDelete, value);
        }

        private bool _IsSelectedItemImage = false;

        public bool IsSelectedItemImage
        {
            get => _IsSelectedItemImage;
            set => Set(ref _IsSelectedItemImage, value);
        }

        private bool _IsPageTypeNotHome = false;

        public bool IsPageTypeNotHome
        {
            get => _IsPageTypeNotHome;
            set => Set(ref _IsPageTypeNotHome, value);
        }
    }
}