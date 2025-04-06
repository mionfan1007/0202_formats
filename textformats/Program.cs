using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace textformats
{

    public class Module1<T>
    {
        public List<T> Read (string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }

                List<T> values = new List<T>();
                StreamReader sr = new StreamReader(filename);
               
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    var line1 = (T) Convert.ChangeType(line, typeof(T));
                    values.Add(line1);
                    
                }
                sr.Close();
               return values; 
            }
            catch (Exception e)
            { 
            Console.WriteLine ("exception = " + e.Message);
             throw;
            }
        }

        public void Write (string filename, List<T> values)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }
                StreamWriter streamWriter = new StreamWriter(filename);
                
                foreach (T item in values)
                {
                    streamWriter.WriteLine(item);
                }
                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }
    }
    public class Formats
    {
        public void CSVWrite(string filename, List<string> values)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }

                if (!filename.EndsWith(".csv"))
                {
                    Console.WriteLine($"{filename} has wrong format");
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter(filename);
                    foreach (string item in values)
                    {
                        streamWriter.Write($"{item};");
                    }
                    streamWriter.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }
        public void JSONWrite(string filename, List<string> values)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }

                if (!filename.EndsWith(".json"))
                {
                    Console.WriteLine($"{filename} has wrong format");
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter(filename);
                    foreach (string item in values)
                    {
                        streamWriter.WriteLine("\"" + item + "\"");
                    }
                    streamWriter.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }

        public void XMLWrite(string filename, List<string> values)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }

                if (!filename.EndsWith(".xml"))
                {
                    Console.WriteLine($"{filename} has wrong format");
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter(filename);
                    foreach (string item in values)
                    {
                        streamWriter.WriteLine("<" + item + ">");
                    }
                    streamWriter.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }

        public void YAMLWrite(string filename, List<string> values)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }

                if (!filename.EndsWith(".yml"))
                {
                    Console.WriteLine($"{filename} has wrong format");
                }
                else
                {
                    StreamWriter streamWriter = new StreamWriter(filename);
                    foreach (string item in values)
                    {
                        streamWriter.WriteLine(item);
                    }
                    streamWriter.Close();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }

        public List<string> CSVRead(string filename)
        {
            try
            {
               

                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }
                if (!filename.EndsWith(".csv"))
                {
                    Console.WriteLine($"{filename} has wrong format");
                }

                List<string> values = new List<string>();
                StreamReader sr = new StreamReader(filename);
               
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lines = line.Split(';');
                    foreach (string s in lines)
                    {
                        values.Add(s);
                    }
                }
                sr.Close();
                return values;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }

        }

        public List<string> XMLRead(string filename)
        {
            try
            {
              
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }
               
                List<string> values = new List<string>();
                StreamReader sr = new StreamReader(filename);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    values.Add(line);
                    
                }
                sr.Close();
                return values;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }

        }

        public List<string> JSONRead(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }
                if (!filename.EndsWith(".json"))
                {
                    Console.WriteLine($"{filename} has wrong format");
                }

                List<string> values = new List<string>();
                StreamReader sr = new StreamReader(filename);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    values.Add(line);

                }
                sr.Close();
                return values;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }

        public List<string> YAMLRead(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }
                if (!filename.EndsWith(".yml"))
                {
                    Console.WriteLine($"{filename} has wrong format");
                }

                List<string> values = new List<string>();
                StreamReader sr = new StreamReader(filename);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    values.Add(line);

                }
                sr.Close();
                return values;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }

        }


    }
    public class Menu1
    {
        public List<string[]> values = new List<string[]>();

        public List<string[]> GetList ()
        {
            return values;
        }

        public List<string[]> ReadFromFile (string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }

                StreamReader sr = new StreamReader(filename);
                
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    string[] lines = line.Split(',');
                    values.Add(lines);
                }
                sr.Close();
                return values;
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }

        public void WriteInoFile(string filename, List<string[]> values)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    using (File.Create(filename)) { }
                }
                StreamWriter streamWriter = new StreamWriter(filename);

                foreach (string[] item in values)
                {
                    string a = string.Join(",", item);
                    streamWriter.WriteLine(a);
                }
                streamWriter.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception = " + e.Message);
                throw;
            }
        }


        public void Print(List<string[]> values)
        {
            foreach (string[] line in values)
            {
                foreach (string value in line)
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }

        public List<string[]> AddItem(List<string[]> values, string[] item)
        {
            values.Add(item);
            return values;
        }
        public List<string[]> RemoveItem(List<string[]> values,string item)
        {
            foreach (string[]item1 in values)
            {
                if (item1[0] == item)
                {
                    values.Remove(item1);
                    Console.WriteLine("строка убрана");
                    break;
                }
                
            }
            return values;
        }
        public List<string[]> AlterItem(List<string[]> values, string item)
        {
            foreach (string[]item1 in values)
            {
                if (item1[0] == item)
                {
                    values.Remove(item1);
                    Console.WriteLine("введите то, на что необходимо заменить строку (через запятую) = ");
                    string a = Console.ReadLine();
                    string [] item2 = a.Split(',');
                    values.Add(item2);
                    break;
                }
            }
            return values;
  
        }

        public List<string[]> Sort(List<string[]> values, string parameter)
        {
           if (parameter == "1")
            {
                List<string[]> sortBy1 = values.OrderBy(x => x[0]).ToList();
                return sortBy1; 
            }
           else if (parameter == "2")
            {
                List<string[]> sortBy2 = values.OrderBy(x => x[1]).ToList();
                return sortBy2;
            }
           else if (parameter == "3")
            {
                List<string[]> sortBy3 = values.OrderBy(x => x[2]).ToList();
                return sortBy3;
            }
           else if (parameter == "4")
            {
                List<string[]> sortBy4 = values.OrderBy(x => x[3]).ToList();
                return sortBy4;
            }
           else if (parameter == "5")
            {
                List<string[]> sortBy5 = values.OrderBy(x => Convert.ToInt32(x[4])).ToList();
                return sortBy5;
            }
           else
            {
                Console.WriteLine("неверный параметр, введите число от 1 до 5");
                return null;
            }
        }

        public string SearchItem(string parameter, List<string[]> values)
        {
           
            foreach (string[] item in values)
            {
                foreach (string line in  item)
                {
                    string line1 = line.Trim();
                    if (line1 == parameter)
                    {
                        string a = string.Join(",", item);
                        Console.WriteLine("найдена строка " + a);
                        return a;
                        
                    }
                }
            }
            return null;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Menu1 menu1 = new Menu1();
            List<string[]> values = menu1.GetList();
            bool flag = true;
            try
            {
                while (flag)
                {
                    Console.WriteLine("выберите опцию от 1 до 8 (0 чтобы выйти): ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    if (n == 0)
                    {
                        flag = false;
                        break;
                    }
                    else if (n == 1)
                    {
                        Console.WriteLine("считывание данных из файла. введите имя файла с расширением: ");
                        string filename = Console.ReadLine();
                        values = menu1.ReadFromFile(filename);
                        menu1.Print(values);
                    }
                    else if (n == 2)
                    {
                        Console.WriteLine("запись данных в файл. введите имя файла с расширением: ");
                        string filename = Console.ReadLine();
                        menu1.WriteInoFile(filename, values);
                    }
                    else if (n == 3)
                    {
                        Console.WriteLine("вывод данных на экран: ");
                        menu1.Print(values);
                    }
                    else if (n == 4)
                    {
                        Console.WriteLine("сортировка данных по параметру. введите параметр от 1 до 5: ");
                        string parameter = Console.ReadLine();
                        List<string[]> values1 = menu1.Sort(values, parameter);
                        menu1.Print(values1);
                    }
                    else if (n == 5)
                    {
                        Console.WriteLine("поиск данных по подстроке. введите подстроку: ");
                        string line = Console.ReadLine();
                        menu1.SearchItem(line, values);
                    }
                    else if (n == 6)
                    {
                        Console.WriteLine("добавление данных в структуру. введите строку добавляемых данных (через запятую): ");
                        string line = Console.ReadLine();
                        string[] splitLine = line.Split(',');
                        List<string[]> values2 = menu1.AddItem(values, splitLine);
                        menu1.Print(values2);
                    }
                    else if (n == 7)
                    {
                        Console.WriteLine("удаление строки из структуры. введите идентификатор удаляемой строки: ");
                        string line = Console.ReadLine().Trim();

                        List<string[]> values3 = menu1.RemoveItem(values, line);
                        menu1.Print(values3);
                    }
                    else if (n == 8)
                    {
                        Console.WriteLine("изменение строки в структуре. введите идентификатор изменяемой строки: ");
                        string line = Console.ReadLine().Trim();
                        List<string[]> values4 = menu1.AlterItem(values, line);
                        menu1.Print(values4);

                    }
                    else
                    {
                        Console.WriteLine("неверный параметр");
                    }
                }
               
            }
            catch
            {
                Console.WriteLine("error");
                throw;
            }
            
        }
    }
}
