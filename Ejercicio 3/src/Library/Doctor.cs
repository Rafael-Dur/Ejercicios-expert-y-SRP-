using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        Boolean isValid = true;
       public string Name
       {
           get
           {
               return this.name;
           }
           set
           {
               if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }
           }
       } 
       private string Name;

       public string profession
       {
           get
           {
               return this.profession;
           }
           set
           {
                if (string.IsNullOrEmpty(profession))
            {
                stringBuilder.Append("Unable to schedule appointment, Professiion is required\n");
                isValid = false;
            }
           }
       }
        private string id;
        public Person(string name, string id)
        {
            this.Name = name;
            this.ID = id;
        }  
        public void IntroduceYourself()
        {
            Console.WriteLine($"Nombre:{this.name} - Cédula: {this.id}");
        }
    
    }
}

