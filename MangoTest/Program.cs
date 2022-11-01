using System;

namespace MangoTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Chess test = new Chess();
            test.Knight();
        }
    }







    public class Phone
    {
        public string[,] PhonePad { get; set; }
        public Phone()
        {
            PhonePad = new string[4, 3]
               {
                    { "1", "2", "3" },
                    { "4", "5", "6" },
                    { "7", "8", "9" },
                    { "*", "0", "#" }
               };
        }
    }


    public class Chess
    {
        Phone phone = new Phone();
        string str = "";
        int count = 0;

 //Make Knight steps and get numbers
        public void Knight()
        {
            int num = 0;
            var colSize = phone.PhonePad.GetUpperBound(num);

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (phone.PhonePad[row, col] == "0" || phone.PhonePad[row, col] == "1")
                    {
                        continue;
                    }

                    if (row == 0)
                    {
                        num = col;
                        if (col == 0 && col < colSize - 1)
                        {
                            str = str + phone.PhonePad[row + 1, col + 2];
                            str = str + phone.PhonePad[row + 2, col + 1];
                        }

                        if (col > 0 && col < colSize - 1)
                        {
                            str = str + phone.PhonePad[row + 2, col - 1];
                            str = str + phone.PhonePad[row + 2, col + 1];
                        }

                        if (col > 0 && col == colSize - 1)
                        {
                            str = str + phone.PhonePad[row + 1, col - 2];
                            str = str + phone.PhonePad[row + 2, col - 1];
                        }

                    }


                    if (row == 1)
                    {
                        num = col;
                        if (col == 0 && col < colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 1, col + 2];
                            str = str + phone.PhonePad[row + 1, col + 2];
                            str = str + phone.PhonePad[row + 2, col + 1];
                        }


                        if (col > 0 && col == colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 1, col - 2];
                            str = str + phone.PhonePad[row + 1, col - 2];
                            str = str + phone.PhonePad[row + 2, col - 1];
                        }
                    }

                    if (row == 2)
                    {
                        num = col;
                        if (col == 0 && col < colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 1, col + 2];
                            str = str + phone.PhonePad[row - 2, col + 1];
                        }

                        if (col > 0 && col < colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 2, col - 1];
                            str = str + phone.PhonePad[row - 2, col + 1];
                        }

                        if (col > 0 && col == colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 1, col - 2];
                            str = str + phone.PhonePad[row - 2, col - 1];
                        }
                    }

                    if (row == 3)
                    {
                        num = col;
                        if (col == 0 && col < colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 1, col + 2];
                            str = str + phone.PhonePad[row - 2, col + 1];
                        }

                        if (col > 0 && col < colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 2, col - 1];
                            str = str + phone.PhonePad[row - 2, col + 1];
                        }

                        if (col > 0 && col == colSize - 1)
                        {
                            str = str + phone.PhonePad[row - 1, col - 2];
                            str = str + phone.PhonePad[row - 2, col - 1];
                        }

                    }

                }

            }

//Print result
            string PhoneNumbers = "";
            int counter = 0;
            for (var i = 0; i < str.Length; i++)
            {
                PhoneNumbers = PhoneNumbers + str[i];
                counter++;
                if (counter == 7)
                {
                    PhoneNumbers = PhoneNumbers + "--";
                    counter = 0;
                }
            }

            foreach (char item in str)
            {

                if (Char.IsDigit(item))
                {
                    count++;
                }
            }
            Console.WriteLine("Knight Phone number = " + PhoneNumbers);
            Console.WriteLine("Number of steps for Knight = " + count);
        }



        public void Rook()
        {

        }

        public void Queen()
        {

        }

        public void Bishop()
        {

        }

        public void King()
        {

        }
    }
}