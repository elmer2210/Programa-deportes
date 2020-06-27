namespace deporte
{
    public class Deporte
    {
        private int Id {get; set;} 
        public string Nombre {get; set;}
        public string TipoDeporte {get; set;}
        public string TiempoJuego {get; set;}

        public string PresentarDeporte(){
            return $"# El {Nombre} es un deporte clasificado como {TipoDeporte} y dura {TiempoJuego}";
        }

    }
}