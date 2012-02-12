namespace FatCatPomodoro.ViewModels
{
    public class ViewLocator
    {
        public static MainViewModel MainViewModel { get; private set; }
        public static bool ViewsCreated { get; set; }

        private static void CreateViewModels()
        {
            if (ViewsCreated) return;

            MainViewModel = new MainViewModel();
        }

        static ViewLocator()
        {
            CreateViewModels();
        }
    }
}