using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Decrypt!") break;
                else
                {
                    int length = int.Parse(Console.ReadLine());
                    string pattern = $@"^(\d{{1,}})([A-Za-z]{{{length},}})(.*[^A-Za-z])$";
                    Match m = Regex.Match(input, pattern);
                    if (m.Success)
                    {
                        string message = m.Groups[2].Value;
                        StringBuilder numCode = new StringBuilder();
                        string digitPattern = @"\d+";
                        MatchCollection digits = Regex.Matches(input, digitPattern);
                        for (int l = 0; l < digits.Count; l++)
                        {
                            numCode.Append(digits[l].Value);
                        }
                        string number = numCode.ToString();
                        if (length == message.Length)
                        {
                            StringBuilder verificationCode = new StringBuilder();
                            for (int i = 0; i < number.Length; i++)
                            {
                                int index = Convert.ToInt32(Convert.ToString(number[i]));
                                if (index < message.Length) verificationCode.Append(message[index]);
                            }
                            Console.WriteLine($"{message} = {verificationCode.ToString()}");
                        }
                        else continue;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
