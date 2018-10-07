using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleManager

{
    public class Manager
    {
      
            DirectoryInfo current;

        public DirectoryInfo Directory
        {
            get
            {
                return current;
            }
        }

        public Manager()
        {
            current = new DirectoryInfo(@"/Users/Siarhei/Desktop/");
        }

        // логика в бесконечном цикле
        public void menu()
        {
            
            Console.WriteLine("Enter command");
            string command;

            string[] adress; 
      

            while ((command = Console.ReadLine()) != "quit") {
               
               adress = command.Split(' ');
                if (adress.Count() == 0)
                    adress[0] = command;
                
                if (adress.Count() == 0)
                    adress[0] = command;

                //commands
                if (adress[0] == "cd")
                {
                    if (adress.Count() > 1)
                        cd(adress[1]);
                    else
                        Console.WriteLine("There is no second arg");

                }
                else if (adress[0] == "cat")
                    cat(adress[1]);
                else if (adress[0] == "ls")
                    ls();
                else if (adress[0] == "cp")
                {
                    if (adress.Count() > 2)
                        cp(adress[1], adress[2]);
                    else
                        Console.WriteLine("There is no second arg");
                }
                else if (adress[0] == "rm")
                    rm(adress[1]);
                else if(adress[0] == "find"){
                    if (adress.Count() > 1)
                        find(adress[1]);
                    else
                        Console.WriteLine("There is no second arg");
                }
                else if(adress[0] == "mkdir"){
                    if (adress.Count() > 1)
                        mkdir(adress[1]);
                    else
                        Console.WriteLine("There is no second arg");
                }
                else if (adress[0] == "rmdir")
                {
                    if (adress.Count() > 1)
                        rmdir(adress[1]);
                    else
                        Console.WriteLine("There is no second arg");
                }
                    
               
            }
          
        }

        //cd - смена директории 
        private void cd(string path){
            if(path == "..."){
                current = new DirectoryInfo(@"/Users/Siarhei/Desktop/");
                return;
            }

            string new_path;
            DirectoryInfo new_dir;
            if (path.Contains("User"))
                new_path = path;
            else
                new_path = current.ToString() + path + "/";

            new_dir = new DirectoryInfo(new_path);
            if (new_dir.Exists)
            {
                current = new_dir;
                Console.WriteLine(current.ToString());
            }
            else
            Console.WriteLine("Directiry not exists");
        }

       


        // cat - вывод содержимого файла
        private void cat(string path)
        {
            // абсолютный путь
            string toRead;
            if (path.Contains("User"))
            {
                toRead = path;
            }else{//относительный
                toRead = current + path;
            }
           
            //проверка на существование файла
            if(File.Exists(toRead)){
                string text = File.ReadAllText(toRead);
                Console.WriteLine(text);
            }
            else
                Console.WriteLine("Not found");
        }


        //cp - копирование файла
        private void cp(string path1, string path2)
        {
            string from, to;
            from = path1.Contains("User") ? path1 : current + path1;
            to = path2.Contains("User") ? path2 : current + path2;

            if (File.Exists(from))
            {
                    FileInfo file1 = new FileInfo(from);
                    FileInfo file2 = new FileInfo(to);
                    file1.CopyTo(to, true);
            }else{
                Console.WriteLine("No such file(s)");
            }
        }


        //rm - удаление файла
        private void rm(string path){
            string cor_path = path.Contains("User") ? path : current + path;
            if (File.Exists(cor_path))
            {
                File.Delete(cor_path);
                Console.WriteLine("File was deleted");
            }else{
                Console.WriteLine("Such file doesn't exist");
            }
        }

        //ls - вывод содержимого папки
        private void ls(){
            
            DirectoryInfo dir = new DirectoryInfo(current.ToString());
            //имена папок
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
            }
           
            //имена файлов без расширения
            foreach (FileInfo file in dir.GetFiles()) 
            {
                Console.WriteLine(Path.GetFileName(file.ToString())); 
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file.FullName)); 
            }                        
         
           
        }


        // find - поиск файлов с указанным разрешением только в текущей директории
        private void find(string ext)
        {
          
            DirectoryInfo dir = new DirectoryInfo(current.ToString());
            FileInfo[] files = dir.GetFiles($"*{ext}");

            if (files.Count() == 0)
            {
                Console.WriteLine($"No files with extension {ext}");
                return;
            }
            
            foreach (FileInfo file in files) 
            {
                Console.WriteLine(Path.GetFileName(file.ToString())); 
               
            }   
        }

        //mkdir - создает директорию, относительно текущей
        private void mkdir(string name){
           current.CreateSubdirectory(name);
        }
         
        //rmdir - удаление папки вместе с файлами в текущей директории
        private void rmdir(string name){
            string ans;
            string path = current.ToString() + name + "/";

            Console.Write($"Confirm removing {path}: Y/N");
            ans = Console.ReadLine();
            if (ans == "Y" || ans == "y")
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                if (dir.Exists)
                {
                    foreach (var el in dir.GetFiles())
                        el.Delete();
                    dir.Delete();
                }else{
                    Console.WriteLine("Wrong path or u are inside");
                }
            }
            else
                Console.WriteLine("Nothing was delete");
        }  
            

        }
    }


