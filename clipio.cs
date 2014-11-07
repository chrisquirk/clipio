using System;
using System.Text;
using System.Windows.Forms;

public class Program
{
	[STAThread]
	public static void Main(string[] args)
	{
		if (args.Length != 1) Usage();
		if (string.Compare(args[0].ToLower(), "read") == 0)
		{
			Console.Write(Clipboard.GetText());
			return;
		}
		if (string.Compare(args[0].ToLower(), "write") == 0)
		{
			var sb = new StringBuilder();
			string line;
			while (null != (line = Console.ReadLine()))
				sb.AppendLine(line);
			Clipboard.SetText(sb.ToString());
			return;
		}
		Usage();
	}

	public static void Usage()
	{
		Console.Error.WriteLine("Requires one argument");
		Console.Error.WriteLine();
		Console.Error.WriteLine("  read");
		Console.Error.WriteLine("    Print the contents of the clipboard to stdout");
		Console.Error.WriteLine();
		Console.Error.WriteLine("  write");
		Console.Error.WriteLine("    Set the contents of the clipboard to stdin");
		Environment.Exit(1);
	}
}
