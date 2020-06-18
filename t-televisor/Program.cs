using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t_televisor
{
    class TV
    {
        public static int Channel = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Текущий канал : 1" + "\nВсего каналов : 99" + "\nЕсли вы хотите переключить канал на следующий - нажмите Z" + "\nЕсли вы хотите переключить канал на предыдущий - нажмите X" + "\nЕсли вы хотите переключить канал по номеру - нажмите N\n");

            string NextChannel;
            while (true)
            {
                do
                {
                    NextChannel = Console.ReadLine();

                    if (NextChannel == "X")
                    {
                        if (Channel == 1)
                        {
                            Channel = 99;
                        }
                        else
                        {
                            Channel--;
                        }

                        Console.WriteLine($"Вы переключили канал на {Channel}\n");
                    }
                    if (NextChannel == "Z")
                    {
                        if (Channel == 99)
                        {
                            Channel = 1;
                        }
                        else
                        {
                            Channel++;
                        }
                        Console.WriteLine($"Вы переключили канал на {Channel}\n");
                    }
                    if (NextChannel == "N")
                    {
                        Console.Write("Введите канал : ");
                        int channel;
                        bool isInt = int.TryParse(Console.ReadLine(), out channel);
                        if (isInt)
                            switchChannel(channel);
                    }
                    if ((NextChannel == "X") && (NextChannel == "Z") && (NextChannel == "N"))
                    {
                        Console.WriteLine("Введите X, Z или N\n");
                    }
                }
                while ((NextChannel != "X") && (NextChannel != "Z") && (NextChannel != "N"));

            }
        }

        static void switchChannel(int channel)
        {
            if (channel > 99)
            {
                channel = 99;
            }
            if (channel < 1)
            {
                channel = 1;
            }

            Channel = channel;

            Console.WriteLine($"Вы переключили канал на {Channel}\n");
        }

    }
}
