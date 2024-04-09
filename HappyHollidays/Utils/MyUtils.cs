using System;
using System.Windows.Forms;

namespace HappyHollidays.Utils
{
    public static class MyUtils
    {
        /// <summary>
        /// Muestra el diálogo de confirmación de cierre antes de cerrar la aplicación
        /// </summary>
        /// <param name="e"></param>
        public static void ShowConfirmDialogAndExit(FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que quieres salir?",
                "¡No te vayas!",
                buttons);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// muestra el diálogo deconfirmaciónd de borrado
        /// </summary>
        /// <returns>true si confirma, false si cancela</returns>
        public static bool ShowConfirmDialogAndDelete()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que quieres borrar el elemento seleccionado?",
                "¡Cuidado!",
                buttons);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Chequea si se ha podido realizar la acción en la BBDD
        /// y muestra la respuesta en un diálogo
        /// </summary>
        /// <param name="msg">string con el error que se haya podido dar</param>
        public static void ShowPosibleError(String msg)
        {
            if (msg != "")
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Operación realizada con éxito.", "¡Maravilloso!");
            }
        }

        /// <summary>
        /// Parsea a int un string
        /// </summary>
        /// <param name="wordToParse">el string a parsear</param>
        /// <returns>el valor del int ya parseado</returns>
        internal static int ParseNumfromString(string wordToParse)
        {
            int category = -1;
            string categoryValue = wordToParse;
            if (int.TryParse(categoryValue, out int parsedNumber))
            {
                category = parsedNumber;
            }
            return category;
        }
    }
}
