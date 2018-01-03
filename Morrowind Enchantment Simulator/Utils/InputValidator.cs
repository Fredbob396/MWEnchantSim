using System.Linq;
using System.Media;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Morrowind_Enchantment_Simulator
{
    class InputValidator
    {
        /// <summary>
        /// Validates textbox keypresses to only allow values that are valid floats
        /// </summary>
        public static void ValidateFloat_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            bool hasDecimal = textBox.Text.Contains('.');
            bool backspace = e.KeyChar.Equals('\b');

            //Suppress anything other than numbers, decimals, and the backspace key
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^.]") && !backspace)
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                return;
            }

            //Suppress extra decimals
            if (hasDecimal && e.KeyChar.Equals('.'))
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
                return;
            }

            //Special cases for single-character boxes
            if (textBox.Text.Length == 1)
            {
                // Replace only character with 0 if backspace
                if (backspace)
                {
                    textBox.Text = "0";
                    textBox.Select(textBox.Text.Length, 0);
                    e.Handled = true;
                    return;
                }
                // Replace last character with typed character if not a decimal
                if (textBox.Text.Equals("0") && !e.KeyChar.Equals('.'))
                {
                    textBox.Text = e.KeyChar.ToString();
                    textBox.Select(textBox.Text.Length, 0);
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// Validates that the textbox still contains a valid float on KeyUp.
        /// This can happen if the textbox is erased after highlighting the entire box
        /// </summary>
        public static void ValidateFloat_KeyUp(object sender, KeyEventArgs e)
        {
            // Check for if changes whole box with highlight
            TextBox textBox = (TextBox)sender;
            if (textBox.Text.Equals("") || textBox.Text.Equals("."))
            {
                textBox.Text = "0";
            }
        }
    }
}
