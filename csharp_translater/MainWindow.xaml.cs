using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;

namespace csharp_translater
{
	public partial class MainWindow : Window
	{
		List<char> simbols = new List<char>();
		string source_text;
		string new_text;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Translate_Click(object sender, RoutedEventArgs e)
		{
			/*source_text = tb_sourceText.Text;

			ReplaceMethod('а', 593);

			ReplaceMethod('Б', 387);
			ReplaceMethod('б', 948);

			ReplaceMethod('В', 385);
			ReplaceMethod('в', 223);

			ReplaceMethod('Ж', 1174);
			ReplaceMethod('ж', 1175);

			ReplaceMethod('З', 400);
			ReplaceMethod('з', 11469);

			ReplaceMethod('и', 1008);

			ReplaceMethod('К', 408);
			ReplaceMethod('к', 409);

			ReplaceMethod('М', 5691);
			ReplaceMethod('м', 1019);

			ReplaceMethod('н', 4824);

			ReplaceMethod('о', 7441);

			ReplaceMethod('п', 960);

			ReplaceMethod('Р', 11471);
			ReplaceMethod('р', 421);

			ReplaceMethod('С', 11428);
			ReplaceMethod('с', 11429);

			ReplaceMethod('Т', 428);
			ReplaceMethod('т', 964);

			ReplaceMethod('У', 5053);

			ReplaceMethod('Ф', 11434);
			ReplaceMethod('ф', 8750);

			ReplaceMethod('Х', 967);
			ReplaceMethod('х', 215);

			ReplaceMethod('Ц', 1204);
			ReplaceMethod('ц', 4642);

			ReplaceMethod('Ч', 1206);
			ReplaceMethod('ч', 2931);

			ReplaceMethod('Ш', 412);
			ReplaceMethod('ш', 4640);

			ReplaceMethod('Щ', 994);
			ReplaceMethod('щ', 995);

			ReplaceMethod('ь', 222);

			ReplaceMethod('э', 1014);

			ReplaceMethod('я', 7449);

			ReplaceMethod('1', 10102);
			ReplaceMethod('2', 10103);
			ReplaceMethod('3', 10104);
			ReplaceMethod('4', 10105);
			ReplaceMethod('5', 10106);
			ReplaceMethod('6', 10107);
			ReplaceMethod('7', 10108);
			ReplaceMethod('8', 10109);
			ReplaceMethod('9', 10110);

			ReplaceMethod('+', 10133);
			ReplaceMethod('-', 10134);
			ReplaceMethod('!', 10069);
			ReplaceMethod('?', 10067);

			tb_resultText.Text = new_text;*/

			using (StreamWriter sw = new StreamWriter("all_chars.txt"))
			{
				for (int i = 0; i < 100000; i++)
				{
					sw.WriteLine(i + "\t\t" + Convert.ToChar(i));
				}
			}

		}

		private void ReplaceMethod(char _c, int _sym)
		{
			source_text = source_text.Replace(_c, Convert.ToChar(_sym));
			new_text = source_text;
		}

		private void Settings_Click(object sender, RoutedEventArgs e)
		{
			SettingsWindow w = new SettingsWindow();
			w.Show();
		}
	}
}