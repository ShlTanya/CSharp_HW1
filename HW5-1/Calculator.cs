using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_5_1
{
	public interface ICalcLogger
	{
		void Log(string operand1, string operand2, string op, double result);
		void Error(string message);
		void Info(string message);

	}
	
	public class TextBoxLogger: ICalcLogger
    {
		private readonly TextBox _textbox;
		public TextBoxLogger(TextBox textBox)
        {
			_textbox = textBox;
        }
		public void Log(string operand1, string operand2, string op, double result)
		{
			_textbox.Text += ($"{operand1} {op} {operand2} = {result}\r\n");
		}

		public void Error(string message)
		{
			_textbox.Text += ($"error: {message}\r\n");
		}

		public void Info(string message)
		{
			_textbox.Text += ($"info: {message}\r\n");
		}
	}

	public class ConsoleLogger : ICalcLogger
	{
		public void Log(string operand1, string operand2, string op, double result)
		{
			Console.WriteLine($"{operand1} {op} {operand2} = {result}");
		}

		public void Error(string message)
		{
			Console.WriteLine($"error: {message}");
		}

		public void Info(string message)
		{
			Console.WriteLine($"info: {message}");
		}

	}

	public class Calculator
	{
		private ICalcLogger _logger;
		private double? _result;
		private double? _memory;

		public Calculator(ICalcLogger logger)
		{
			_logger = logger;
		}
		public double? Operand1 { get; private set; }
		public double? Operand2 { get; private set; }
		public string Operation { get; private set; }


		public Calculator SetOperand(double value)
		{
			if (Operand1 == null)
			{
				return SetOp1(value);
			}
			return SetOp2(value);
		}
		public Calculator SetOp1(double value)
		{
			this.Operand1 = value;
			return this;
		}

		public Calculator SetOp2(double value)
		{
			this.Operand2 = value;
			return this;
		}

		public Calculator SetOperation(string operation)
		{
			if (Operand2 != null)
			{
				Calc();
			}
			this.Operation = operation;
			return this;
		}

		public double? GetResult()
		{
			Calc();
			return _result;
		}

		public void Clear()
		{
			Operand1 = null;
			Operand2 = null;
			Operation = "";
			_result = null;
			_logger.Info("clear");
		}

		private void Calc()
		{
			bool hasError = false;
			if (Operand1 == null || Operand2 == null || Operation == "")
			{
//				_logger.error("input data not valid");
				return;
			}
			switch (Operation)
			{
				case "+":
					_result = Operand1 + Operand2;
					break;
				case "-":
					_result = Operand1 - Operand2;
					break;
				case "*":
					_result = Operand1 * Operand2;
					break;
				case "^2":
					_result = Operand1 * Operand1;
					break;
				case "/":
					if (0 == Operand2)
					{
						_logger.Error("divide by 0");
						hasError = true;
						break;
					}
					_result = Operand1 / Operand2;
					break;
				default:
					_logger.Error($"invalid operation \"{Operation}\"");
					hasError = true;
					break;
			}
			if (hasError)
			{
				return;
			}
			_logger.Log(
				Operand1.ToString(),
				Operation != "^2" ? Operand2.ToString() : "",
				Operation,
				_result ?? default(double)
			);
			Operand1 = _result;
			Operation = "";
			Operand2 = null;
		}
		public Calculator MemSave(double value)
		{
			_memory = value;
			return this;
		}

		public Calculator MemRestore()
		{
			if (_memory == null)
			{
				_logger.Error("nothing to restore");
				// TODO: must throw Exception here, non return self
				return this;
			}
			SetOperand(_memory ?? default(double));
			_memory = null;
			return this;
		}
	}
}
