﻿


namespace FriendApp.Model
{
    using FriendApp.ViewModel;
    using SQLite;

    public class Friend : Notificable
    {
        #region Atributos
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        private string nombre;
        private string telefono;
        private string correo;
        #endregion
        #region Propiedades

   

        public string Correo 
        {
            get { return correo; }
            set
            {
                SetValue(ref correo, value);
            }
            }


        public string Nombre
        {
            get { return nombre; }
            set {
                SetValue(ref nombre, value);
                }
        }


        public string Telefono
        {
            get { return telefono; }
            set
            {
               SetValue ( ref telefono,  value);
            }
        }




        #endregion
    }
}
