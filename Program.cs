namespace SunspireQueue
{
    internal static class Program
    {
        private static Form1 _form;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


          

            var _hookID = InterceptKeys.SetHook(KeysCB);
          
            _form = new Form1();
            Application.Run(_form);
            InterceptKeys.UnhookWindowsHookEx(_hookID);
        }

        private static void KeysCB(Keys key)
        {
            _form.PushKey(key);
        }
    }
}