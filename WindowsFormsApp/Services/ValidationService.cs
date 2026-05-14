using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PensilShop.Services
{
    internal class ValidationService
    {
        private static readonly ErrorProvider errorProvider = new ErrorProvider();

        public static void General_Validating(object sender, CancelEventArgs e)
        {
            var control = sender as Control;
            if (control != null)
            {
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    errorProvider.SetError(control, "Необходимо заполнить поле");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(control, string.Empty);
                }
            }
        }
    }
}
