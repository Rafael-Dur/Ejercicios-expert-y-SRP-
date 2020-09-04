using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        /*No le corresponde a la clase AppointmentService la responsabilidad de verificar
        si los datos son válidos o no. Esta responsabilidad debería ir en otra clase experta en ese campo
        
        No se está cumpliendo con el patrón SRP, ya que el módulo tiene más de un motivo para cambiar, debido a que si
        se desea modificar la forma de verificar algún dato o la cantidad de datos requeridos para crear la cita, se tendría
        que modificar esta clase.*/
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }
    }
}
