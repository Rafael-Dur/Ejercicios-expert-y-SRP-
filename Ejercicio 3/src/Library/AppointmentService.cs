using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            
            Boolean isValid = true;

            string msg=Validacion.Validate(name,id,phoneNumber,date,appoinmentPlace,doctorName); 
            if(msg!="")
            {
                isValid=false;
                stringBuilder.Append(msg);
            }
            
            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }
            return stringBuilder.ToString();
        }
    }
}
