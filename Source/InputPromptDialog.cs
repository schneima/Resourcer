using System;
using System.Windows.Forms;

namespace Resourcer
{
    public static class InputPromptDialog
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
                          {
                              Width = 300,
                              Height = 150,
                              FormBorderStyle = FormBorderStyle.FixedDialog,
                              Text = caption,
                              StartPosition = FormStartPosition.CenterScreen
                          };
            Label textLabel = new Label() { Left = 10, Top = 10, Text = text };
            var textBoxLeft = 10;
            var textBoxWidth = prompt.Width - (textBoxLeft * 2) - 15;
            TextBox textBox = new TextBox() { Left = textBoxLeft, Top = 30, Width = textBoxWidth };
            var buttonWidth = 100;
            var buttonLeft = (prompt.Width / 2) - (buttonWidth / 2);
            Button confirmation = new Button() { Text = "OK", Left = buttonLeft, Width = buttonWidth, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}