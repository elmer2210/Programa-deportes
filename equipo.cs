namespace deporte
{
    public class Equipo
    {
        private int Id {get; set;}
        public string Nombre {get; set;}
        private int NumeroJugadores {get; set;}
        public string Capitan {get; set;}

        public string PresentarEquipo(){
            return $"# El esquipo es {Nombre} y su capitan es {Capitan}";
        } 
    }
}
