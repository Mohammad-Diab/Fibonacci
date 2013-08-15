using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Numerics;

namespace Fibonacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BigInteger n;
            BigInteger.TryParse(Number.Text, out n);
            if (n < 1)
                MessageBox.Show("Nubmer must be in this domin:\n[1,Infinity[.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                long m1 = DateTime.Now.Ticks;
                BigInteger fib = FibonacciR(n);
                long m2 = DateTime.Now.Ticks;
                long m = m2 - m1;
                MessageBox.Show(String.Concat("Done in ", (((double)m) / 10000).ToString(), " Millisocond\n Fibonacci number is '", fib, "'"), "Dr.Mohammad", MessageBoxButton.OK, MessageBoxImage.Information);
                if (MessageBox.Show("Do you want to save the number? 'if the number is too big, it maybe did not appear in the previous message box'", "Fibonacci", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    System.Windows.Forms.SaveFileDialog SFD = new System.Windows.Forms.SaveFileDialog();
                    SFD.Filter = "Documents Text (*.txt)|*.txt";
                    SFD.Title = "Save Fibonacci Number";
                    if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        System.IO.StreamWriter SW = new System.IO.StreamWriter(SFD.FileName);
                        SW.Write(fib.ToString());
                        SW.Close();
                    }
                }

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            BigInteger n;
            BigInteger.TryParse(Number.Text, out n);
            if (n < 1)
                MessageBox.Show("Nubmer must be in this domin\n[1,Infinity[", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else
            {
                long m1 = DateTime.Now.Ticks;
                BigInteger fib = Fibonacci(n);
                long m2 = DateTime.Now.Ticks;
                long m = m2 - m1;
                MessageBox.Show(String.Concat("Done in ", (((double)m) / 10000).ToString(), " Millisocond\n Fibonacci number is '", fib, "'"), "Dr.Mohammad", MessageBoxButton.OK, MessageBoxImage.Information);
                if (MessageBox.Show("Do you want to save the number? 'if the number is too big, it maybe did not appear in the previous message box'", "Fibonacci", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    System.Windows.Forms.SaveFileDialog SFD = new System.Windows.Forms.SaveFileDialog();
                    SFD.Filter = "Documents Text (*.txt)|*.txt";
                    SFD.Title = "Save Fibonacci Number";
                    if (SFD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        System.IO.StreamWriter SW = new System.IO.StreamWriter(SFD.FileName);
                        SW.Write(fib.ToString());
                        SW.Close();
                    }
                }
            }
        }

        private BigInteger Fibonacci(BigInteger n)
        {
            BigInteger f0 = 0, f1 = 1, f2 = 1;
            if (n == 0) return f0;
            if (n == 0) return f1;
            if (n == 0) return f2;
            for (BigInteger i = 3; i <= n; i++)
            {
                f0 = f1;
                f1 = f2;
                f2 = f0 + f1;
            }
            return f2;
        }

        private BigInteger FibonacciR(BigInteger n)
        {
            if (n == 1 || n == 2)
                return 1;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
