using System;

namespace _19dechomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- Verilmiş string dəyərindəki bütün sözlərin arasında bir boşluq qalacaq vəziyyətə salan metod.
            //(Metoda "  Men   rusca    bilmirem" dəyəri göndərilərsə onu "Men rusca bilmirem" halına gətirməlidir.

            string wordstr = Console.ReadLine();
            string word = wordstr.Trim();
            OneSpace(ref word);
            Console.WriteLine(word);






            //Verilmiş string dəyərdəki sözlərin sayını tapan metod (boşluqlarla ayrılmış bütün ifadələr)
            string soz = Console.ReadLine();

           
            OneSpace(ref soz);
            int sayi = 0;
            var Final = soz.Insert(soz.Length - 1, " ");
            for (int i = 0; i < Final.Length; i++)
            {
                if (Final[i] == ' ')
                {
                    sayi++;

                }

            }
            Console.WriteLine(sayi);

            string[] newarray = { "amin israfilzade", "elvin bilalov" };
            OnlyFirstName(ref newarray);
            for (int i = 0; i < newarray.Length; i++)
            {
                Console.WriteLine(newarray[i]);
            }

            string ad = "Amin Israfilzade";

            Console.WriteLine(Onefullname(ad));




        }

        static void OneSpace(ref string word)
        {
            string result = "";
            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == ' ' && word[i + 1] == ' ')// burda i+1 yerine i++ yazanda duzgun islemirdi. niye?
                {
                    continue;
                }
                else
                {
                    result += word[i];
                }
            }
            word = result;
        }
        //Parameter olaraq integer array variable-ı (reference) və
        //bir integer value qəbul edən və həmin integer value-nu integer array-ə yəni element kimi əlavə edən metod.
        static void AddValue(ref int[] nums, int addednumber)
        {
            int[] newarray = new int[nums.Length + 1];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                newarray[j] = nums[i];
                j++;
            }
            newarray[j] = addednumber;
            nums = newarray;
        }
        //Gonderilmis fullname arrayinden yeni bir names arrayi duzeldib geri qaytaran metod.
        //Fullname arrayinin icindeki butun value-lar ad+" "+soyad formatindadir.Misalcun "Hikmet Abbasov".
        //Misalcun gelen arraydeki deyerler {"Hikmet Abbasov","Abdulla Qulamov","Cemile Hikmetova"} olarsa,
        //return olunan arraydeki deyerler {"Hikmet","Abdulla","Cemile"} olmalidir

        static void OnlyFirstName(ref string[] Fullnames)
        {
            string[] Firstnames = new string[Fullnames.Length];
            string Firstname = "";
            for (int i = 0; i < Fullnames.Length; i++)
            {
                for (int j = 0; j < Fullnames[i].Length; j++)
                {
                    var fullname = Fullnames[i];
                    if (fullname[j] == ' ')
                    {

                        break;
                    }

                    else
                    {
                        Firstname += fullname[j];
                        Firstnames[i] = Firstname;
                    }


                }
                Firstname = "";


            }

            Fullnames = Firstnames;
        }
        //Verilmiş string dəyərin bir fullname olub olmadığını yoxlayan metod.
        //(Dəyərin fullname olma şərti daxilində yalnız hərflərin ola bilməsi, yalnız 2 sözdən ibarət olması və
        //hər bir sözün böyük hərfə başlayıb kiçik hərflərlə davam etməsidir.
        static bool Onefullname( string fullname)
        {
            bool isdigit = true;
            bool firstUpper = true;
            bool secondUpper = true;
            bool firstlower = true;
            bool secondlower = true;

            for (int i = 0; i < fullname.Length; i++)
            {
                if (Char.IsDigit(fullname[i]))
                {
                    isdigit = false;
                    break;
                }
                else
                {
                    isdigit = true;  
                }
            }
            if (Char.IsUpper(fullname[0]))
            {
                firstUpper = true;

            }
            else
            {
                firstUpper = false;
                
            }
            if (fullname.IndexOf(' ') != -1)
            {
                for (int i = fullname.IndexOf(' ')+1; i < i+1;)
                {
                    if (Char.IsUpper(fullname[i]))
                    {
                        secondUpper = true;
                        break;
                    }
                    else
                    {
                        secondUpper = false;
                        break;
                    }
                }
                for (int i = 1; i < fullname.IndexOf(' '); i++)
                {
                    if (Char.IsLower(fullname[i]))
                    {
                        firstlower = true;
                    }
                    else
                    {
                        firstlower = false;
                        break;
                    }
                }
                for (int i = fullname.IndexOf(' ')+2; i < fullname.Length; i++)
                {
                    if (Char.IsLower(fullname[i]))
                    {
                        secondlower = true;
                    }
                    else
                    {
                        secondlower = false;
                        break;
                    }
                }

            }
            else
            {
                firstUpper = false;
            }
            if (firstUpper == true && secondUpper == true && isdigit == true  && firstlower == true && secondlower == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
