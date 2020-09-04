using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        StringBuilder stringBuilder = new StringBuilder();
        isValid = true;
        private string name;
       public string Name
       {
           get
           {
               return name;
           }
           set
           {
               if (string.IsNullOrEmpty(value))
                {
                    stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                    isValid = false;
                }
            }
        } 

       public string ID
       {
           get
           {
               return this.id;
           }
           set
           {
               if (IdUtils.IdIsValid(value))
               {
                   this.ID = value;
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

